using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizMVC.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class SomeChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 15,
                column: "Updated",
                value: new DateTime(2023, 2, 1, 17, 18, 23, 560, DateTimeKind.Utc).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 16,
                column: "Updated",
                value: new DateTime(2023, 2, 1, 17, 18, 23, 560, DateTimeKind.Utc).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 17,
                column: "Updated",
                value: new DateTime(2023, 2, 1, 17, 18, 23, 560, DateTimeKind.Utc).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 18,
                column: "Updated",
                value: new DateTime(2023, 2, 1, 17, 18, 23, 560, DateTimeKind.Utc).AddTicks(4913));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 15,
                column: "Updated",
                value: new DateTime(2023, 1, 31, 14, 56, 30, 765, DateTimeKind.Local).AddTicks(2952));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 16,
                column: "Updated",
                value: new DateTime(2023, 1, 31, 14, 56, 30, 765, DateTimeKind.Local).AddTicks(2966));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 17,
                column: "Updated",
                value: new DateTime(2023, 1, 31, 14, 56, 30, 765, DateTimeKind.Local).AddTicks(2968));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 18,
                column: "Updated",
                value: new DateTime(2023, 1, 31, 14, 56, 30, 765, DateTimeKind.Local).AddTicks(2970));
        }
    }
}
