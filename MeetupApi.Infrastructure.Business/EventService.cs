
using AutoMapper;
using MeetupApi.Contracts.Dto;
using MeetupApi.Domain.Interfaces.Repositories;
using MeetupApi.Services.Interfaces;

namespace MeetupApi.Infrastructure.Business
{
    public class EventService : IEventService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;

        public EventService(IRepositoryManager repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<EventDto> GetEventAsync(Guid id) =>
            _mapper.Map<EventDto>(await _repository.Event.GetEventAsync(id));

        public async Task<IEnumerable<EventDto>> GetEventsAsync() =>
            _mapper.Map<IEnumerable<EventDto>>(await _repository.Event.GetEventsAsync());

        public Task<EventDto> CreateEvent(EventCreateDto @event)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEvent(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<EventDto> UpdateEventAsync(Guid id, EventUpdateDto @event)
        {
            throw new NotImplementedException();
        }
    }
}
