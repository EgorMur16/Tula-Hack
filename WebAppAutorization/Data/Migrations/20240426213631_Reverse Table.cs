using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    public partial class ReverseTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "data",
                table: "Student",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataTravell",
                value: new DateTime(2004, 4, 27, 0, 36, 30, 962, DateTimeKind.Local).AddTicks(102));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "data",
                table: "Student",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataTravell",
                value: new DateTime(2004, 4, 27, 0, 4, 9, 890, DateTimeKind.Local).AddTicks(5966));
        }
    }
}
