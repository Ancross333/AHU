using Microsoft.EntityFrameworkCore;
using Ahu.Db;
using Ahu.Domain.User;

namespace Ahu.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AhuDbContext _context;
        public UserRepository(AhuDbContext context) => _context = context;

        public async Task CompleteAsync() => await _context.SaveChangesAsync();
        
        public async Task AddAsync(User user)
        {
            await _context.Users.AddAsync(user);
        }

        public Task GetAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
