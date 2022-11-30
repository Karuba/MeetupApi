
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
        }
    }
}
