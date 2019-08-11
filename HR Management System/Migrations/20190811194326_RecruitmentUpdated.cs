using Microsoft.EntityFrameworkCore.Migrations;

namespace HR_Management_System.Migrations
{
    public partial class RecruitmentUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecruitementNotices_Departments_DepartmentId",
                table: "RecruitementNotices");

            migrationBuilder.DropForeignKey(
                name: "FK_RecruitementNotices_Designations_DesignationId",
                table: "RecruitementNotices");

            migrationBuilder.DropIndex(
                name: "IX_RecruitementNotices_DepartmentId",
                table: "RecruitementNotices");

            migrationBuilder.DropIndex(
                name: "IX_RecruitementNotices_DesignationId",
                table: "RecruitementNotices");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "RecruitementNotices");

            migrationBuilder.DropColumn(
                name: "DesignationId",
                table: "RecruitementNotices");

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "RecruitementNotices",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Designation",
                table: "RecruitementNotices",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Department",
                table: "RecruitementNotices");

            migrationBuilder.DropColumn(
                name: "Designation",
                table: "RecruitementNotices");

            migrationBuilder.AddColumn<long>(
                name: "DepartmentId",
                table: "RecruitementNotices",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "DesignationId",
                table: "RecruitementNotices",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_RecruitementNotices_DepartmentId",
                table: "RecruitementNotices",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_RecruitementNotices_DesignationId",
                table: "RecruitementNotices",
                column: "DesignationId");

            migrationBuilder.AddForeignKey(
                name: "FK_RecruitementNotices_Departments_DepartmentId",
                table: "RecruitementNotices",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecruitementNotices_Designations_DesignationId",
                table: "RecruitementNotices",
                column: "DesignationId",
                principalTable: "Designations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
