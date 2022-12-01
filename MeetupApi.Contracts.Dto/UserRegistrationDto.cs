
using System.ComponentModel.DataAnnotations;

namespace MeetupApi.Contracts.Dto
{
    public class UserRegistrationDto
    {
        public string Name { get; set; }
        [Required(ErrorMessage = "Username is required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        public string Email { get; set; }
        public ICollection<string> Roles { get; set; }
    }
}
