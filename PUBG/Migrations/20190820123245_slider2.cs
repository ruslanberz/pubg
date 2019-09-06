using Microsoft.EntityFrameworkCore.Migrations;

namespace PUBG.Migrations
{
    public partial class slider2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Sliders",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Sliders");
        }
    }
}
