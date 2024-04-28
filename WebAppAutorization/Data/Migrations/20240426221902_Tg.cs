using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    public partial class Tg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SerName",
                schema: "data",
                table: "Student",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<decimal>(
                name: "Number",
                schema: "data",
                table: "Student",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "TgNick",
                schema: "data",
                table: "Student",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Student",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataTravell", "Number", "TgNick" },
                values: new object[] { new DateTime(2004, 4, 27, 1, 19, 2, 12, DateTimeKind.Local).AddTicks(694), 89202711047m, "@ggt" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Number",
                schema: "data",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "TgNick",
                schema: "data",
                table: "Student");

            migrationBuilder.AlterColumn<string>(
                name: "SerName",
                schema: "data",
                table: "Student",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Student",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataTravell",
                value: new DateTime(2004, 4, 27, 0, 41, 10, 401, DateTimeKind.Local).AddTicks(2688));
        }
    }
}
