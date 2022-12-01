
using AutoMapper;
using MeetupApi.Domain.Core.Entities;

namespace MeetupApi.Contracts.Dto.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventDto>().ForMember(c => c.Speakers, opt => opt.MapFrom(x => x.EventSpeakers
                .Select(x => x.Speaker)));
            CreateMap<Plan, PlanDto>();
            CreateMap<Organizer, OrganizerDto>();
            CreateMap<Speaker, SpeakerDto>();

            CreateMap<EventCreateDto, Event>().ForMember(c => c.Date, opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<PlanCreateDto, Plan>().ForMember(c => c.Time, opt => opt.MapFrom(x => DateTime.Now));

            CreateMap<EventUpdateDto, Event>().ForMember(c => c.Date, opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<PlanUpdateDto, Plan>().ForMember(c => c.Time, opt => opt.MapFrom(x => DateTime.Now));

            CreateMap<User, UserRegistrationDto>().ReverseMap();
        }
    }
}
