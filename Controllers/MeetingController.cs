using MeetingScheduler.Services;
using Microsoft.AspNetCore.Mvc;

namespace MeetingScheduler.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetingController : ControllerBase
    {
        private readonly IMeetingService _meetingService;

        public MeetingController(IMeetingService meetingService)
        {
            _meetingService = meetingService;
        }

        [HttpGet]
        public async Task<ActionResult<List<DateTime>>> FindAvailableTimeAsync([FromQuery] List<Guid> calendarIds, [FromQuery] int duration, [FromQuery] string periodToSearch, [FromQuery] Guid? timeSlotType = null)
        {
            try
            {
                // Split the periodToSearch string into start and end DateTime objects
                var periodParts = periodToSearch.Split('/');
                var start = DateTime.Parse(periodParts[0]);
                var end = DateTime.Parse(periodParts[1]);

                var availableTimes = await _meetingService.FindAvailableTimeAsync(calendarIds, duration, start, end, timeSlotType);
                return Ok(availableTimes);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
