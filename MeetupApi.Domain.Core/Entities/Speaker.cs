using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeetupApi.Domain.Core.Entities
{
    [Table("Speaker")]
    public class Speaker
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }

        public ICollection<EventSpeaker> EventSpeakers { get; set; }
    }
}