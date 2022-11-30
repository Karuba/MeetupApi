
using System.ComponentModel.DataAnnotations;

namespace MeetupApi.Contracts.Dto
{
    public class PlanCreateDto
    {
        [Required(ErrorMessage = "Description is required field")]
        [MaxLength(100, ErrorMessage = "Description mustn't exceed 100 characters")]
        public string Description { get; set; }
    }
}