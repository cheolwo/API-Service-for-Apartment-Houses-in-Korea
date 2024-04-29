using Microsoft.AspNetCore.Mvc;
using 국토교통부_공공데이터Common.공동주택_단지_목록제공_서비스;
using 국토교통부_공공데이터Common.국토교통부_공동주택단지목록제공서비스;

[ApiController]
[Route("[controller]")]
public class 공동주택단지Controller : ControllerBase
{
    private readonly 공동주택단지APIService _service;

    public 공동주택단지Controller(공동주택단지APIService service)
    {
        _service = service;
    }

    // 시도별 아파트 목록 조회
    [HttpGet("SidoAptList")]
    public async Task<IActionResult> GetSidoAptList([FromQuery] 공동주택단지Request request)
    {
        if (request.sidoCode == 0)
        {
            return BadRequest("Invalid sidoCode.");
        }

        try
        {
            var response = await _service.GetSidoAptListAsync(request);
            return Ok(response);
        }
        catch (System.Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }

    // 전체 아파트 목록 조회
    [HttpGet("TotalAptList")]
    public async Task<IActionResult> GetTotalAptList([FromQuery] 공동주택단지Request request)
    {
        try
        {
            var response = await _service.GetTotalAptListAsync(request);
            return Ok(response);
        }
        catch (System.Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
}
