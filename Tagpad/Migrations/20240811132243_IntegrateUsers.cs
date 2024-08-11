using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tagpad.Migrations
{
    /// <inheritdoc />
    public partial class IntegrateUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "Tags",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "Notes",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Tags_UserID",
                table: "Tags",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_UserID",
                table: "Notes",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_AspNetUsers_UserID",
                table: "Notes",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_AspNetUsers_UserID",
                table: "Tags",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notes_AspNetUsers_UserID",
                table: "Notes");

            migrationBuilder.DropForeignKey(
                name: "FK_Tags_AspNetUsers_UserID",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Tags_UserID",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Notes_UserID",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Notes");
        }
    }
}
