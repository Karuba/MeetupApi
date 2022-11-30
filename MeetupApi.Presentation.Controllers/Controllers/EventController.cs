
using MeetupApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace MeetupApi.Presentation.Controllers.Controllers
{
    [ApiController]
    [Route("api/meetup")]
    public class EventController : ControllerBase
    {
        private readonly IServiceManager _service;

        public EventController(IServiceManager service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetEventsAsync()
        {
            var eventsDto = await _service.eventService.GetEventsAsync();
            return Ok(eventsDto);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEventAsync(Guid id)
        {
            var eventDto = await _service.eventService.GetEventAsync(id);
            return Ok(eventDto);
        }
    }
}
