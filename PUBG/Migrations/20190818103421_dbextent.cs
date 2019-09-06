using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PUBG.Migrations
{
    public partial class dbextent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsBanned",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SeasonId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Posted",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ImagePath = table.Column<string>(nullable: true),
                    ApplicationUserId = table.Column<int>(nullable: false),
                    SeasonId = table.Column<int>(nullable: false),
                    Point = table.Column<int>(nullable: true),
                    ApplicationUserId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posted", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posted_AspNetUsers_ApplicationUserId1",
                        column: x => x.ApplicationUserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Season",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StartTime = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Season", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Season_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SeasonId",
                table: "AspNetUsers",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Posted_ApplicationUserId1",
                table: "Posted",
                column: "ApplicationUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Season_ApplicationUserId",
                table: "Season",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Season_SeasonId",
                table: "AspNetUsers",
                column: "SeasonId",
                principalTable: "Season",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Season_SeasonId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Posted");

            migrationBuilder.DropTable(
                name: "Season");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_SeasonId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsBanned",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SeasonId",
                table: "AspNetUsers");
        }
    }
}
