using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizMVC.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class IsDeletedColumnsAddedToTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Quizzes",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "QuestionTypes",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Questions",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "QuestionChoices",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "QuestionAnswers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Categories",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 15,
                column: "isDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 16,
                column: "isDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 17,
                column: "isDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 18,
                column: "isDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 56,
                column: "isDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 57,
                column: "isDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 58,
                column: "isDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 59,
                column: "isDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 60,
                column: "isDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 61,
                column: "isDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 62,
                column: "isDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 63,
                column: "isDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 64,
                column: "isDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 65,
                column: "isDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 66,
                column: "isDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 67,
                column: "isDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 68,
                column: "isDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 69,
                column: "isDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 70,
                column: "isDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 71,
                column: "isDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 72,
                column: "isDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 73,
                column: "isDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 74,
                column: "isDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: 75,
                column: "isDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Updated", "isDeleted" },
                values: new object[] { new DateTime(2023, 1, 31, 14, 56, 30, 765, DateTimeKind.Utc).AddTicks(2952), false });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Updated", "isDeleted" },
                values: new object[] { new DateTime(2023, 1, 31, 14, 56, 30, 765, DateTimeKind.Utc).AddTicks(2966), false });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Updated", "isDeleted" },
                values: new object[] { new DateTime(2023, 1, 31, 14, 56, 30, 765, DateTimeKind.Utc).AddTicks(2968), false });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Updated", "isDeleted" },
                values: new object[] { new DateTime(2023, 1, 31, 14, 56, 30, 765, DateTimeKind.Utc).AddTicks(2970), false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "QuestionTypes");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "QuestionChoices");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "QuestionAnswers");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 15,
                column: "Updated",
                value: new DateTime(2023, 1, 24, 21, 23, 9, 658, DateTimeKind.Utc).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 16,
                column: "Updated",
                value: new DateTime(2023, 1, 24, 21, 23, 9, 658, DateTimeKind.Utc).AddTicks(707));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 17,
                column: "Updated",
                value: new DateTime(2023, 1, 24, 21, 23, 9, 658, DateTimeKind.Utc).AddTicks(709));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 18,
                column: "Updated",
                value: new DateTime(2023, 1, 24, 21, 23, 9, 658, DateTimeKind.Utc).AddTicks(710));
        }
    }
}
