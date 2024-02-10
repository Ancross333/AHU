namespace Ahu.Domain.User
{
    public interface IUserRepository
    {
        Task CompleteAsync();
        Task AddAsync(User user);
        Task GetAsync(int id);
    }
}
