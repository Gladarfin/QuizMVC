using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuizMVC.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class AddDataIntoQuestionsAnswersChoicesTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CategoryId", "IsActive", "QuestionText", "QuestionTypeId", "Updated" },
                values: new object[,]
                {
                    { 15, 2, true, "Which of the following statements is incorrect about encapsulation?", 2, new DateTime(2023, 1, 22, 19, 37, 39, 352, DateTimeKind.Utc).AddTicks(1019) },
                    { 16, 10, true, "Place the historical events in chronological order.", 5, new DateTime(2023, 1, 22, 19, 37, 39, 352, DateTimeKind.Utc).AddTicks(1033) },
                    { 17, 3, true, "Just like human beings, computers communicate through receiving and sending messages. We refer to those message receiving components as _____ devices and those which send messages as _____ devices.", 6, new DateTime(2023, 1, 22, 19, 37, 39, 352, DateTimeKind.Utc).AddTicks(1035) },
                    { 18, 8, true, "A scientist is conducting a study to determine how well a new medication treats ear infections. The scientist tells the participants to put 10 drops in their infected ear each day. After two weeks, all participants' ear infections had healed. Which of the following changes to the design of this study would most improve the ability to test if the new medication effectively treats ear infections?", 7, new DateTime(2023, 1, 22, 19, 37, 39, 352, DateTimeKind.Utc).AddTicks(1036) }
                });

            migrationBuilder.InsertData(
                table: "QuestionChoices",
                columns: new[] { "Id", "Choice", "QuestionId" },
                values: new object[,]
                {
                    { 56, "Encapsulation is the way to add functions in a user defined structure.", 15 },
                    { 57, "Encapsulation is defined as the process of enclosing one or more items within a physical or logical package.", 15 },
                    { 58, "Abstraction allows making relevant information visible and encapsulation enables a programmer to implement the desired level of abstraction.", 15 },
                    { 59, "Encapsulation, in object oriented programming methodology, prevents access to implementation details.", 15 },
                    { 60, "All of above", 15 },
                    { 61, "Last great Roman–Persian War.", 16 },
                    { 62, "War of the Grand Alliance with France; also called \"Nine Years \" or \"War of the League of Augsburg\" or \"King William's War\"", 16 },
                    { 63, "Sui dynasty in China.", 16 },
                    { 64, "Christianization of Kievan Rus'", 16 },
                    { 65, "The Bible is translated into English by John Wycliffe.", 16 },
                    { 66, "Alexander III dies. His son Nicholas II succeeds him as emperor.", 16 },
                    { 67, "Vasco da Gama begins his first voyage from Europe to India and back.", 16 },
                    { 68, "War of Pacification in Nanzhong.", 16 },
                    { 69, "Theodore Roosevelt becomes the 26th President of the United States.", 16 },
                    { 70, "Otto von Bismarck was born.", 16 },
                    { 71, "", 17 },
                    { 72, "Have participants put ear drops in both their infected ear and healthy ear", 18 },
                    { 73, "Create a second group of participants with ear infections who do not use any ear drops", 18 },
                    { 74, "Have participants use ear drops for only one week", 18 },
                    { 75, "Create a second group of participants with ear infections who use 15 drops a day", 18 }
                });
            
            migrationBuilder.InsertData(
                table: "QuestionAnswers",
                columns: new[] { "Id", "QuestionId", "RightAnswer" },
                values: new object[,]
                {
                    { 15, 15, "56" },
                    { 16, 16, "68636164656762706669" },
                    { 17, 17, "inputoutput" },
                    { 18, 18, "74" }
                });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 18);
            
        }
    }
}
