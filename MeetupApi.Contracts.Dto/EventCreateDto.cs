
using System.ComponentModel.DataAnnotations;

namespace MeetupApi.Contracts.Dto
{
    public class EventCreateDto
    {
        [Required(ErrorMessage = "Name is required field")]
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(200, ErrorMessage = "Description mustn't exceed 200 characters")]
        public string? Description { get; set; }
        [MaxLength(30, ErrorMessage = "Location mustn't exceed 30 characters")]
        [Required(ErrorMessage = "Location is required field")]
        public string Location { get; set; }
        [Required(ErrorMessage = "OrganizerId is required field")]
        public Guid OrganizerId { get; set; }
        public ICollection<PlanCreateDto>? Plans { get; set; }
    }
}
