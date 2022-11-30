
using MeetupApi.Domain.Core.Entities;
using MeetupApi.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace MeetupApi.Infrastructure.Data.Repositories.Repositories
{
    public class EventRepository : RepositoryBase<Event>, IEventRepository
    {
        public EventRepository(RepositoryContext context)
            :base(context)
        {

        }
        public void AddEvent(Event @event) => Create(@event);
        public void DeleteEvent(Event @event) => Delete(@event);

        public async Task<Event> GetEventAsync(Guid id, bool trackChanges = false) =>
            await FindByCondition(opt => opt.Id.Equals(id), trackChanges)
                    .Include(e => e.Plans)
                    .Include(e => e.Organizer)
                    .Include(e => e.EventSpeakers)
                    .ThenInclude(es => es.Speaker)
                    .FirstOrDefaultAsync();

        public async Task<IEnumerable<Event>> GetEventsAsync(bool trackChanges = false) =>
            await FindAll(trackChanges)
                    .OrderBy(e => e.Name)
                    .Include(e => e.Plans)
                    .Include(e => e.Organizer)
                    .Include(e => e.EventSpeakers)
                    .ThenInclude(es => es.Speaker)
                    .ToListAsync();

        public void UpdateEvent(Event @event) => Update(@event);
    }
}
