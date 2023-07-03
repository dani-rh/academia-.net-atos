using ToDo2Day.Models;
using ToDo2Day.DataModels;
using ToDo2Day.DTOs;
using Microsoft.EntityFrameworkCore;

namespace ToDo2Day.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly Context _context;

        public UserRepository(Context context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetUserByIdAsync(Guid userId)
        {
            return await _context.Users.FindAsync(userId);
        }

        public async Task<User> AddUserAsync(UserCreateDTO userCreateDTO)
        {
            var user = new User
            {
                UserId = Guid.NewGuid(),
                FirstName = userCreateDTO.FirstName,
                LastName = userCreateDTO.LastName,
                Email = userCreateDTO.Email,
                Password = userCreateDTO.Password,
                RefreshToken = string.Empty,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return user;
        }

        public async Task UpdateUserAsync(Guid userId, UserUpdateDTO userUpdateDTO)
        {
            var user = await _context.Users.FindAsync(userId);
            if (user != null)
            {
                user.FirstName = userUpdateDTO.FirstName;
                user.LastName = userUpdateDTO.LastName;
                user.Email = userUpdateDTO.Email;
                user.Password = userUpdateDTO.Password;
                user.UpdatedAt = DateTime.UtcNow; // update the 'UpdatedAt' field

                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception($"User with id {userId} not found.");
            }
        }

        public async Task DeleteUserAsync(Guid userId)
        {
            var user = await _context.Users.FindAsync(userId);
            if (user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<User> ValidateUserCredentialsAsync(string email, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == email);

            if (user != null && user.Password == password)  // comparing plain text password, not recommended in production
            {
                return user;
            }

            return null;
        }
    }
}
