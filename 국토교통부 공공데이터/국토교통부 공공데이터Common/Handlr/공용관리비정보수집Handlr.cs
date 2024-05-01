using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using 국토교통부_공공데이터Common.Model;
using 국토교통부_공공데이터Common.공용관리비_정보제공서비스;
using 국토교통부_공공데이터Common.공용관리비정보제공서비스;

namespace 국토교통부_공공데이터Common.Handlr
{
    public class 공용관리비정보수집Handlr : IRequestHandler<공용관리비Request, Unit>
    {
        private readonly 공동주택DbContext _Context;
        private readonly 공동주택공용관리비APIService _APIService;
        private readonly IMapper _Mapper;

        public 공용관리비정보수집Handlr(공동주택DbContext context, 공동주택공용관리비APIService aPIService, IMapper mapper)
        {
            _Context = context;
            _APIService = aPIService;
            _Mapper = mapper;
        }

        public async Task<Unit> Handle(공용관리비Request request, CancellationToken cancellationToken)
        {
            // 데이터베이스에서 기존 정보 로드 또는 새로 생성
            var 공용관리비 = await _Context.Set<공용관리비>().FirstOrDefaultAsync(
                x => x.단지코드 == request.kaptCode && x.date == request.searchDate,
                cancellationToken);

            if (공용관리비 == null)
            {
                공용관리비 = new 공용관리비 { 단지코드 = request.kaptCode, date = request.searchDate };
                _Context.Set<공용관리비>().Add(공용관리비);
            }

            // 각 API 서비스를 통해 외부 데이터 요청 및 응답 매핑
            var 난방비Response = await _APIService.Get난방비(request);
            var 경비비Response = await _APIService.Get경비비(request);
            var 기타부대비용Response = await _APIService.Get기타부대비용(request);
            var 수선비Response = await _APIService.Get수선비(request);
            var 승강기유지비Response = await _APIService.Get승강기유지비(request);
            var 시설유지비Response = await _APIService.Get시설유지비(request);
            var 안전점검비Response = await _APIService.Get안전점검비(request);
            var 위탁관리수수료Response = await _APIService.Get위탁관리수수료(request);
            var 인건비Response = await _APIService.Get인건비(request);
            var 재해예방비Response = await _APIService.Get재해예방비(request);
            var 제사무비Response = await _APIService.Get제사무비(request);
            var 제세공과금Response = await _APIService.Get제세공과금(request);
            var 지능형홈네트워크설비유지비Response = await _APIService.Get지능형홈네트워크설비유지비(request);
            var 차량유지비Response = await _APIService.Get차량유지비(request);
            var 청소비Response = await _APIService.Get청소비(request);
            var 피복비Response = await _APIService.Get피복비(request);
            var 소독비Response = await _APIService.Get소독비(request);

            _Mapper.Map(난방비Response, 공용관리비);
            _Mapper.Map(경비비Response, 공용관리비);
            _Mapper.Map(기타부대비용Response, 공용관리비);
            _Mapper.Map(수선비Response, 공용관리비);
            _Mapper.Map(승강기유지비Response, 공용관리비);
            _Mapper.Map(시설유지비Response, 공용관리비);
            _Mapper.Map(안전점검비Response, 공용관리비);
            _Mapper.Map(위탁관리수수료Response, 공용관리비);
            _Mapper.Map(인건비Response, 공용관리비);
            _Mapper.Map(재해예방비Response, 공용관리비);
            _Mapper.Map(제사무비Response, 공용관리비);
            _Mapper.Map(제세공과금Response, 공용관리비);
            _Mapper.Map(지능형홈네트워크설비유지비Response, 공용관리비);
            _Mapper.Map(차량유지비Response, 공용관리비);
            _Mapper.Map(청소비Response, 공용관리비);
            _Mapper.Map(피복비Response, 공용관리비);
            _Mapper.Map(소독비Response, 공용관리비);

            await _Context.SaveChangesAsync(cancellationToken);

            return Unit.Value; // MediatR의 단위 작업이 완료됨을 의미
        }
    }
}
