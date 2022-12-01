
using Microsoft.AspNetCore.Identity;

namespace MeetupApi.Domain.Core.Entities
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
    }
}
