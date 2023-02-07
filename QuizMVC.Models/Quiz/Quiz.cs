using System.ComponentModel.DataAnnotations.Schema;
using QuizMVC.Models.Main;

namespace QuizMVC.Models.Quiz;
using System.ComponentModel.DataAnnotations;
public class Quiz
{
    [Key]
    public Guid Id { get; set; }
    [ForeignKey("User")]
    public Guid UserId { get; set; }
    [Column(TypeName ="timestamp without time zone")]
    public DateTime Started { get; set; }
    [Column(TypeName ="timestamp without time zone")]
    public DateTime Completed { get; set; }
    public List<string> UserAnswers { get; set; }
    public float FinalScore { get; set; }
    public bool IsDeleted { get; set; }
}