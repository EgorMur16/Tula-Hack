using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    public partial class PivateandDataTravell : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Deleted",
                schema: "data",
                table: "Student",
                newName: "Privat");

            migrationBuilder.RenameColumn(
                name: "BirthDate",
                schema: "data",
                table: "Student",
                newName: "DataTravell");

            migrationBuilder.AddColumn<string>(
                name: "SerName",
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
                columns: new[] { "DataTravell", "Name", "Price", "SerName" },
                values: new object[] { new DateTime(2004, 4, 27, 0, 4, 9, 890, DateTimeKind.Local).AddTicks(5966), "Сергей", 999m, "Фигурин" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SerName",
                schema: "data",
                table: "Student");

            migrationBuilder.RenameColumn(
                name: "Privat",
                schema: "data",
                table: "Student",
                newName: "Deleted");

            migrationBuilder.RenameColumn(
                name: "DataTravell",
                schema: "data",
                table: "Student",
                newName: "BirthDate");

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Student",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "Name", "Price" },
                values: new object[] { new DateTime(2004, 4, 25, 18, 18, 26, 205, DateTimeKind.Local).AddTicks(1979), "first", 999.99m });
        }
    }
}
