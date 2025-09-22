using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioBlazor.Server.BL.Migrations
{
    /// <inheritdoc />
    public partial class fixedProjectSeeds2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDate",
                value: new DateTime(2023, 6, 8, 17, 31, 54, 729, DateTimeKind.Local).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDate",
                value: new DateTime(2023, 6, 8, 17, 31, 54, 729, DateTimeKind.Local).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDate",
                value: new DateTime(2023, 6, 8, 17, 31, 54, 729, DateTimeKind.Local).AddTicks(7375));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
