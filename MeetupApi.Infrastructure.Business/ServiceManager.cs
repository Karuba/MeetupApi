using AutoMapper;
using MeetupApi.Domain.Interfaces.Repositories;
using MeetupApi.Services.Interfaces;

namespace MeetupApi.Infrastructure.Business
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IEventService> _eventService;

        public ServiceManager(IRepositoryManager repository, IMapper mapper)
        {
            _eventService = new Lazy<IEventService>(() => new EventService(repository, mapper));
        }
        public IEventService eventService => _eventService.Value;
    }
}