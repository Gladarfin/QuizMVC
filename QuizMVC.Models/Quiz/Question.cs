namespace QuizMVC.Models.Quiz;

public class Question
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public Module ModuleId { get; set; }
    public string QuestionText { get; set; }
    public bool IsActive { get; set; }
    public DateTime Updated { get; set; }
}