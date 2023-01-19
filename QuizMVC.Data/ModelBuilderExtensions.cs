using Microsoft.EntityFrameworkCore;
using QuizMVC.Models.Quiz;

namespace QuizMVC.Data;

/// <summary>
/// Class for seeding data into DB
/// </summary>
public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        // modelBuilder.Entity<QuestionAnswer>().HasData(
        //     new QuestionAnswer
        //     {
        //         Id = 1,
        //         QuestionId = 1,
        //         RightAnswer="1966"
        //     });
    }
}