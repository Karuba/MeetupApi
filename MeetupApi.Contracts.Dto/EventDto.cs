
namespace MeetupApi.Contracts.Dto
{
    public class EventDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }

        public OrganizerDto Organizer { get; set; }
        public ICollection<PlanDto>? Plans { get; set; }
        public ICollection<SpeakerDto>? Speakers { get; set; }
    }
}
