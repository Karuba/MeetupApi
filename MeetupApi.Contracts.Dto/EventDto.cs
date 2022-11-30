
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MeetupApi.Domain.Core.Entities;

namespace MeetupApi.Contracts.Dto
{
    public class EventDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }

        public Organizer Organizer { get; set; }
        public ICollection<Plan>? Plans { get; set; }
        public ICollection<Speaker>? Speakers { get; set; }
    }
}
