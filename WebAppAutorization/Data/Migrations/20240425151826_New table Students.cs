using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    public partial class NewtableStudents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "data",
                table: "Student",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2004, 4, 25, 18, 18, 26, 205, DateTimeKind.Local).AddTicks(1979));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "data",
                table: "Student",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2004, 4, 25, 18, 17, 37, 886, DateTimeKind.Local).AddTicks(5660));
        }
    }
}
