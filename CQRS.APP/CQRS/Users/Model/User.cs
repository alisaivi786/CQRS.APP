namespace CQRS.API.CQRS.Users.Model;

// User model
public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    // Add other properties as needed
}
