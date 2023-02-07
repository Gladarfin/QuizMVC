using System.Collections;

namespace QuizMVC.Models.Quiz;

public class QuestionType
{
    public int Id { get; set; }
    public string Type { get; set; }
    
    public bool IsDeleted { get; set; }
}