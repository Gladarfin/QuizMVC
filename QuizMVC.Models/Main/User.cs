namespace QuizMVC.Models.Main;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string PasswordHash { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public bool IsDeleted { get; set; }
    public float Rating { get; set; }
    public DateTime RegisteredDate { get; set; }
}