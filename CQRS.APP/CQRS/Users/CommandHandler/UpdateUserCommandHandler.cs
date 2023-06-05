using CQRS.API.CQRS.Users.Model;

namespace CQRS.API.CQRS.Users.CommandHandler;

// Command handler for updating a user
public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, User>
{
    private readonly IUserService _userService;

    public UpdateUserCommandHandler(IUserService userService)
    {
        _userService = userService;
    }

    public async Task<User> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        // Retrieve the user from the database or other data source
        User userToUpdate = await _userService.GetUserById(request.UserId);

        if (userToUpdate != null)
        {
            // Update the user properties
            userToUpdate.Username = request.Username;
            userToUpdate.Password = request.Password;
            // Update other user properties

            // Save the updated user in the database or other data source
            User updatedUser = await _userService.UpdateUser(userToUpdate);

            return updatedUser;
        }

        return null;
    }
}
