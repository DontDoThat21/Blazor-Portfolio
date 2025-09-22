using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioBlazor.Server.BL.Migrations
{
    /// <inheritdoc />
    public partial class FixedProjectSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDate",
                value: new DateTime(2023, 6, 8, 11, 15, 50, 304, DateTimeKind.Local).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDate",
                value: new DateTime(2023, 6, 8, 11, 15, 50, 304, DateTimeKind.Local).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDate",
                value: new DateTime(2023, 6, 8, 11, 15, 50, 304, DateTimeKind.Local).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProjectPhoto",
                value: "mauiTodos");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProjectPhoto",
                value: "angularEmployeeManager");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProjectPhoto",
                value: "angularEmployeeDepartmentAPI");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProjectPhoto",
                value: "hotsBot");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProjectPhoto",
                value: "pythonMaze");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Language", "Name", "ProjectPhoto", "Url" },
                values: new object[] { "C#.NET FW", "WinFormsTodos", "net7WinFormsSqlLiteTodos", "https://github.com/DontDoThat21/NET7WinFormsWithSqliteTodos" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Language", "Name", "Url" },
                values: new object[] { "C#.NET FW", "FlickrPhotoSearcher", "https://github.com/DontDoThat21/PhotoSearcherFlickrAPI" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "Url" },
                values: new object[] { "FrameworkWebForms", "https://github.com/DontDoThat21/FrameworkWebForms" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Language", "Name", "ProjectPhoto", "Url" },
                values: new object[] { "C++", "CppCalculator", "cppCalculator", "https://github.com/DontDoThat21/CppCalculator" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDate",
                value: new DateTime(2023, 5, 29, 15, 22, 53, 801, DateTimeKind.Local).AddTicks(3121));

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDate",
                value: new DateTime(2023, 5, 29, 15, 22, 53, 801, DateTimeKind.Local).AddTicks(3174));

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDate",
                value: new DateTime(2023, 5, 29, 15, 22, 53, 801, DateTimeKind.Local).AddTicks(3178));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProjectPhoto",
                value: "b");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProjectPhoto",
                value: "b");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProjectPhoto",
                value: "b");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProjectPhoto",
                value: "b");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProjectPhoto",
                value: "b");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Language", "Name", "ProjectPhoto", "Url" },
                values: new object[] { "Java", "JavaSystemLocker", "b", "https://github.com/DontDoThat21/BenignSystemLockMaven" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Language", "Name", "ProjectPhoto", "Url" },
                values: new object[] { "C#.NET FW", "WinFormsTodos", "b", "https://github.com/DontDoThat21/NET7WinFormsWithSqliteTodos" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Name", "Url" },
                values: new object[] { "FlickrPhotoSearcher", "https://github.com/DontDoThat21/PhotoSearcherFlickrAPI" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Language", "Name", "ProjectPhoto", "Url" },
                values: new object[] { "C#.NET FW", "FrameworkWebForms", "b", "https://github.com/DontDoThat21/FrameworkWebForms" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Language", "Name", "ProjectPhoto", "Url" },
                values: new object[] { 11, "C++", "CppCalculator", "b", "https://github.com/DontDoThat21/CppCalculator" });
        }
    }
}
