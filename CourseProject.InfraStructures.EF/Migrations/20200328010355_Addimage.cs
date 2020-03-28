using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseProject.InfraStructures.EF.Migrations
{
    public partial class Addimage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "tblInstructor",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "tblInstructor",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "tblCourse",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "tblCourse",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "tblInstructor");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "tblInstructor");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "tblCourse");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "tblCourse");
        }
    }
}
