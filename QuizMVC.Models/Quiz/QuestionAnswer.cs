using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizMVC.Models.Quiz;

public class QuestionAnswer
{
    [Key]
    public int Id { get; set; }
    public Guid QuestionId { get; set; }
    [ForeignKey("QuestionId")]
    public Question Question { get; set; }
    [Required]
    public string RightAnswer { get; set; }
    
    public bool IsDeleted { get; set; }
}