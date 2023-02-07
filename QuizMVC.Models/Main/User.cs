using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QuizMVC.Models.Main;


public class User
{
    [Key]
    public Guid Id { get; set; }
    [Required]
    public string Username { get; set; }
    [Required, Encrypted]
    public string Password { get; set; }
    [Required,EmailAddress]
    public string Email { get; set; }
    
    public string? Name { get; set; }
    public string? Surname { get; set; }
    [Column(TypeName ="timestamp without time zone")]
    public DateOnly DateOfBirth { get; set; } = new DateOnly(1900, 1, 1);
    public bool IsDeleted { get; set; }
    public float Rating { get; set; }
    [Column(TypeName ="timestamp without time zone")]
    public DateTime RegistrationDate { get; set; } = DateTime.Now;
}