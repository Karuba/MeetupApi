
using MeetupApi.Contracts.Dto;

namespace MeetupApi.Services.Interfaces
{
    public interface IEventService
    {
        Task<IEnumerable<EventDto>> GetEventsAsync();
        Task<EventDto> GetEventAsync(Guid id);
        Task DeleteEvent(Guid id);
        Task<EventDto> CreateEvent(EventCreateDto @event);
        Task<EventDto> UpdateEventAsync(Guid id, EventUpdateDto @event);
    }
}
