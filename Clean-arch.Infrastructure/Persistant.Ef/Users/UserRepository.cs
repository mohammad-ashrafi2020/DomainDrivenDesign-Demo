using Clean_arch.Domain.UserAgg;
using Clean_arch.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace Clean_arch.Infrastructure.Persistant.Ef.Users
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(User user)
        {
            _context.Add(user);
        }

        public async Task<User> GetbyEmail(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(f => f.Email == email);
        }

        public async Task<User> GetById(long id)
        {
            return await _context.Users.FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task SaveChange()
        {
            await _context.SaveChangesAsync();
        }

        public void Update(User user)
        {
            _context.Update(user);
        }

        public bool UserIsExist(string email)
        {
            return _context.Users.Any(u => u.Email == email);
        }
    }
}