using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizMVC.Migrations.Migrations
{

    public partial class ChangeIdsType : Migration
    {

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                "PK_Quizzes", 
                "Quizzes");

            migrationBuilder.RenameColumn(
                "Id", 
                "Quizzes",
                "OldId");

            migrationBuilder.RenameColumn(
                "UserId", 
                "Quizzes", 
                "OldUserId");
            
            migrationBuilder.DropForeignKey(
                "FK_QuestionChoices_Questions_QuestionId", 
                "QuestionChoices");
            
            migrationBuilder.DropForeignKey(
                "FK_QuestionId", 
                "QuestionChoices");
            
            migrationBuilder.RenameColumn(
                "QuestionId", 
                "QuestionChoices", 
                "OldQuestionId");
            
            migrationBuilder.DropForeignKey(
                "FK_QuestionAnswers_Questions_QuestionId", 
                "QuestionAnswers");
            
            migrationBuilder.DropForeignKey(
                "FK_QuestionId", 
                "QuestionAnswers");
            
            migrationBuilder.RenameColumn(
                "QuestionId", 
                "QuestionAnswers", 
                "OldQuestionId");
            
            migrationBuilder.DropPrimaryKey(
                "PK_Questions", 
                "Questions");

            migrationBuilder.RenameColumn(
                "Id", 
                "Questions",
                "OldId");
            
            ///
            migrationBuilder.AddColumn<Guid>(
                "Id",
                "Quizzes",
                "uuid",
                nullable: false,
                defaultValue:new Guid("00000000-0000-0000-0000-000000000000"),
                defaultValueSql: "uuid_generate_v1()");
            
            migrationBuilder.AddColumn<Guid>(
                "UserId",
                "Quizzes",
                "uuid",
                nullable: true,
                defaultValue:new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey("PK_Quizzes", "Quizzes","Id");

            migrationBuilder.AddForeignKey(
                "FK_Quizzes_Users_UserId", 
                "Quizzes", 
                "UserId", 
                "Users", 
                principalColumn: "Id");
            
            migrationBuilder.AddColumn<Guid>(
                "Id",
                "Questions",
                "uuid",
                nullable: false,
                defaultValue:new Guid("00000000-0000-0000-0000-000000000000"),
                defaultValueSql: "uuid_generate_v1()");

            migrationBuilder.AddPrimaryKey(
                "PK_Questions", 
                "Questions",
                "Id");

            migrationBuilder.AddColumn<Guid>(
                "QuestionId",
                "QuestionChoices",
                "uuid",
                nullable: true,
                defaultValue:new Guid("00000000-0000-0000-0000-000000000000"));
            
            migrationBuilder.AddColumn<Guid>(
                "QuestionId",
                "QuestionAnswers",
                "uuid",
                nullable: true,
                defaultValue:new Guid("00000000-0000-0000-0000-000000000000"));
        }
        
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
