using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuizMVC.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataIntoQuestionsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CategoryId", "IsActive", "QuestionText", "Updated" },
                values: new object[,]
                {
                    { 1, 6, true, "In which year did Psychedelic rock emerge?", new DateTime(2023, 1, 19, 15, 38, 27, 157, DateTimeKind.Utc).AddTicks(5235) },
                    { 2, 6, true, "Where is the lead singer of the Scorpions from?", new DateTime(2023, 1, 19, 15, 39, 21, 157, DateTimeKind.Utc).AddTicks(5251) },
                    { 3, 6, true, "Wise man said just walk this way, To the dawn of the ______", new DateTime(2023, 1, 19, 15, 40, 56, 157, DateTimeKind.Utc).AddTicks(5252) },
                    { 4, 6, true, "What was the name of Queen's vocalist?", new DateTime(2023, 1, 19, 15, 41, 27, 157, DateTimeKind.Utc).AddTicks(5254) },
                    { 5, 6, true, "How many studio albums have Scorpions released?", new DateTime(2023, 1, 19, 15, 42, 27, 157, DateTimeKind.Utc).AddTicks(5255) },
                    { 6, 6, true, "Who is the lead singer of Epica?", new DateTime(2023, 1, 19, 15, 43, 27, 157, DateTimeKind.Utc).AddTicks(5257) },
                    { 7, 6, true, "In 1991, Metallica released their album 'Metallica'. What animal is on the cover artwork? ", new DateTime(2023, 1, 19, 15, 44, 46, 157, DateTimeKind.Utc).AddTicks(5258) },
                    { 8, 6, true, "Iron Maiden singer Bruce Dickinson is also a qualified pilot. True or false?", new DateTime(2023, 1, 19, 15, 45, 37, 157, DateTimeKind.Utc).AddTicks(5259) },
                    { 9, 6, true, "Guitarist Saul Hudson Is Better Known By Which Name?", new DateTime(2023, 1, 19, 15, 46, 07, 157, DateTimeKind.Utc).AddTicks(5261) },
                    { 10, 6, false, "Which classic rock album is sometimes said to be a soundtrack to The Wizard of Oz?", new DateTime(2023, 1, 19, 15, 47, 11, 157, DateTimeKind.Utc).AddTicks(5262) },
                    { 11, 6, true, "Which goddess inspired the Rolling Stones' logo?", new DateTime(2023, 1, 19, 15, 48, 17, 157, DateTimeKind.Utc).AddTicks(5263) },
                    { 12, 6, true, "Which Pink Floyd recording became the first rock album to be played in space?", new DateTime(2023, 1, 19, 15, 49, 27, 157, DateTimeKind.Utc).AddTicks(5264) },
                    { 13, 6, false, "What was the first rock-n-roll song to hit #1 on the charts?", new DateTime(2023, 1, 19, 15, 50, 27, 157, DateTimeKind.Utc).AddTicks(5266) },
                    { 14, 6, true, "Which Aerosmith song was nominated for both Best Original Song and Worst Original Song?", new DateTime(2023, 1, 19, 15, 51, 41, 157, DateTimeKind.Utc).AddTicks(5267) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 14);
        }
    }
}
