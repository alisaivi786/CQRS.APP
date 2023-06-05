using CQRS.API.CQRS.Users.Model;

namespace CQRS.API.CQRS.Users.CommandHandler;

// Command handler for deleting a user
public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, bool>
{
    private readonly IUserService _userService;

    public DeleteUserCommandHandler(IUserService userService)
    {
        _userService = userService;
    }

    public async Task<bool> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {
        // Retrieve the user from the database or other data source
        User userToDelete = await _userService.GetUserById(request.UserId);

        if (userToDelete != null)
        {
            // Delete the user from the database or other data source
            bool isDeleted = await _userService.DeleteUser(userToDelete);

            return isDeleted;
        }

        return false;
    }
}
