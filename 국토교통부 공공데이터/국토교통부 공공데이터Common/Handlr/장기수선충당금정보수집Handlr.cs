using AutoMapper;
using MediatR;
using 국토교통부_공공데이터Common.장기수선충당금_정보서비스;
using 국토교통부_공공데이터Common.Model;
using Microsoft.EntityFrameworkCore;

namespace 국토교통부_공공데이터Common.Handlr
{
    public class 장기수선충당금Handler : IRequestHandler<장기수선충당금Request, Unit>
    {
        private readonly 공동주택DbContext _DbContext;
        private readonly 공동주택장기수선충당금APIService _APIService;
        private readonly IMapper _Mapper;

        public 장기수선충당금Handler(공동주택DbContext dbContext, 공동주택장기수선충당금APIService apiService, IMapper mapper)
        {
            _DbContext = dbContext;
            _APIService = apiService;
            _Mapper = mapper;
        }

        public async Task<Unit> Handle(장기수선충당금Request request, CancellationToken cancellationToken)
        {
            // 데이터베이스에서 기존 정보 로드 또는 새로 생성
            var 장기수선충당금 = await _DbContext.Set<장기수선충당금>().FirstOrDefaultAsync(
                x => x.단지코드 == request.kaptCode && x.date == request.searchDate,
                cancellationToken);
            if (장기수선충당금 == null)
            {
                장기수선충당금 = new 장기수선충당금 { 단지코드 = request.kaptCode, date = request.searchDate };
                _DbContext.Set<장기수선충당금>().Add(장기수선충당금);
            }

            // API 서비스를 통해 외부 데이터 요청
            var 단지별월부과액Response = await _APIService.Get단지별월부과액(request);
            var 단지별월사용액Response = await _APIService.Get단지별월사용액(request);
            var 단지별적립요율Response = await _APIService.Get단지별적립요율(request);
            var 단지별충당금잔액Response = await _APIService.Get단지별충당금잔액(request);


            // 응답 데이터를 장기수선충당금 객체에 매핑
            _Mapper.Map(단지별월부과액Response.Body.Item, 장기수선충당금);
            _Mapper.Map(단지별월사용액Response.Body.Item, 장기수선충당금);
            _Mapper.Map(단지별적립요율Response.Body.Item, 장기수선충당금);
            _Mapper.Map(단지별충당금잔액Response.Body.Item, 장기수선충당금);

            Console.WriteLine($"날짜: {장기수선충당금.date}");
            Console.WriteLine($"월부과액: {장기수선충당금.월부과액}");
            Console.WriteLine($"월사용액: {장기수선충당금.월사용액}");
            Console.WriteLine($"적립요율: {장기수선충당금.적립요율}%");
            Console.WriteLine($"충당금잔액: {장기수선충당금.충당금잔액}");

            // 데이터베이스에 업데이트
            await _DbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value; // MediatR의 단위 작업이 완료됨을 의미
        }
    }
}
