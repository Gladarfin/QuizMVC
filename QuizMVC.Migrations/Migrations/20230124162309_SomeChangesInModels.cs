using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizMVC.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class SomeChangesInModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

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

            migrationBuilder.CreateIndex(
                name: "IX_Questions_CategoryId",
                table: "Questions",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuestionTypeId",
                table: "Questions",
                column: "QuestionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionChoices_QuestionId",
                table: "QuestionChoices",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAnswers_QuestionId",
                table: "QuestionAnswers",
                column: "QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionAnswers_Questions_QuestionId",
                table: "QuestionAnswers",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionChoices_Questions_QuestionId",
                table: "QuestionChoices",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Categories_CategoryId",
                table: "Questions",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_QuestionTypes_QuestionTypeId",
                table: "Questions",
                column: "QuestionTypeId",
                principalTable: "QuestionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionAnswers_Questions_QuestionId",
                table: "QuestionAnswers");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionChoices_Questions_QuestionId",
                table: "QuestionChoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Categories_CategoryId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_QuestionTypes_QuestionTypeId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_CategoryId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_QuestionTypeId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_QuestionChoices_QuestionId",
                table: "QuestionChoices");

            migrationBuilder.DropIndex(
                name: "IX_QuestionAnswers_QuestionId",
                table: "QuestionAnswers");

            migrationBuilder.RenameColumn(
                name: "QuestionTypeId",
                table: "Questions",
                newName: "QuestionType");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 15,
                column: "Updated",
                value: new DateTime(2023, 1, 22, 19, 37, 39, 352, DateTimeKind.Utc).AddTicks(1019));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 16,
                column: "Updated",
                value: new DateTime(2023, 1, 22, 19, 37, 39, 352, DateTimeKind.Utc).AddTicks(1033));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 17,
                column: "Updated",
                value: new DateTime(2023, 1, 22, 19, 37, 39, 352, DateTimeKind.Utc).AddTicks(1035));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 18,
                column: "Updated",
                value: new DateTime(2023, 1, 22, 19, 37, 39, 352, DateTimeKind.Utc).AddTicks(1036));
        }
    }
}
