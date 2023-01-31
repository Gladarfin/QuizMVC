using System.ComponentModel.DataAnnotations;

namespace QuizMVC.Models.Quiz;

public class Category
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public string? Description { get; set; }
    
    public bool isDeleted { get; set; }
}