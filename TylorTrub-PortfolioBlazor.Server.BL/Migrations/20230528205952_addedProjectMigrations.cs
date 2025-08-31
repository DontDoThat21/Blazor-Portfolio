using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TylorTrubPortfolioBlazor.Server.BL.Migrations
{
    /// <inheritdoc />
    public partial class addedProjectMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectPhoto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDate",
                value: new DateTime(2023, 5, 28, 16, 59, 52, 43, DateTimeKind.Local).AddTicks(1663));

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDate",
                value: new DateTime(2023, 5, 28, 16, 59, 52, 43, DateTimeKind.Local).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDate",
                value: new DateTime(2023, 5, 28, 16, 59, 52, 43, DateTimeKind.Local).AddTicks(1708));

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Name", "ProjectPhoto", "Url" },
                values: new object[,]
                {
                    { 1, "MauiTodos", "b", "https://github.com/DontDoThat21/NET7MauiWithSqliteTodos" },
                    { 2, "AngularEmployeeManager", "b", "https://github.com/DontDoThat21/Angular16" },
                    { 3, "AngularAPI", "b", "https://github.com/DontDoThat21/WebAPI" },
                    { 4, "HotSBot", "b", "https://github.com/DontDoThat21/HotSBot" },
                    { 5, "JavaSystemLocker", "b", "https://github.com/DontDoThat21/BenignSystemLockMaven" },
                    { 6, "WinFormsTodos", "b", "https://github.com/DontDoThat21/NET7WinFormsWithSqliteTodos" },
                    { 7, "FlickrPhotoSearcher", "b", "https://github.com/DontDoThat21/PhotoSearcherFlickrAPI" },
                    { 8, "FrameworkWebForms", "b", "https://github.com/DontDoThat21/FrameworkWebForms" },
                    { 9, "CppCalculator", "b", "https://github.com/DontDoThat21/TylorTrubCppCalculator" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDate",
                value: new DateTime(2023, 5, 28, 12, 29, 10, 585, DateTimeKind.Local).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDate",
                value: new DateTime(2023, 5, 28, 12, 29, 10, 585, DateTimeKind.Local).AddTicks(7841));

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDate",
                value: new DateTime(2023, 5, 28, 12, 29, 10, 585, DateTimeKind.Local).AddTicks(7844));
        }
    }
}
