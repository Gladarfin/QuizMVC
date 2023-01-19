namespace QuizMVC.Models.Main;
using System.ComponentModel.DataAnnotations;

public class User
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Username { get; set; }
    [Required]
    public string Password { get; set; }
    [Required]
    public string Email { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public bool IsDeleted { get; set; }
    public float Rating { get; set; }
    public DateTime RegistrationDate { get; set; }
}