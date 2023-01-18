namespace QuizMVC.Models.Quiz;

public class UserAnswer
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public DateTime QuizStarted { get; set; }
    public DateTime QuizCompleted { get; set; }
    public List<string> UserAnswers { get; set; }
    public float FinalScore { get; set; } //here?
}