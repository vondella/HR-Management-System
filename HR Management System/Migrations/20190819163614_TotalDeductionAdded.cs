using Microsoft.EntityFrameworkCore.Migrations;

namespace HR_Management_System.Migrations
{
    public partial class TotalDeductionAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "TotalDeduction",
                table: "Salaries",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalDeduction",
                table: "Salaries");
        }
    }
}
