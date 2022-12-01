
using MeetupApi.Contracts.Dto;
using MeetupApi.Domain.Core.Entities;

namespace MeetupApi.Services.Interfaces.Authentification
{
    public interface IAuthenticationManager
    {
        Task<bool> ValidateUser(UserAuthenticationDto userForAuth);
        Task<string> CreateToken();
        Task<User> GetUserAsync(string userName);
    }
}
