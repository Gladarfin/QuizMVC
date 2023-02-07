using Microsoft.EntityFrameworkCore;
using QuizMVC.Models.Main;
using QuizMVC.Models.Quiz;

namespace QuizMVC.Data;

/// <summary>
/// Class for seeding data into DB
/// </summary>
public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        // modelBuilder.Entity<Question>().HasData(
        //     new Question
        //     {
        //         Id = Guid.NewGuid(),
        //         CategoryId = 2,
        //         QuestionText = "Which of the following statements is incorrect about encapsulation?",
        //         IsActive = true,
        //         QuestionTypeId = 2,
        //         Updated = DateTime.Now
        //     });
    }
}