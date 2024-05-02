using AutoMapper;
using MediatR;
using 국토교통부_공공데이터Common.에너지사용정보_정보서비스;
using 국토교통부_공공데이터Common.에너지사용정보_정보서비스.RequestModel;
using 국토교통부_공공데이터Common.Model;
using Microsoft.EntityFrameworkCore;

namespace 국토교통부_공공데이터Common.Handlr
{
    public class 에너지사용정보수집Handler : IRequestHandler<단지에너지사용량Request, Unit>
    {
        private readonly 공동주택DbContext _DbContext;
        private readonly 공동주택에너지사용정보APIService _APIService;
        private readonly IMapper _Mapper;

        public 에너지사용정보수집Handler(공동주택DbContext dbContext, 공동주택에너지사용정보APIService apiService, IMapper mapper)
        {
            _DbContext = dbContext;
            _APIService = apiService;
            _Mapper = mapper;
        }

        public async Task<Unit> Handle(단지에너지사용량Request request, CancellationToken cancellationToken)
        {
            // 데이터베이스에서 기존 정보 로드 또는 새로 생성
            var 에너지사용정보 = await _DbContext.Set<에너지사용정보>().FirstOrDefaultAsync(
                x => x.단지코드 == request.kaptCode && x.date == request.searchDate,
                cancellationToken);
            if (에너지사용정보 == null)
            {
                에너지사용정보 = new 에너지사용정보 { 단지코드 = request.kaptCode, date = request.searchDate };
                _DbContext.Set<에너지사용정보>().Add(에너지사용정보);
            }

            // API 서비스를 통해 외부 데이터 요청
            var 단지에너지사용량Response = await _APIService.Get단지에너지사용량(request);


            // 응답 데이터를 에너지사용정보 객체에 매핑
            _Mapper.Map(단지에너지사용량Response.Body.Item, 에너지사용정보);

            Console.WriteLine($"날짜: {에너지사용정보.date}");
            Console.WriteLine($"난방사용금액: {에너지사용정보.난방사용금액}");
            Console.WriteLine($"난방사용량: {에너지사용정보.난방사용량}");
            Console.WriteLine($"급탕사용금액: {에너지사용정보.급탕사용금액}");
            Console.WriteLine($"급탕사용량: {에너지사용정보.급탕사용량}");
            Console.WriteLine($"가스사용금액: {에너지사용정보.가스사용금액}");
            Console.WriteLine($"가스사용량: {에너지사용정보.가스사용량}");
            Console.WriteLine($"전기사용금액: {에너지사용정보.전기사용금액}");
            Console.WriteLine($"전기사용량: {에너지사용정보.전기사용량}");
            Console.WriteLine($"수도사용금액: {에너지사용정보.수도사용금액}");
            Console.WriteLine($"수도사용량: {에너지사용정보.수도사용량}");

            // 데이터베이스에 업데이트
            await _DbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value; // MediatR의 단위 작업이 완료됨을 의미
        }
    }
}
