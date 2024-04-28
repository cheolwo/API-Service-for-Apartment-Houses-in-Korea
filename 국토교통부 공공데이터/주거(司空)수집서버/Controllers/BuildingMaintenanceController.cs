using Microsoft.AspNetCore.Mvc;
using 국토교통부_공공데이터Common;

namespace 주거_司空_수집서버.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BuildingMaintenanceController : ControllerBase
    {
        private readonly IBuildingMaintenanceService _buildingMaintenanceService;

        public BuildingMaintenanceController(IBuildingMaintenanceService buildingMaintenanceService)
        {
            _buildingMaintenanceService = buildingMaintenanceService;
        }

        // GET: api/BuildingMaintenance/GetMaintenanceHistory
        [HttpGet("GetMaintenanceHistory")]
        public async Task<IActionResult> GetMaintenanceHistory(string kaptCode)
        {
            if (string.IsNullOrEmpty(kaptCode))
            {
                return BadRequest("KaptCode is required");
            }

            try
            {
                var result = await _buildingMaintenanceService.GetBuildingMaintenanceHistoryAsync(kaptCode);
                if (string.IsNullOrEmpty(result))
                {
                    return NotFound("No maintenance history found for the provided KaptCode.");
                }

                return Ok(result);
            }
            catch (System.Exception ex)
            {
                // Log the exception details here as needed
                return StatusCode(500, "An error occurred while retrieving maintenance history.");
            }
        }
    }
}
