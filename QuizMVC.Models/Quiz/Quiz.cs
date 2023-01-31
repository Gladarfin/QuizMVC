using System.ComponentModel.DataAnnotations.Schema;
using QuizMVC.Models.Main;

namespace QuizMVC.Models.Quiz;
using System.ComponentModel.DataAnnotations;
public class Quiz
{
    [Key]
    public int Id { get; set; }
    [ForeignKey("User")]
    public int UserId { get; set; }
    public DateTime Started { get; set; }
    public DateTime Completed { get; set; }
    public List<string> UserAnswers { get; set; }
    public float FinalScore { get; set; }
    public bool isDeleted { get; set; }
}