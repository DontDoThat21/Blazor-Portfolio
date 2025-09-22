using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PortfolioBlazor.Server.BL.Migrations
{
    /// <inheritdoc />
    public partial class AddedHomeViewModelAndMotorcycleVideoModelDefaults : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MotorcycleVideos",
                columns: new[] { "Id", "VideoUrl" },
                values: new object[,]
                {
                    { 1, "https://drive.google.com/file/d/12D9eX-sjUJpMIvm1I8EOrcaQVuusSnly/view?usp=sharing" },
                    { 2, "https://drive.google.com/file/d/1BS-22PZ8CDcDwrdYnYJ6vXbQ3j4_UQD9/view?usp=sharing" },
                    { 3, "https://drive.google.com/file/d/1Zu6tYhZ8rPyWbW-3zoFWW4yCCZ_Wqbj1/view?usp=sharing" }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MotorcycleVideos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MotorcycleVideos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MotorcycleVideos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDate",
                value: new DateTime(2023, 5, 16, 21, 34, 33, 637, DateTimeKind.Local).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDate",
                value: new DateTime(2023, 5, 16, 21, 34, 33, 637, DateTimeKind.Local).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDate",
                value: new DateTime(2023, 5, 16, 21, 34, 33, 637, DateTimeKind.Local).AddTicks(8598));
        }
    }
}
