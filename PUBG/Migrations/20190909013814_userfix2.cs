using Microsoft.EntityFrameworkCore.Migrations;

namespace PUBG.Migrations
{
    public partial class userfix2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Bonus",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Money",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bonus",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Money",
                table: "AspNetUsers");
        }
    }
}
