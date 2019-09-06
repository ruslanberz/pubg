using Microsoft.EntityFrameworkCore.Migrations;

namespace PUBG.Migrations
{
    public partial class dbextent5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Season_SeasonId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Posted_AspNetUsers_ApplicationUserId1",
                table: "Posted");

            migrationBuilder.DropForeignKey(
                name: "FK_Season_AspNetUsers_ApplicationUserId",
                table: "Season");

            migrationBuilder.DropForeignKey(
                name: "FK_SkippedUsers_Season_SeasonId",
                table: "SkippedUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Season",
                table: "Season");

            migrationBuilder.DropIndex(
                name: "IX_Season_ApplicationUserId",
                table: "Season");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Posted",
                table: "Posted");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Season");

            migrationBuilder.RenameTable(
                name: "Season",
                newName: "Seasons");

            migrationBuilder.RenameTable(
                name: "Posted",
                newName: "Posteds");

            migrationBuilder.RenameIndex(
                name: "IX_Posted_ApplicationUserId1",
                table: "Posteds",
                newName: "IX_Posteds_ApplicationUserId1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Seasons",
                table: "Seasons",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Posteds",
                table: "Posteds",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Posteds_SeasonId",
                table: "Posteds",
                column: "SeasonId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Seasons_SeasonId",
                table: "AspNetUsers",
                column: "SeasonId",
                principalTable: "Seasons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posteds_AspNetUsers_ApplicationUserId1",
                table: "Posteds",
                column: "ApplicationUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posteds_Seasons_SeasonId",
                table: "Posteds",
                column: "SeasonId",
                principalTable: "Seasons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SkippedUsers_Seasons_SeasonId",
                table: "SkippedUsers",
                column: "SeasonId",
                principalTable: "Seasons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Seasons_SeasonId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Posteds_AspNetUsers_ApplicationUserId1",
                table: "Posteds");

            migrationBuilder.DropForeignKey(
                name: "FK_Posteds_Seasons_SeasonId",
                table: "Posteds");

            migrationBuilder.DropForeignKey(
                name: "FK_SkippedUsers_Seasons_SeasonId",
                table: "SkippedUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Seasons",
                table: "Seasons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Posteds",
                table: "Posteds");

            migrationBuilder.DropIndex(
                name: "IX_Posteds_SeasonId",
                table: "Posteds");

            migrationBuilder.RenameTable(
                name: "Seasons",
                newName: "Season");

            migrationBuilder.RenameTable(
                name: "Posteds",
                newName: "Posted");

            migrationBuilder.RenameIndex(
                name: "IX_Posteds_ApplicationUserId1",
                table: "Posted",
                newName: "IX_Posted_ApplicationUserId1");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Season",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Season",
                table: "Season",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Posted",
                table: "Posted",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Posted_AspNetUsers_ApplicationUserId1",
                table: "Posted",
                column: "ApplicationUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Season_AspNetUsers_ApplicationUserId",
                table: "Season",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SkippedUsers_Season_SeasonId",
                table: "SkippedUsers",
                column: "SeasonId",
                principalTable: "Season",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
