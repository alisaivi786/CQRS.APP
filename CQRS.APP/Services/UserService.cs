using CQRS.API.CQRS.Users.Model;

namespace CQRS.API.Services;

public class UserService : IUserService
{
    public Task<User> CreateUser(User user)
    {
        // Implement the logic to create a user
        throw new NotImplementedException();
    }

    public Task<User> UpdateUser(User user)
    {
        // Implement the logic to update a user
        throw new NotImplementedException();
    }

    public Task<bool> DeleteUser(User user)
    {
        // Implement the logic to delete a user
        throw new NotImplementedException();
    }

    public Task<User> GetUserById(int userId)
    {
        // Implement the logic to retrieve a user by ID
        throw new NotImplementedException();
    }

    public async Task<List<User>> GetAllUsers()
    {
        // Implement the logic to retrieve all users
        //throw new NotImplementedException();
        var data = new List<User>
        {
            new User() { Username = "admin", Password = "admin" },
            new User() { Username = "admin2", Password = "admin2" }
        };
        if(data != null)
        {
            return data;
        }

        return null;
    }
}
