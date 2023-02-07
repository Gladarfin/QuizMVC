using System;
using System.Reflection.Metadata.Ecma335;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuizMVC.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class ChangeIdsTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.DropForeignKey("FK_QuestionId", "Quizzes");
            
            migrationBuilder.DropPrimaryKey(
                "PK_Users", 
                "Users");

            migrationBuilder.RenameColumn(
                "Id", 
                "Users",
                "OldId");
            
            migrationBuilder.AddColumn<Guid>(
                "Id",
                "Users",
                "uuid",
                nullable: false,
                defaultValue:"PK_UserUUID_default",
                defaultValueSql: "uuid_generate_v1()");

            migrationBuilder.AddPrimaryKey("PK_Users", "Users","Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
