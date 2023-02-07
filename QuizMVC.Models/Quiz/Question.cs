using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizMVC.Models.Quiz;

public class Question
{
    [Key]
    public Guid Id { get; set; }
    public int CategoryId { get; set; }
    [ForeignKey("CategoryId")]
    public Category Category { get; set; }
    [Required]
    public string QuestionText { get; set; }
    public bool IsActive { get; set; }
    [Column(TypeName ="timestamp without time zone")]
    public DateTime Updated { get; set; }
    public int QuestionTypeId { get; set; }
    [ForeignKey("QuestionTypeId")]
    public QuestionType QuestionType { get; set; }
    
    public bool IsDeleted { get; set; }
}