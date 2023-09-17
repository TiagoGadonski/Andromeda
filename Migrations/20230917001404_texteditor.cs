using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace andromeda.Migrations
{
    /// <inheritdoc />
    public partial class texteditor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TextEditors_Tags_TagId",
                table: "TextEditors");

            migrationBuilder.DropIndex(
                name: "IX_TextEditors_TagId",
                table: "TextEditors");

            migrationBuilder.DropColumn(
                name: "TagId",
                table: "TextEditors");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Tags",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TextEditorId",
                table: "Tags",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tags_TextEditorId",
                table: "Tags",
                column: "TextEditorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_TextEditors_TextEditorId",
                table: "Tags",
                column: "TextEditorId",
                principalTable: "TextEditors",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tags_TextEditors_TextEditorId",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Tags_TextEditorId",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "TextEditorId",
                table: "Tags");

            migrationBuilder.AddColumn<int>(
                name: "TagId",
                table: "TextEditors",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TextEditors_TagId",
                table: "TextEditors",
                column: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_TextEditors_Tags_TagId",
                table: "TextEditors",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id");
        }
    }
}
