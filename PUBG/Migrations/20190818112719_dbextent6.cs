using Microsoft.EntityFrameworkCore.Migrations;

namespace PUBG.Migrations
{
    public partial class dbextent6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posteds_AspNetUsers_ApplicationUserId1",
                table: "Posteds");

            migrationBuilder.DropForeignKey(
                name: "FK_SkippedUsers_AspNetUsers_ApplicationUserId1",
                table: "SkippedUsers");

            migrationBuilder.DropIndex(
                name: "IX_SkippedUsers_ApplicationUserId1",
                table: "SkippedUsers");

            migrationBuilder.DropIndex(
                name: "IX_Posteds_ApplicationUserId1",
                table: "Posteds");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId1",
                table: "SkippedUsers");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId1",
                table: "Posteds");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "SkippedUsers",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "Posteds",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_SkippedUsers_ApplicationUserId",
                table: "SkippedUsers",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Posteds_ApplicationUserId",
                table: "Posteds",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posteds_AspNetUsers_ApplicationUserId",
                table: "Posteds",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SkippedUsers_AspNetUsers_ApplicationUserId",
                table: "SkippedUsers",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posteds_AspNetUsers_ApplicationUserId",
                table: "Posteds");

            migrationBuilder.DropForeignKey(
                name: "FK_SkippedUsers_AspNetUsers_ApplicationUserId",
                table: "SkippedUsers");

            migrationBuilder.DropIndex(
                name: "IX_SkippedUsers_ApplicationUserId",
                table: "SkippedUsers");

            migrationBuilder.DropIndex(
                name: "IX_Posteds_ApplicationUserId",
                table: "Posteds");

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationUserId",
                table: "SkippedUsers",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId1",
                table: "SkippedUsers",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationUserId",
                table: "Posteds",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId1",
                table: "Posteds",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SkippedUsers_ApplicationUserId1",
                table: "SkippedUsers",
                column: "ApplicationUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Posteds_ApplicationUserId1",
                table: "Posteds",
                column: "ApplicationUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Posteds_AspNetUsers_ApplicationUserId1",
                table: "Posteds",
                column: "ApplicationUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SkippedUsers_AspNetUsers_ApplicationUserId1",
                table: "SkippedUsers",
                column: "ApplicationUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
