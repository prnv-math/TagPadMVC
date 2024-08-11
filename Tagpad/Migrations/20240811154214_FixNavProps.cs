using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tagpad.Migrations
{
    /// <inheritdoc />
    public partial class FixNavProps : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NoteTagRecords_Notes_NoteID",
                table: "NoteTagRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_NoteTagRecords_Tags_TagID",
                table: "NoteTagRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_Tags_AspNetUsers_UserID",
                table: "Tags");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "Tags",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "Notes",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_NoteTagRecords_Notes_NoteID",
                table: "NoteTagRecords",
                column: "NoteID",
                principalTable: "Notes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NoteTagRecords_Tags_TagID",
                table: "NoteTagRecords",
                column: "TagID",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_AspNetUsers_UserID",
                table: "Tags",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NoteTagRecords_Notes_NoteID",
                table: "NoteTagRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_NoteTagRecords_Tags_TagID",
                table: "NoteTagRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_Tags_AspNetUsers_UserID",
                table: "Tags");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "Tags",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "Notes",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_NoteTagRecords_Notes_NoteID",
                table: "NoteTagRecords",
                column: "NoteID",
                principalTable: "Notes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NoteTagRecords_Tags_TagID",
                table: "NoteTagRecords",
                column: "TagID",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_AspNetUsers_UserID",
                table: "Tags",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
