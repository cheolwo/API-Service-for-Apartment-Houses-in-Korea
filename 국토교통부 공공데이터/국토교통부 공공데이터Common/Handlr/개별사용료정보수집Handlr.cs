using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using 국토교통부_공공데이터Common.Model;
using 국토교통부_공공데이터Common.개발사용료_정보제공_서비스;
using 국토교통부_공공데이터Common.개발사용료정보제공서비스;

namespace 국토교통부_공공데이터Common.Handlr
{
    public class 개별사용료정보수집Handler : IRequestHandler<개별사용료정보제공Request, Unit>
    {
        private readonly 공동주택DbContext _DbContext;
        private readonly 공동주택개별관리비APIService _APIService;
        private readonly IMapper _Mapper;

        public 개별사용료정보수집Handler(공동주택DbContext dbContext, 공동주택개별관리비APIService apiService, IMapper mapper)
        {
            _DbContext = dbContext;
            _APIService = apiService;
            _Mapper = mapper;
        }

        public async Task<Unit> Handle(개별사용료정보제공Request request, CancellationToken cancellationToken)
        {
            // 데이터베이스에서 기존 정보 로드 또는 새로 생성
            var 개별사용료 = await _DbContext.Set<개별사용료>().FirstOrDefaultAsync(
                x => x.단지코드 == request.kaptCode && x.date == request.searchDate,
                cancellationToken);
            if (개별사용료 == null)
            {
                개별사용료 = new 개별사용료 { 단지코드 = request.kaptCode, date = request.searchDate };
                _DbContext.Set<개별사용료>().Add(개별사용료);
            }

            // API 서비스를 통해 외부 데이터 요청
            var 급탕비Response = await _APIService.Get급탕비(request);
            var 난방비Response = await _APIService.Get난방비(request);
            var 가스사용료Response = await _APIService.Get가스사용료(request);
            var 전기료Response = await _APIService.Get전기료(request);
            var 수도료Response = await _APIService.Get수도료(request);
            var 정화조오물수수료Response = await _APIService.Get정화조오물수수료(request);
            var 생활폐기물수수료Response = await _APIService.Get생활폐기물수수료(request);
            var 입주자대표회의운영비Response = await _APIService.Get입주자대표회의운영비(request);
            var 건물보험료Response = await _APIService.Get건물보험료(request);
            var 선거관리위원회운영비Response = await _APIService.Get선거관리위원회운영비(request);

            // 응답 데이터를 개별사용료 객체에 매핑
            _Mapper.Map(급탕비Response.Body.Item, 개별사용료);
            _Mapper.Map(난방비Response.Body.Item, 개별사용료);
            _Mapper.Map(가스사용료Response.Body.Item, 개별사용료);
            _Mapper.Map(전기료Response.Body.Item, 개별사용료);
            _Mapper.Map(수도료Response.Body.Item, 개별사용료);
            _Mapper.Map(정화조오물수수료Response.Body.Item, 개별사용료);
            _Mapper.Map(생활폐기물수수료Response.Body.Item, 개별사용료);
            _Mapper.Map(입주자대표회의운영비Response.Body.Item, 개별사용료);
            _Mapper.Map(건물보험료Response.Body.Item, 개별사용료);
            _Mapper.Map(선거관리위원회운영비Response.Body.Item, 개별사용료);
            // 데이터베이스에 업데이트
            await _DbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value; // MediatR의 단위 작업이 완료됨을 의미
        }
    }
}
