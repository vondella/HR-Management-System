using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HR_Management_System.Migrations
{
    public partial class SalaryAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Holidays",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holidays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeaveCategories",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: false),
                    Days = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notices",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Published = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RecruitementNotices",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastDate = table.Column<DateTime>(nullable: false),
                    IsPublished = table.Column<bool>(nullable: false),
                    NumberOfVacancy = table.Column<int>(nullable: false),
                    Department = table.Column<string>(nullable: false),
                    Designation = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecruitementNotices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Resumes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
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
                name: "Salaries",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BasicSalary = table.Column<double>(nullable: false),
                    NetSalary = table.Column<double>(nullable: false),
                    HouseRent = table.Column<double>(nullable: false),
                    MobileBill = table.Column<double>(nullable: false),
                    MedicalBill = table.Column<double>(nullable: false),
                    Other = table.Column<double>(nullable: false),
                    ProvidentFundDeduction = table.Column<double>(nullable: false),
                    TaxDeduction = table.Column<double>(nullable: false),
                    OtherDeduction = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salaries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeekDays",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    IsWorkingDay = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeekDays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Designations",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    DepartmentModelId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Designations_Departments_DepartmentModelId",
                        column: x => x.DepartmentModelId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProfileImage = table.Column<byte[]>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Department = table.Column<string>(nullable: true),
                    Designation = table.Column<string>(nullable: true),
                    UserType = table.Column<int>(nullable: false),
                    RememberMe = table.Column<bool>(nullable: false),
                    ResumeId = table.Column<long>(nullable: true),
                    DateOfApplication = table.Column<DateTime>(nullable: true),
                    InterviewDate = table.Column<DateTime>(nullable: true),
                    SelectedForInterview = table.Column<bool>(nullable: false),
                    JoiningDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    SalaryId = table.Column<long>(nullable: true),
                    RecruitementNoticeModelId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_RecruitementNotices_RecruitementNoticeModelId",
                        column: x => x.RecruitementNoticeModelId,
                        principalTable: "RecruitementNotices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Users_Resumes_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Salaries_SalaryId",
                        column: x => x.SalaryId,
                        principalTable: "Salaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DegreeDetails_ResumeId",
                table: "DegreeDetails",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Designations_DepartmentModelId",
                table: "Designations",
                column: "DepartmentModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionalExperience_ResumeId",
                table: "ProfessionalExperience",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RecruitementNoticeModelId",
                table: "Users",
                column: "RecruitementNoticeModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ResumeId",
                table: "Users",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_SalaryId",
                table: "Users",
                column: "SalaryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DegreeDetails");

            migrationBuilder.DropTable(
                name: "Designations");

            migrationBuilder.DropTable(
                name: "Holidays");

            migrationBuilder.DropTable(
                name: "LeaveCategories");

            migrationBuilder.DropTable(
                name: "Notices");

            migrationBuilder.DropTable(
                name: "ProfessionalExperience");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "WeekDays");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "RecruitementNotices");

            migrationBuilder.DropTable(
                name: "Resumes");

            migrationBuilder.DropTable(
                name: "Salaries");
        }
    }
}
