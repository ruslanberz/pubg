using Microsoft.EntityFrameworkCore.Migrations;

namespace PUBG.Migrations
{
    public partial class databaseupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Seasons",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Seasons");
        }
    }
}
