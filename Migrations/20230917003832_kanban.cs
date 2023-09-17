using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace andromeda.Migrations
{
    /// <inheritdoc />
    public partial class kanban : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskList_Colunas_ColunaId",
                table: "TaskList");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_TaskList_TaskListId",
                table: "Tasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaskList",
                table: "TaskList");

            migrationBuilder.RenameTable(
                name: "TaskList",
                newName: "TaskLists");

            migrationBuilder.RenameIndex(
                name: "IX_TaskList_ColunaId",
                table: "TaskLists",
                newName: "IX_TaskLists_ColunaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaskLists",
                table: "TaskLists",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskLists_Colunas_ColunaId",
                table: "TaskLists",
                column: "ColunaId",
                principalTable: "Colunas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_TaskLists_TaskListId",
                table: "Tasks",
                column: "TaskListId",
                principalTable: "TaskLists",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskLists_Colunas_ColunaId",
                table: "TaskLists");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_TaskLists_TaskListId",
                table: "Tasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaskLists",
                table: "TaskLists");

            migrationBuilder.RenameTable(
                name: "TaskLists",
                newName: "TaskList");

            migrationBuilder.RenameIndex(
                name: "IX_TaskLists_ColunaId",
                table: "TaskList",
                newName: "IX_TaskList_ColunaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaskList",
                table: "TaskList",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskList_Colunas_ColunaId",
                table: "TaskList",
                column: "ColunaId",
                principalTable: "Colunas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_TaskList_TaskListId",
                table: "Tasks",
                column: "TaskListId",
                principalTable: "TaskList",
                principalColumn: "Id");
        }
    }
}
