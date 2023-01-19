using Microsoft.EntityFrameworkCore;
using QuizMVC.Models.Main;
using QuizMVC.Models.Quiz;

namespace QuizMVC.Data;

public class QuizMvcDbContext: DbContext
{
    public QuizMvcDbContext(DbContextOptions<QuizMvcDbContext> options)
    :base(options)
    {
        
    }
    
    public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<QuestionAnswer> QuestionAnswers { get; set; }
    public DbSet<QuestionChoice> QuestionChoices { get; set; }
    public DbSet<Quiz> Quizzes { get; set; }
}