namespace CQRS.API.CQRS.Users.Model;

// Command model for updating a user
public class UpdateUserCommand : IRequest<User>
{
    public int UserId { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    // Other user properties to update
}
