using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tagpad.Migrations
{
    /// <inheritdoc />
    public partial class fixTagForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notes_AspNetUsers_UserID",
                table: "Notes");

            migrationBuilder.DropForeignKey(
                name: "FK_Tags_AspNetUsers_UserID",
                table: "Tags");

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_AspNetUsers_UserID",
                table: "Notes",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_AspNetUsers_UserID",
                table: "Tags",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
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
                principalColumn: "Id");
        }
    }
}
