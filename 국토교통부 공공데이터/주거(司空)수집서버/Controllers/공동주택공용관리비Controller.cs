using Microsoft.AspNetCore.Mvc;
using 국토교통부_공공데이터Common.공용관리비_정보제공서비스;
using 국토교통부_공공데이터Common.공용관리비정보제공서비스;

namespace 주거_司空_수집서버.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class 공동주택공용관리비Controller : ControllerBase
    {
        private readonly 공동주택공용관리비APIService _service;

        public 공동주택공용관리비Controller(공동주택공용관리비APIService service)
        {
            _service = service;
        }

        [HttpGet("난방비")]
        public async Task<IActionResult> Get난방비([FromQuery] 공용관리비Request request)
        {
            try
            {
                var response = await _service.Get난방비(request);
                return Ok(response);
            }
            catch (HttpRequestException ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("경비비")]
        public async Task<IActionResult> Get경비비([FromQuery] 공용관리비Request request)
        {
            try
            {
                var response = await _service.Get경비비(request);
                return Ok(response);
            }
            catch (HttpRequestException ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("기타부대비용")]
        public async Task<IActionResult> Get기타부대비용([FromQuery] 공용관리비Request request)
        {
            try
            {
                var response = await _service.Get기타부대비용(request);
                return Ok(response);
            }
            catch (HttpRequestException ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("소독비")]
        public async Task<IActionResult> Get소독비([FromQuery] 공용관리비Request request)
        {
            try
            {
                var response = await _service.Get소독비(request);
                return Ok(response);
            }
            catch (HttpRequestException ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("수선비")]
        public async Task<IActionResult> Get수선비([FromQuery] 공용관리비Request request)
        {
            try
            {
                var response = await _service.Get수선비(request);
                return Ok(response);
            }
            catch (HttpRequestException ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("승강기유지비")]
        public async Task<IActionResult> Get승강기유지비([FromQuery] 공용관리비Request request)
        {
            try
            {
                var response = await _service.Get승강기유지비(request);
                return Ok(response);
            }
            catch (HttpRequestException ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("시설유지비")]
        public async Task<IActionResult> Get시설유지비([FromQuery] 공용관리비Request request)
        {
            try
            {
                var response = await _service.Get시설유지비(request);
                return Ok(response);
            }
            catch (HttpRequestException ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("안전점검비")]
        public async Task<IActionResult> Get안전점검비([FromQuery] 공용관리비Request request)
        {
            try
            {
                var response = await _service.Get안전점검비(request);
                return Ok(response);
            }
            catch (HttpRequestException ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet("위탁관리수수료")]
        public async Task<IActionResult> Get위탁관리수수료([FromQuery] 공용관리비Request request)
        {
            try
            {
                var response = await _service.Get위탁관리수수료(request);
                return Ok(response);
            }
            catch (HttpRequestException ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet("인건비")]
        public async Task<IActionResult> Get인건비([FromQuery] 공용관리비Request request)
        {
            try
            {
                var response = await _service.Get인건비(request);
                return Ok(response);
            }
            catch (HttpRequestException ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet("재해예방비")]
        public async Task<IActionResult> Get재해예방비([FromQuery] 공용관리비Request request)
        {
            try
            {
                var response = await _service.Get재해예방비(request);
                return Ok(response);
            }
            catch (HttpRequestException ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet("제사무비")]
        public async Task<IActionResult> Get제사무비([FromQuery] 공용관리비Request request)
        {
            try
            {
                var response = await _service.Get제사무비(request);
                return Ok(response);
            }
            catch (HttpRequestException ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet("제세공과금")]
        public async Task<IActionResult> Get제세공과금([FromQuery] 공용관리비Request request)
        {
            try
            {
                var response = await _service.Get제세공과금(request);
                return Ok(response);
            }
            catch (HttpRequestException ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet("지능형홈네트워크설비유지비")]
        public async Task<IActionResult> Get지능형홈네트워크설비유지비([FromQuery] 공용관리비Request request)
        {
            try
            {
                var response = await _service.Get지능형홈네트워크설비유지비(request);
                return Ok(response);
            }
            catch (HttpRequestException ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet("차량유지비")]
        public async Task<IActionResult> Get차량유지비([FromQuery] 공용관리비Request request)
        {
            try
            {
                var response = await _service.Get차량유지비(request);
                return Ok(response);
            }
            catch (HttpRequestException ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet("청소비")]
        public async Task<IActionResult> Get청소비([FromQuery] 공용관리비Request request)
        {
            try
            {
                var response = await _service.Get청소비(request);
                return Ok(response);
            }
            catch (HttpRequestException ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet("피복비")]
        public async Task<IActionResult> Get피복비([FromQuery] 공용관리비Request request)
        {
            try
            {
                var response = await _service.Get피복비(request);
                return Ok(response);
            }
            catch (HttpRequestException ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
