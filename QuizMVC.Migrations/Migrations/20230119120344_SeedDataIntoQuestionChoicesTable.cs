using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuizMVC.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataIntoQuestionChoicesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "QuestionChoices",
                columns: new[] { "Id", "Choice", "QuestionId" },
                values: new object[,]
                {
                    { 1, "Hanover, Germany", 2 },
                    { 2, "Munich, Germany", 2 },
                    { 3, "Salzburg, Austria", 2 },
                    { 4, "Copenhagen, Denmark", 2 },
                    { 5, "1966", 1 },
                    { 6, "1961", 1 },
                    { 7, "1971", 1 },
                    { 8, "1976", 1 },
                    { 9, "night", 3 },
                    { 10, "site", 3 },
                    { 11, "light", 3 },
                    { 12, "daylight", 3 },
                    { 13, "Paul McCartney", 4 },
                    { 14, "Brian Wilson", 4 },
                    { 15, "Robert Plant", 4 },
                    { 16, "Freddie Mercury", 4 },
                    { 17, "", 5 },
                    { 18, "Simone Simons", 6 },
                    { 19, "Floor Jansen", 6 },
                    { 20, "Tarja Turunen", 6 },
                    { 21, "Amy Lee", 6 },
                    { 22, "Eagle", 7 },
                    { 23, "Scorpion", 7 },
                    { 24, "Dragon", 7 },
                    { 25, "Snake", 7 },
                    { 26, "Dog", 7 },
                    { 27, "Cat", 7 },
                    { 28, "Frog", 7 },
                    { 29, "", 8 },
                    { 30, "Slash", 9 },
                    { 31, "Muddy", 9 },
                    { 32, "Diamond", 9 },
                    { 33, "La leyenda de La Mancha", 10 },
                    { 34, "A king of magic", 10 },
                    { 35, "Abbey Road", 10 },
                    { 36, "The Dark Side of the Moon", 10 },
                    { 37, "Shiva", 11 },
                    { 38, "Minerva", 11 },
                    { 39, "Athena", 11 },
                    { 40, "Kali", 11 },
                    { 41, "", 12 },
                    { 42, "The Skeleton Key", 13 },
                    { 43, "Delicate Sound of Thunder", 13 },
                    { 44, "Real Rock Drive", 13 },
                    { 45, "We'll burn the sky", 13 },
                    { 46, "Rock Around the Clock", 13 },
                    { 47, "I Don’t Want to Miss a Thing", 13 },
                    { 48, "The Battle of Evermore", 13 },
                    { 49, "Dream On", 14 },
                    { 50, "I Don't Want to Miss a Thing", 14 },
                    { 51, "Hole in my Soul", 14 },
                    { 52, "Wish I had an angel", 14 },
                    { 53, "The Phantom Agony", 14 },
                    { 54, "Livin' On The Edge", 14 },
                    { 55, "Toys in the Attic", 14 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 55);
        }
    }
}
