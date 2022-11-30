
using MeetupApi.Domain.Interfaces.Repositories;
using MeetupApi.Infrastructure.Data.Repositories.Repositories;

namespace MeetupApi.Infrastructure.Data.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private IEventRepository _eventRepository;
        public RepositoryManager(RepositoryContext context)
        {
            _repositoryContext = context;
        }
        public IEventRepository Event
        {
            get
            {
                if (_eventRepository is null)
                    _eventRepository = new EventRepository(_repositoryContext);
                return _eventRepository;
            }
        }

        public Task SaveAsync() => _repositoryContext.SaveChangesAsync();
    }
}
