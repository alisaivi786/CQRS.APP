namespace CQRS.API.CQRS.Users.Model;

// Command model for deleting a user
public class DeleteUserCommand : IRequest<bool>
{
    public int UserId { get; set; }
}
