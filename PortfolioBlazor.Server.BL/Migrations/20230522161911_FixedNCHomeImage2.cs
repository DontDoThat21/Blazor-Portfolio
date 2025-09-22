using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioBlazor.Server.BL.Migrations
{
    /// <inheritdoc />
    public partial class FixedNCHomeImage2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDate",
                value: new DateTime(2023, 5, 22, 12, 19, 10, 925, DateTimeKind.Local).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDate",
                value: new DateTime(2023, 5, 22, 12, 19, 10, 925, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDate",
                value: new DateTime(2023, 5, 22, 12, 19, 10, 925, DateTimeKind.Local).AddTicks(9513));

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 2,
                column: "FileName",
                value: "home2.jpg");

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 4,
                column: "FileName",
                value: "homebike1.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDate",
                value: new DateTime(2023, 5, 21, 19, 56, 21, 736, DateTimeKind.Local).AddTicks(5259));

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDate",
                value: new DateTime(2023, 5, 21, 19, 56, 21, 736, DateTimeKind.Local).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDate",
                value: new DateTime(2023, 5, 21, 19, 56, 21, 736, DateTimeKind.Local).AddTicks(5316));

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 2,
                column: "FileName",
                value: "NC Sunset home2.jpg");

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 4,
                column: "FileName",
                value: "motorcycle\\homebike1.jpg");
        }
    }
}
