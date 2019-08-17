using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HR_Management_System.Migrations
{
    public partial class DateOfApplicationAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfApplication",
                table: "Users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfApplication",
                table: "Users");
        }
    }
}
