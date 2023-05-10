using Microsoft.EntityFrameworkCore;
using TcketApi.Data;
using TcketApi.Models;

namespace TcketApi.BusinessLogic
{
    public class UserService
    {
        private readonly Ticket _context;

        public UserService(Ticket context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<User> AddUserAsync(User userToAdd)
        {
            _context.Users.Add(userToAdd);
            await _context.SaveChangesAsync();
            return userToAdd;
        }

        public async Task<User> UpdateUserAsync(User updatedUser)
        {
            _context.Entry(updatedUser).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return updatedUser;
        }

        
    }
}
