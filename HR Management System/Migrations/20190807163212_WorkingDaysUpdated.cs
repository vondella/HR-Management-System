using Microsoft.EntityFrameworkCore.Migrations;

namespace HR_Management_System.Migrations
{
    public partial class WorkingDaysUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsHoliday",
                table: "WeekDays",
                newName: "IsWorkingDay");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsWorkingDay",
                table: "WeekDays",
                newName: "IsHoliday");
        }
    }
}
