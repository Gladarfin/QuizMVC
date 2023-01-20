using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuizMVC.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataIntoUsersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "IsDeleted", "Name", "Password", "Rating", "RegistrationDate", "Surname", "Username" },
                values: new object[,]
                {
                    { 1, new DateOnly(1, 1, 1), "brusto@gmail.com", false, null, "Cu/NhoayNvnl7n3+KLt/tA==", 0f, new DateTime(2023, 1, 20, 18, 45, 34, 940, DateTimeKind.Utc).AddTicks(1160), null, "FirstAdmin" },
                    { 2, new DateOnly(1, 1, 1), "moderatoro@gmail.com", false, null, "muq7X5z13Y7euCvOqOZW9b8oUizhORWHUkc59ttiTA4=", 0f, new DateTime(2023, 1, 20, 18, 46, 34, 940, DateTimeKind.Utc).AddTicks(1179), null, "FirstModerator" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
