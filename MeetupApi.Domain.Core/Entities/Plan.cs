using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeetupApi.Domain.Core.Entities
{
    [Table("Plan")]
    public class Plan
    {
        [Key]
        public Guid Id { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        public DateTime Time { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }

        [Required]
        [ForeignKey(nameof(Event))]
        public Guid EventId { get; set; }
        public Event Event { get; set; }
    }
}