using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Elearn.Migrations
{
    public partial class CreatedCourseSliderTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Sliders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Sliders",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Sliders");
        }
    }
}
