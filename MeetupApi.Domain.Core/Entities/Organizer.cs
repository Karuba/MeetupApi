using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeetupApi.Domain.Core.Entities
{
    [Table("Organizer")]
    public class Organizer
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        public ICollection<Event> Events { get; set; }
    }
}