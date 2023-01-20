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
        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 3,
                Username = "TestUser",
                Password = "somepassword123",
                Email = "user@gmail.com",
                RegistrationDate = DateTime.Now
            });
    }
}