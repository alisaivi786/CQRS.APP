namespace CQRS.API.CQRS.Users.CommandHandler;

// Command handler for creating a user
public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, User>
{
    private readonly IUserService _userService;

    public CreateUserCommandHandler(IUserService userService)
    {
        _userService = userService;
    }

    public async Task<User> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        // Create a new user
        User newUser = new()
        {
            Username = request.Username,
            Password = request.Password,
            // Set other user properties
        };

        // Save the new user in the database or other data source
        User createdUser = await _userService.CreateUser(newUser);

        return createdUser;
    }
}
