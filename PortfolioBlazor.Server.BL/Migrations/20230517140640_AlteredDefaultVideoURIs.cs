using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioBlazor.Server.BL.Migrations
{
    /// <inheritdoc />
    public partial class AlteredDefaultVideoURIs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MotorcycleVideos",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoUrl",
                value: "https://drive.google.com/file/d/12D9eX-sjUJpMIvm1I8EOrcaQVuusSnly/preview");

            migrationBuilder.UpdateData(
                table: "MotorcycleVideos",
                keyColumn: "Id",
                keyValue: 2,
                column: "VideoUrl",
                value: "https://drive.google.com/file/d/1BS-22PZ8CDcDwrdYnYJ6vXbQ3j4_UQD9/preview");

            migrationBuilder.UpdateData(
                table: "MotorcycleVideos",
                keyColumn: "Id",
                keyValue: 3,
                column: "VideoUrl",
                value: "https://drive.google.com/file/d/1Zu6tYhZ8rPyWbW-3zoFWW4yCCZ_Wqbj1/preview");

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDate",
                value: new DateTime(2023, 5, 17, 10, 6, 40, 359, DateTimeKind.Local).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDate",
                value: new DateTime(2023, 5, 17, 10, 6, 40, 359, DateTimeKind.Local).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDate",
                value: new DateTime(2023, 5, 17, 10, 6, 40, 359, DateTimeKind.Local).AddTicks(3453));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MotorcycleVideos",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoUrl",
                value: "https://drive.google.com/file/d/12D9eX-sjUJpMIvm1I8EOrcaQVuusSnly/view?usp=sharing");

            migrationBuilder.UpdateData(
                table: "MotorcycleVideos",
                keyColumn: "Id",
                keyValue: 2,
                column: "VideoUrl",
                value: "https://drive.google.com/file/d/1BS-22PZ8CDcDwrdYnYJ6vXbQ3j4_UQD9/view?usp=sharing");

            migrationBuilder.UpdateData(
                table: "MotorcycleVideos",
                keyColumn: "Id",
                keyValue: 3,
                column: "VideoUrl",
                value: "https://drive.google.com/file/d/1Zu6tYhZ8rPyWbW-3zoFWW4yCCZ_Wqbj1/view?usp=sharing");

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDate",
                value: new DateTime(2023, 5, 16, 21, 41, 43, 527, DateTimeKind.Local).AddTicks(5739));

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDate",
                value: new DateTime(2023, 5, 16, 21, 41, 43, 527, DateTimeKind.Local).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDate",
                value: new DateTime(2023, 5, 16, 21, 41, 43, 527, DateTimeKind.Local).AddTicks(5783));
        }
    }
}
