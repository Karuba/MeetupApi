
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeetupApi.Domain.Core.Entities
{
    [Table("Event")]
    public class Event
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string? Description { get; set; }
        public DateTime Date { get; set; }
        [MaxLength(30)]
        public string Location { get; set; }

        [Required]
        [ForeignKey(nameof(Organizer))]
        public Guid OrganizerId { get; set; }
        public Organizer Organizer { get; set; }
        public ICollection<Plan>? Plans { get; set; }
        public ICollection<EventSpeaker>? EventSpeakers { get; set; }
    }
}
