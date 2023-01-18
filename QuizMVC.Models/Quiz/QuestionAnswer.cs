namespace QuizMVC.Models.Quiz;

public class QuestionAnswer
{
    public int Id { get; set; }
    public int QuestionId { get; set; }
    public string RightAnswer { get; set; }
}