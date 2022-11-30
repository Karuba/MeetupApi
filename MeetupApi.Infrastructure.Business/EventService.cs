
using AutoMapper;
using MeetupApi.Contracts.Dto;
using MeetupApi.Domain.Core.Entities;
using MeetupApi.Domain.Core.Exceptions;
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

        public async Task<EventDto> CreateEvent(EventCreateDto @event)
        {
            if (@event is null)
                throw new BadRequestException("Event is null");

            var eventEntity = _mapper.Map<Event>(@event);


            _repository.Event.AddEvent(eventEntity);
            await _repository.SaveAsync();

            return _mapper.Map<EventDto>(eventEntity);

        }

        public async Task DeleteEvent(Guid id)
        {
            var eventEntity = await _repository.Event.GetEventAsync(id);
            if (eventEntity is null)
                throw new NotFoundException($"Event with ID: {id} does not exist in the database yet");
            _repository.Event.DeleteEvent(eventEntity);
            await _repository.SaveAsync();
        }

        public async Task<EventDto> UpdateEventAsync(Guid id, EventUpdateDto @event)
        {
            if (@event is null)
                throw new BadRequestException("Event is null");

            var eventEntity = await _repository.Event.GetEventAsync(id, trackChanges: true);
            if (eventEntity is null)
                throw new NotFoundException($"Event with ID: {id} does not exist in the database");

            _mapper.Map(@event, eventEntity);
            await _repository.SaveAsync();
            return _mapper.Map<EventDto>(eventEntity);
        }
    }
}
