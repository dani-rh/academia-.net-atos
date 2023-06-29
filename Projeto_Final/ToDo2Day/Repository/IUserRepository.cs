using ToDo2Day.Models;
using ToDo2Day.DTOs;

namespace ToDo2Day.Repository
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User> GetUserByIdAsync(Guid userId);
        Task<User> AddUserAsync(UserCreateDTO userCreateDTO);
        Task UpdateUserAsync(Guid userId, UserUpdateDTO userUpdateDTO);
        Task DeleteUserAsync(Guid userId);
        Task<User> GetUserByEmailAsync(string email);
        Task<User> ValidateUserCredentialsAsync(string email, string password);
    }
}
