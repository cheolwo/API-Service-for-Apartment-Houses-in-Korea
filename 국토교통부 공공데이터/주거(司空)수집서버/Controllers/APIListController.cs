using Microsoft.AspNetCore.Mvc;
using 국토교통부_공공데이터Common.국토교통부_공동주택단지목록제공서비스;

namespace 주거_司空_수집서버.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AptListController : ControllerBase
    {
        private readonly IAptListService _aptListService;

        public AptListController(IAptListService aptListService)
        {
            _aptListService = aptListService;
        }

        // 지역별 아파트 목록 조회
        [HttpGet("SidoApt")]
        public async Task<IActionResult> GetSidoApt(int sidoCode, int pageNo = 1, 
            int numOfRows = 10)
        {
            var results = await _aptListService.GetSidoAptListAsync(sidoCode, pageNo, numOfRows);
            return Ok(results);
        }

        // 전체 아파트 목록 조회
        [HttpGet("TotalApt")]
        public async Task<IActionResult> GetTotalApt(int pageNo = 1, int numOfRows = 10)
        {
            var results = await _aptListService.GetTotalAptListAsync(pageNo, numOfRows);
            return Ok(results);
        }
    }
}
