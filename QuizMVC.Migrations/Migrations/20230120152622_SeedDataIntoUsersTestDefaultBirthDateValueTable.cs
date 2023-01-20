using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuizMVC.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataIntoUsersTestDefaultBirthDateValueTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "IsDeleted", "Name", "Password", "Rating", "RegistrationDate", "Surname", "Username" },
                values: new object[] { 3, new DateOnly(1990, 1, 1), "user@gmail.com", false, null, "wDEilregHMQqhWuH7CJVdQ==", 0f, new DateTime(2023, 1, 20, 20, 26, 22, 499, DateTimeKind.Utc).AddTicks(4134), null, "TestUser" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
