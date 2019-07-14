using Microsoft.EntityFrameworkCore.Migrations;

namespace HR_Management_System.Migrations
{
    public partial class DesignationAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DesignationModel_Departments_DepartmentModelId",
                table: "DesignationModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DesignationModel",
                table: "DesignationModel");

            migrationBuilder.RenameTable(
                name: "DesignationModel",
                newName: "Designations");

            migrationBuilder.RenameIndex(
                name: "IX_DesignationModel_DepartmentModelId",
                table: "Designations",
                newName: "IX_Designations_DepartmentModelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Designations",
                table: "Designations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Designations_Departments_DepartmentModelId",
                table: "Designations",
                column: "DepartmentModelId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Designations_Departments_DepartmentModelId",
                table: "Designations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Designations",
                table: "Designations");

            migrationBuilder.RenameTable(
                name: "Designations",
                newName: "DesignationModel");

            migrationBuilder.RenameIndex(
                name: "IX_Designations_DepartmentModelId",
                table: "DesignationModel",
                newName: "IX_DesignationModel_DepartmentModelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DesignationModel",
                table: "DesignationModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DesignationModel_Departments_DepartmentModelId",
                table: "DesignationModel",
                column: "DepartmentModelId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
