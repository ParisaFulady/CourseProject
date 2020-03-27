using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseProject.InfraStructures.EF.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblCourse",
                columns: table => new
                {
                    CourseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCourse", x => x.CourseID);
                });

            migrationBuilder.CreateTable(
                name: "tblInstructor",
                columns: table => new
                {
                    InstructorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 100, nullable: true),
                    LastName = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblInstructor", x => x.InstructorID);
                });

            migrationBuilder.CreateTable(
                name: "tblStudents",
                columns: table => new
                {
                    StudentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 100, nullable: true),
                    LastName = table.Column<string>(maxLength: 100, nullable: false),
                    SabteNameDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblStudents", x => x.StudentID);
                });

            migrationBuilder.CreateTable(
                name: "tblCourseInstructor",
                columns: table => new
                {
                    CourseInstructorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InstructorID = table.Column<int>(nullable: false),
                    CourseID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCourseInstructor", x => x.CourseInstructorID);
                    table.ForeignKey(
                        name: "FK_tblCourseInstructor_tblCourse_CourseID",
                        column: x => x.CourseID,
                        principalTable: "tblCourse",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblCourseInstructor_tblInstructor_InstructorID",
                        column: x => x.InstructorID,
                        principalTable: "tblInstructor",
                        principalColumn: "InstructorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblStudentCourse",
                columns: table => new
                {
                    StudentCourseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Grade = table.Column<decimal>(nullable: false),
                    StudentID = table.Column<int>(nullable: false),
                    CourseID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblStudentCourse", x => x.StudentCourseID);
                    table.ForeignKey(
                        name: "FK_tblStudentCourse_tblCourse_CourseID",
                        column: x => x.CourseID,
                        principalTable: "tblCourse",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblStudentCourse_tblStudents_StudentID",
                        column: x => x.StudentID,
                        principalTable: "tblStudents",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblCourseInstructor_CourseID",
                table: "tblCourseInstructor",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_tblCourseInstructor_InstructorID",
                table: "tblCourseInstructor",
                column: "InstructorID");

            migrationBuilder.CreateIndex(
                name: "IX_tblStudentCourse_CourseID",
                table: "tblStudentCourse",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_tblStudentCourse_StudentID",
                table: "tblStudentCourse",
                column: "StudentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblCourseInstructor");

            migrationBuilder.DropTable(
                name: "tblStudentCourse");

            migrationBuilder.DropTable(
                name: "tblInstructor");

            migrationBuilder.DropTable(
                name: "tblCourse");

            migrationBuilder.DropTable(
                name: "tblStudents");
        }
    }
}
