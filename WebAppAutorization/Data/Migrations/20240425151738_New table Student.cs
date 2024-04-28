using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    public partial class NewtableStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "data");

            migrationBuilder.CreateTable(
                name: "Student",
                schema: "data",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SerName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TgNick = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Number = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "data",
                table: "Student",
                columns: new[] { "Id", "DataTravell", "Privat", "Name", "SerName", "Price" },
                values: new object[] { 1, new DateTime(2004, 4, 25, 18, 17, 37, 886, DateTimeKind.Local).AddTicks(5660), false, "first", 999.99m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student",
                schema: "data");
        }
    }
}
