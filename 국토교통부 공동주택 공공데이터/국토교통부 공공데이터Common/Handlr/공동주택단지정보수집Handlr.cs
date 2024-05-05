using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using 국토교통부_공공데이터Common.공동주택_기본정보_제공서비스.RequestModel;
using 국토교통부_공공데이터Common.공동주택_기본정보_제공서비스;
using 국토교통부_공공데이터Common;
using 국토교통부_공공데이터Common.Model;

/// <summary>
/// 공동주택DbContext에서
/// Address가 Null인
/// 단지목록 조회단계

/// 단지목록을 순회하며
/// kaptCode를 통해
/// 단지정보수집APIService에
/// Http 요청단계

/// 공동주택상세정보Response된 Item을
/// 공동주택 Model에 Mapping 단계

/// 공동주택DbContext를 통해
/// Model을 Update하는 단계를 포함하는 공동주택단지
/// 정보수집 프로세스
/// </summary>
public class 공동주택단지정보수집Handlr : IRequestHandler<공동주택상세정보Request, Unit>
{
    private readonly 공동주택DbContext _context;
    private readonly 공동주택단지정보APIService _APIService;
    private readonly IMapper _mapper;

    public 공동주택단지정보수집Handlr(공동주택DbContext context, 공동주택단지정보APIService aPIService, IMapper mapper)
    {
        _context = context;
        _APIService = aPIService;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(공동주택상세정보Request request, CancellationToken cancellationToken)
    {
        // 공동주택DbContext를 통해 Address가 Null인 공동주택을 Load합니다.
        var 공동주택목록 = await _context.Set<공동주택>()
            .Where(x => string.IsNullOrEmpty(x.법정동주소))
            .ToListAsync(cancellationToken);

        // 공동주택목록을 순회하며 각 공동주택에 대한 상세정보를 요청합니다.
        foreach (var 공동주택 in 공동주택목록)
        {
            try
            {
                var response = await _APIService.Get공동주택상세정보(new 공동주택상세정보Request { kaptCode = 공동주택.단지코드 });

                // 요청된 Response를 Model에 Mapping합니다.
                _mapper.Map(response.Body.Item, 공동주택);

                // Mapping된 Model을 Update합니다.
                _context.Set<공동주택>().Update(공동주택);
            }
            catch (Exception ex)
            {
                // 로그 또는 오류 처리
                Console.WriteLine($"Error processing {공동주택.단지코드}: {ex.Message}");
            }
        }

        // 변경 사항을 데이터베이스에 저장합니다.
        await _context.SaveChangesAsync(cancellationToken);

        return Unit.Value; // 작업 완료 신호
    }
}
