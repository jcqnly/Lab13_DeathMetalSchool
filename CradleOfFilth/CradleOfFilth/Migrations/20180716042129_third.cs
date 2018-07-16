using Microsoft.EntityFrameworkCore.Migrations;

namespace CradleOfFilth.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CourseName",
                table: "Courses",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Courses",
                newName: "CourseName");
        }
    }
}
