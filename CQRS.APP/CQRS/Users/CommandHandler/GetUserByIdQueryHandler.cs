using CQRS.API.CQRS.Users.Model;
using CQRS.API.CQRS.Users.Querys;

namespace CQRS.API.CQRS.Users.CommandHandler;

// Query handler for retrieving a user by ID
public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, User>
{
    private readonly IUserService _userService;

    public GetUserByIdQueryHandler(IUserService userService)
    {
        _userService = userService;
    }

    public async Task<User> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
    {
        // Retrieve the user from the database or other data source
        User user = await _userService.GetUserById(request.UserId);

        return user;
    }
}
