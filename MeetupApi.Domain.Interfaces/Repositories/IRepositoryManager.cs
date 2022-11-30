
namespace MeetupApi.Domain.Interfaces.Repositories
{
    public interface IRepositoryManager
    {
        IEventRepository Event { get; }
        Task SaveAsync();
    }
}
