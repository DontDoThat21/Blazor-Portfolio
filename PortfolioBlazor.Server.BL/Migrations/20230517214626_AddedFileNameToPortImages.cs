using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioBlazor.Server.BL.Migrations
{
    /// <inheritdoc />
    public partial class AddedFileNameToPortImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "PortfolioImages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDate",
                value: new DateTime(2023, 5, 17, 17, 46, 25, 286, DateTimeKind.Local).AddTicks(1882));

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDate",
                value: new DateTime(2023, 5, 17, 17, 46, 25, 286, DateTimeKind.Local).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDate",
                value: new DateTime(2023, 5, 17, 17, 46, 25, 286, DateTimeKind.Local).AddTicks(1928));

            migrationBuilder.UpdateData(
                table: "PortfolioImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "FileName",
                value: "home1.jpg");

            migrationBuilder.UpdateData(
                table: "PortfolioImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "FileName",
                value: "home2.jpg");

            migrationBuilder.UpdateData(
                table: "PortfolioImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "FileName",
                value: "home3.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileName",
                table: "PortfolioImages");

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDate",
                value: new DateTime(2023, 5, 17, 16, 59, 28, 229, DateTimeKind.Local).AddTicks(1224));

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDate",
                value: new DateTime(2023, 5, 17, 16, 59, 28, 229, DateTimeKind.Local).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDate",
                value: new DateTime(2023, 5, 17, 16, 59, 28, 229, DateTimeKind.Local).AddTicks(1273));
        }
    }
}
