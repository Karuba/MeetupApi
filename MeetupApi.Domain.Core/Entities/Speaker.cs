using System.ComponentModel.DataAnnotations;

namespace MeetupApi.Domain.Core.Entities
{
    public class Speaker
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }

        public ICollection<EventSpeaker> EventSpeakers { get; set; }
    }
}