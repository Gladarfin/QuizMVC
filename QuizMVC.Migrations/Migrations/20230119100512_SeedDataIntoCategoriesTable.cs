using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuizMVC.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataIntoCategoriesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Test your English.", "English" },
                    { 2, "", "Programming languages" },
                    { 3, "Find out how much you really know about computers.", "Computer science" },
                    { 4, "Put your knowledge to the test.", "General Knowledge" },
                    { 5, "Math quiz helps us to increase our knowledge.", "Math" },
                    { 6, "Music quizzes will challenge music lovers of all genres and time periods.", "Music" },
                    { 7, "Take this literature quiz to test your knowledge on a variety of literature topics.", "World Literature" },
                    { 8, "Test your knowledge of science facts and applications of scientific principles.", "Science" },
                    { 9, "Test your knowledge of Mythology.", "Mythology" },
                    { 10, "Basic world history quiz.", "History" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
