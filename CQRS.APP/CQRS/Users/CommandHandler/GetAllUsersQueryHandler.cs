using CQRS.API.CQRS.Users.Model;
using CQRS.API.CQRS.Users.Querys;

namespace CQRS.API.CQRS.Users.CommandHandler;

// Query handler for retrieving all users
public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, List<User>>
{
    private readonly IUserService _userService;

    public GetAllUsersQueryHandler(IUserService userService)
    {
        _userService = userService;
    }

    public async Task<List<User>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
    {
        // Retrieve all users from the database or other data source
        List<User> users = await _userService.GetAllUsers();

        return users;
    }
}
