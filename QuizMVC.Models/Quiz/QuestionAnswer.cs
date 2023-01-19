using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizMVC.Models.Quiz;

public class QuestionAnswer
{
    [Key]
    public int Id { get; set; }
    [ForeignKey("Question")]
    public int QuestionId { get; set; }
    [Required]
    public string RightAnswer { get; set; }
}