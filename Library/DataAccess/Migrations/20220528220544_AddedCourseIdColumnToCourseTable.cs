using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KUSYSDemo.DataAccess.Migrations
{
    public partial class AddedCourseIdColumnToCourseTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Courses");
        }
    }
}
