using CQRS.API.CQRS.Users.Model;

namespace CQRS.API.CQRS.Users.Querys;

// Query model for retrieving all users
public class GetAllUsersQuery : IRequest<List<User>>
{
    // No additional parameters needed
}
