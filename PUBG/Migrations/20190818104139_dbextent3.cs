using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PUBG.Migrations
{
    public partial class dbextent3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SkippedUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SeasonId = table.Column<int>(nullable: false),
                    ApplicationUserId = table.Column<int>(nullable: false),
                    ApplicationUserId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkippedUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkippedUsers_AspNetUsers_ApplicationUserId1",
                        column: x => x.ApplicationUserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SkippedUsers_Season_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Season",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SkippedUsers_ApplicationUserId1",
                table: "SkippedUsers",
                column: "ApplicationUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_SkippedUsers_SeasonId",
                table: "SkippedUsers",
                column: "SeasonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SkippedUsers");
        }
    }
}
