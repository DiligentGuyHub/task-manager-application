using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDo.EntityFramework.Migrations
{
    public partial class globalreogranization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Files_Files__FileId",
                table: "Files");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Images__ImageId",
                table: "Images");

            migrationBuilder.DropTable(
                name: "SubTasks");

            migrationBuilder.DropIndex(
                name: "IX_Images__ImageId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Files__FileId",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "_ImageId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "_FileId",
                table: "Files");

            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "Tasks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TaskId",
                table: "Tasks",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TaskId",
                table: "Images",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Images",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TaskId",
                table: "Files",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "File",
                table: "Files",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TaskId",
                table: "Categories",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_AccountId",
                table: "Tasks",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_TaskId",
                table: "Tasks",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_TaskId",
                table: "Images",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_TaskId",
                table: "Files",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_TaskId",
                table: "Categories",
                column: "TaskId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Tasks_TaskId",
                table: "Categories",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Files_Tasks_TaskId",
                table: "Files",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Tasks_TaskId",
                table: "Images",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Tasks_TaskId",
                table: "Tasks",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Users_AccountId",
                table: "Tasks",
                column: "AccountId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Tasks_TaskId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Files_Tasks_TaskId",
                table: "Files");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Tasks_TaskId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Tasks_TaskId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Users_AccountId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_AccountId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_TaskId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Images_TaskId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Files_TaskId",
                table: "Files");

            migrationBuilder.DropIndex(
                name: "IX_Categories_TaskId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "TaskId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "File",
                table: "Files");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "TaskId",
                table: "Images",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "_ImageId",
                table: "Images",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TaskId",
                table: "Files",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "_FileId",
                table: "Files",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TaskId",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "SubTasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Header = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaskId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isCompleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubTasks", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Images__ImageId",
                table: "Images",
                column: "_ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Files__FileId",
                table: "Files",
                column: "_FileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Files_Files__FileId",
                table: "Files",
                column: "_FileId",
                principalTable: "Files",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Images__ImageId",
                table: "Images",
                column: "_ImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
