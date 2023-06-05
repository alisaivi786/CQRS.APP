namespace CQRS.API.Services.Interface;

public interface IUserService
{
    Task<User> CreateUser(User user);
    Task<User> UpdateUser(User user);
    Task<bool> DeleteUser(User user);
    Task<User> GetUserById(int userId);
    Task<List<User>> GetAllUsers();
}


