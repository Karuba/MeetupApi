
using AutoMapper;
using MeetupApi.Domain.Core.Entities;

namespace MeetupApi.Contracts.Dto.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventDto>().ForMember(c => c.Speakers, opt => opt.MapFrom(x => x.EventSpeakers.Select(x => x.Speaker).Select(x => new SpeakerDto
            {
                Id = x.Id,
                Name = x.Name,
            })));
        }
    }
}
