using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioBlazor.Server.BL.Migrations
{
    /// <inheritdoc />
    public partial class addedProjectMigrations2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDate",
                value: new DateTime(2023, 5, 28, 17, 12, 46, 199, DateTimeKind.Local).AddTicks(7848));

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDate",
                value: new DateTime(2023, 5, 28, 17, 12, 46, 199, DateTimeKind.Local).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDate",
                value: new DateTime(2023, 5, 28, 17, 12, 46, 199, DateTimeKind.Local).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "Language",
                value: "C# Maui");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "Language",
                value: "TypeScript, JS, C#");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                column: "Language",
                value: "C#.NET FW");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                column: "Language",
                value: "C#.NET FW");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Language", "Name", "Url" },
                values: new object[] { "Python 3.11", "Python Maze", "https://github.com/DontDoThat21/PythonMaze" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Language", "Name", "Url" },
                values: new object[] { "Java", "JavaSystemLocker", "https://github.com/DontDoThat21/BenignSystemLockMaven" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Language", "Name", "Url" },
                values: new object[] { "C#.NET FW", "WinFormsTodos", "https://github.com/DontDoThat21/NET7WinFormsWithSqliteTodos" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Language", "Name", "Url" },
                values: new object[] { "C#.NET FW", "FlickrPhotoSearcher", "https://github.com/DontDoThat21/PhotoSearcherFlickrAPI" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Language", "Name", "Url" },
                values: new object[] { "C#.NET FW", "FrameworkWebForms", "https://github.com/DontDoThat21/FrameworkWebForms" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Language", "Name", "ProjectPhoto", "Url" },
                values: new object[] { 10, "C++", "CppCalculator", "b", "https://github.com/DontDoThat21/CppCalculator" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DropColumn(
                name: "Language",
                table: "Projects");

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

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "Url" },
                values: new object[] { "JavaSystemLocker", "https://github.com/DontDoThat21/BenignSystemLockMaven" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Name", "Url" },
                values: new object[] { "WinFormsTodos", "https://github.com/DontDoThat21/NET7WinFormsWithSqliteTodos" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "Url" },
                values: new object[] { "FlickrPhotoSearcher", "https://github.com/DontDoThat21/PhotoSearcherFlickrAPI" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Name", "Url" },
                values: new object[] { "FrameworkWebForms", "https://github.com/DontDoThat21/FrameworkWebForms" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Name", "Url" },
                values: new object[] { "CppCalculator", "https://github.com/DontDoThat21/CppCalculator" });
        }
    }
}
