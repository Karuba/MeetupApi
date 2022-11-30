
using MeetupApi.Domain.Core.Entities;

namespace MeetupApi.Domain.Interfaces.Repositories
{
    public interface IEventRepository
    {
        Task<IEnumerable<Event>> GetEventsAsync(bool trackChanges = false);
        Task<Event> GetEventAsync(Guid id ,bool trackChanges = false);
        void AddEvent(Event @event);
        void UpdateEvent(Event @event);
        void DeleteEvent(Event @event);
    }
}
