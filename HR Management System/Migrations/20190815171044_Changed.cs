using Microsoft.EntityFrameworkCore.Migrations;

namespace HR_Management_System.Migrations
{
    public partial class Changed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Resumes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Resumes");
        }
    }
}
