using AutoMapper;
using MediatR;
using 국토교통부_공공데이터Common.Model;
using 국토교통부_공공데이터Common.공동주택_단지_목록제공_서비스;
using 국토교통부_공공데이터Common.국토교통부_공동주택단지목록제공서비스;

namespace 국토교통부_공공데이터Common.Handlr
{
    public class 공동주택단지목록정보수집Handlr : IRequestHandler<공동주택단지Request, Unit>
    {
        private readonly 공동주택DbContext _context;
        private readonly 공동주택단지목록APIService _APIService;
        private readonly IMapper _mapper;
        public 공동주택단지목록정보수집Handlr(IMapper mapper, 공동주택DbContext context, 공동주택단지목록APIService aPIService)
        {
            _mapper = mapper;
            _context = context;
            _APIService = aPIService;
        }
        /// <summary>
        /// APIService로 전체목록을 Get하는 단계
        /// 반복문 안에서 동일한 DB에 KAptCode가 있는지 확인단계
        /// 없는 경우 Model로 Mapping 하고 DB에 Add하는 단계를 포함하는 공동주택단지구성Handlr프로세스
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<Unit> Handle(공동주택단지Request request, CancellationToken cancellationToken)
        {
            // API에서 전체 공동주택 목록을 가져옵니다.
            var aptResponse = await _APIService.GetTotalAptListAsync();

            // 가져온 데이터를 데이터베이스 엔티티로 매핑합니다.
            foreach (var item in aptResponse.Body.Items.Items)
            {
                // 데이터베이스에 이미 같은 공동주택이 있는지 검사합니다.
                var existingEntity = _context.Set<공동주택>().FirstOrDefault(e => e.단지코드 == item.KaptCode);
                if (existingEntity == null)
                {
                    // 존재하지 않는 경우, 새 엔티티를 생성하여 추가합니다.
                    var mappedEntity = _mapper.Map<공동주택>(item);
                    Console.WriteLine(mappedEntity.단지명);
                    _context.Set<공동주택>().Add(mappedEntity);
                }
                else
                {
                    // 이미 존재하는 경우, 필요한 경우 정보를 업데이트할 수 있습니다.
                    _mapper.Map(item, existingEntity);
                }
            }

            // 변경 사항을 데이터베이스에 저장합니다.
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value; // MediatR 핸들러는 일반적으로 Unit.Value를 반환합니다.
        }
    }
}
