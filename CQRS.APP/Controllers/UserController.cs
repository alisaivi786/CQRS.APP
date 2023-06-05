namespace CQRS.API.Controllers;

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    private readonly IMediator _mediator;

    public UserController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser(CreateUserCommand command)
    {
        User createdUser = await _mediator.Send(command);

        // Return the created user in the response
        return Ok(createdUser);
    }

    [HttpPut("{userId}")]
    public async Task<IActionResult> UpdateUser(int userId, UpdateUserCommand command)
    {
        command.UserId = userId;
        User updatedUser = await _mediator.Send(command);

        if (updatedUser != null)
        {
            // Return the updated user in the response
            return Ok(updatedUser);
        }

        // Return an appropriate error response if the user is not found
        return NotFound();
    }

    [HttpDelete("{userId}")]
    public async Task<IActionResult> DeleteUser(int userId)
    {
        DeleteUserCommand command = new DeleteUserCommand { UserId = userId };
        bool isDeleted = await _mediator.Send(command);

        if (isDeleted)
        {
            // Return a success response
            return Ok();
        }

        // Return an appropriate error response if the user is not found or not deleted
        return NotFound();
    }

    [HttpGet("{userId}")]
    public async Task<IActionResult> GetUserById(int userId)
    {
        GetUserByIdQuery query = new GetUserByIdQuery { UserId = userId };
        User user = await _mediator.Send(query);

        if (user != null)
        {
            // Return the user in the response
            return Ok(user);
        }

        // Return an appropriate error response if the user is not found
        return NotFound();
    }

    [HttpGet]
    public async Task<IActionResult> GetAllUsers()
    {
        GetAllUsersQuery query = new GetAllUsersQuery();
        List<User> users = await _mediator.Send(query);

        // Return the list of users in the response
        return Ok(users);
    }
}
