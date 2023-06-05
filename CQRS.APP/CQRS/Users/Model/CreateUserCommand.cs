namespace CQRS.API.CQRS.Users.Model;

// Command model for creating a user
public class CreateUserCommand : IRequest<User>
{
    public string? Username { get; set; }
    public string? Password { get; set; }
    // Other user properties
}
