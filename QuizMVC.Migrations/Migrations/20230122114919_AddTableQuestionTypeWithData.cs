using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using QuizMVC.Models.Quiz;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuizMVC.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class AddTableQuestionTypeWithData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuestionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionTypes", x => x.Id);
                });
            
           migrationBuilder.AddColumn<int>(
                name: "QuestionTypeId",
                table: "Questions",
                type: "integer",
                nullable: false,
                defaultValue: 0);

           migrationBuilder.InsertData(
                table: "QuestionTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { 1, "Multiply-Choice" },
                    { 2, "Multiply-Response" },
                    { 3, "True-or-False" },
                    { 4, "Short-Answer" },
                    { 5, "Sequence" },
                    { 6, "Fill-in-the-Blank" },
                    { 7, "Select-from-List" },
                    { 8, "Drag-and-Drop" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestionTypes");

            migrationBuilder.DropColumn(
                name: "QuestionType",
                table: "Questions");

        }
    }
}
