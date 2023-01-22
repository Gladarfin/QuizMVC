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
        modelBuilder.Entity<Question>().HasData(
            new Question
            {
                Id = 15,
                CategoryId = 2,
                QuestionText = "Which of the following statements is incorrect about encapsulation?",
                IsActive = true,
                QuestionTypeId = 2,
                Updated = DateTime.Now
            },
            new Question
            {
                Id = 16,
                CategoryId = 10,
                QuestionText = "Place the historical events in chronological order.",
                IsActive = true,
                QuestionTypeId = 5,
                Updated = DateTime.Now
            },
            new Question
            {
                Id = 17,
                CategoryId = 3,
                QuestionText = "Just like human beings, computers communicate through receiving and sending messages. We refer to those message receiving components as _____ devices and those which send messages as _____ devices.",
                IsActive = true,
                QuestionTypeId = 6,
                Updated = DateTime.Now
            },
            new Question
            {
                Id = 18,
                CategoryId = 8,
                QuestionText = "A scientist is conducting a study to determine how well a new medication treats ear infections. The scientist tells the participants to put 10 drops in their infected ear each day. After two weeks, all participants' ear infections had healed. Which of the following changes to the design of this study would most improve the ability to test if the new medication effectively treats ear infections?",
                IsActive = true,
                QuestionTypeId = 7,
                Updated = DateTime.Now
            });

        modelBuilder.Entity<QuestionChoice>().HasData(
            new QuestionChoice
            {
                Id = 56,
                QuestionId = 15,
                Choice = "Encapsulation is the way to add functions in a user defined structure."
            },
            new QuestionChoice
            {
                Id = 57,
                QuestionId = 15,
                Choice = "Encapsulation is defined as the process of enclosing one or more items within a physical or logical package."
            },
            new QuestionChoice
            {
                Id = 58,
                QuestionId = 15,
                Choice = "Abstraction allows making relevant information visible and encapsulation enables a programmer to implement the desired level of abstraction."
            },
            new QuestionChoice
            {
                Id = 59,
                QuestionId = 15,
                Choice = "Encapsulation, in object oriented programming methodology, prevents access to implementation details."
            },
            new QuestionChoice
            {
                Id = 60,
                QuestionId = 15,
                Choice = "All of above"
            },
            new QuestionChoice
            {
                Id = 61,
                QuestionId = 16,
                Choice = "Last great Roman–Persian War."
            },
            new QuestionChoice
            {
                Id = 62,
                QuestionId = 16,
                Choice = "War of the Grand Alliance with France; also called \"Nine Years \" or \"War of the League of Augsburg\" or \"King William's War\""
            },
            new QuestionChoice
            {
                Id = 63,
                QuestionId = 16,
                Choice = "Sui dynasty in China."
            },
            new QuestionChoice
            {
                Id = 64,
                QuestionId = 16,
                Choice = "Christianization of Kievan Rus'"
            },
            new QuestionChoice
            {
                Id = 65,
                QuestionId = 16,
                Choice = "The Bible is translated into English by John Wycliffe."
            },
            new QuestionChoice
            {
                Id = 66,
                QuestionId = 16,
                Choice = "Alexander III dies. His son Nicholas II succeeds him as emperor."
            },
            new QuestionChoice
            {
                Id = 67,
                QuestionId = 16,
                Choice = "Vasco da Gama begins his first voyage from Europe to India and back."
            },
            new QuestionChoice
            {
                Id = 68,
                QuestionId = 16,
                Choice = "War of Pacification in Nanzhong."
            },
            new QuestionChoice
            {
                Id = 69,
                QuestionId = 16,
                Choice = "Theodore Roosevelt becomes the 26th President of the United States."
            },
            new QuestionChoice
            {
                Id = 70,
                QuestionId = 16,
                Choice = "Otto von Bismarck was born."
            },
            new QuestionChoice
            {
                Id = 71,
                QuestionId = 17,
                Choice = ""
            },
            new QuestionChoice
            {
                Id = 72,
                QuestionId = 18,
                Choice = "Have participants put ear drops in both their infected ear and healthy ear"
            },
            new QuestionChoice
            {
                Id = 73,
                QuestionId = 18,
                Choice = "Create a second group of participants with ear infections who do not use any ear drops"
            },
            new QuestionChoice
            {
                Id = 74,
                QuestionId = 18,
                Choice = "Have participants use ear drops for only one week"
            },
            new QuestionChoice
            {
                Id = 75,
                QuestionId = 18,
                Choice = "Create a second group of participants with ear infections who use 15 drops a day"
            });
        modelBuilder.Entity<QuestionAnswer>().HasData(
            new QuestionAnswer
            {
                Id = 15,
                QuestionId = 15,
                RightAnswer = "56"
            },
            new QuestionAnswer
            {
                Id = 16,
                QuestionId = 16,
                RightAnswer = "68636164656762706669"
            },
            new QuestionAnswer
            {
                Id = 17,
                QuestionId = 17,
                RightAnswer = "inputoutput"
            },
            new QuestionAnswer
            {
                Id = 18,
                QuestionId = 18,
                RightAnswer = "74"
            });
    }
}