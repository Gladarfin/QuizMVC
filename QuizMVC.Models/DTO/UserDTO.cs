namespace QuizMVC.Models.DTO;

public class UserDTO
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public DateOnly DateOfBirth { get; set; } = new DateOnly(1900, 1, 1);
}