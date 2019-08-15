using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HR_Management_System.Migrations
{
    public partial class ResumeAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ResumeId",
                table: "Users",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Resumes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProfileImage = table.Column<byte[]>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    FatherName = table.Column<string>(nullable: true),
                    MotherName = table.Column<string>(nullable: true),
                    PresentAddress = table.Column<string>(nullable: true),
                    PermanentAddress = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    MarritualStatus = table.Column<string>(nullable: true),
                    NationalID = table.Column<string>(nullable: true),
                    Religion = table.Column<string>(nullable: true),
                    Nationality = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resumes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DegreeDetails",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Qualification = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    Institute = table.Column<string>(nullable: true),
                    PassingYear = table.Column<string>(nullable: true),
                    Grade = table.Column<string>(nullable: true),
                    ResumeId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DegreeDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DegreeDetails_Resumes_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfessionalExperience",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyName = table.Column<string>(nullable: true),
                    CompanyAddress = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true),
                    DurationFrom = table.Column<DateTime>(nullable: true),
                    DurationTo = table.Column<DateTime>(nullable: true),
                    ResumeId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionalExperience", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfessionalExperience_Resumes_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_ResumeId",
                table: "Users",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_DegreeDetails_ResumeId",
                table: "DegreeDetails",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionalExperience_ResumeId",
                table: "ProfessionalExperience",
                column: "ResumeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Resumes_ResumeId",
                table: "Users",
                column: "ResumeId",
                principalTable: "Resumes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Resumes_ResumeId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "DegreeDetails");

            migrationBuilder.DropTable(
                name: "ProfessionalExperience");

            migrationBuilder.DropTable(
                name: "Resumes");

            migrationBuilder.DropIndex(
                name: "IX_Users_ResumeId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ResumeId",
                table: "Users");
        }
    }
}
