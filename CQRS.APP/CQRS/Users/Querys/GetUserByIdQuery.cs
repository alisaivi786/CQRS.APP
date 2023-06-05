using CQRS.API.CQRS.Users.Model;

namespace CQRS.API.CQRS.Users.Querys;

// Query model for retrieving a user by ID
public class GetUserByIdQuery : IRequest<User>
{
    public int UserId { get; set; }
}
