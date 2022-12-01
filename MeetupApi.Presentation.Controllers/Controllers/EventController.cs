
using MeetupApi.Contracts.Dto;
using MeetupApi.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<IActionResult> GetEvents()
        {
            var eventsDto = await _service.eventService.GetEventsAsync();
            return Ok(eventsDto);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEvent(Guid id)
        {
            var eventDto = await _service.eventService.GetEventAsync(id);
            return Ok(eventDto);
        }
        [HttpPost, Authorize(Roles = "Organizer")]
        public async Task<IActionResult> CreateEvent([FromBody] EventCreateDto eventCreateDto)
        {
            var eventDto = await _service.eventService.CreateEvent(eventCreateDto);
            return Ok(eventDto);
        }
        [HttpDelete("{id}"), Authorize(Roles = "Organizer")]
        public async Task<IActionResult> DeleteEvent(Guid id)
        {
            await _service.eventService.DeleteEvent(id);
            return NoContent();
        }
        [HttpPut("{id}"), Authorize(Roles = "Organizer")]
        public async Task<IActionResult> UpdateEvent(Guid id, [FromBody] EventUpdateDto eventUpdateDto)
        {
            var eventDto = await _service.eventService.UpdateEventAsync(id, eventUpdateDto);
            return Ok(eventDto);
        }
    }
}
