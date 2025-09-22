using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PortfolioBlazor.Server.BL.Migrations
{
    /// <inheritdoc />
    public partial class addCompanyRecordsMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "City", "Name", "PhoneNumber", "PostalCode", "State", "StreetAddress" },
                values: new object[,]
                {
                    { 1, "Torrance", "Tech Industrials", "3105556612", "98001", "CA", "321 Tech St." },
                    { 2, "Royal Oak", "Elastic Books", "2485556947", "48312", "MI", "912 Vilardo St." },
                    { 3, "Lala Land", "Readers Club", "6725556993", "99999", "TN", "999 Main St." }
                });

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDate",
                value: new DateTime(2023, 5, 26, 10, 14, 29, 888, DateTimeKind.Local).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDate",
                value: new DateTime(2023, 5, 26, 10, 14, 29, 888, DateTimeKind.Local).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDate",
                value: new DateTime(2023, 5, 26, 10, 14, 29, 888, DateTimeKind.Local).AddTicks(3069));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDate",
                value: new DateTime(2023, 5, 26, 9, 49, 12, 719, DateTimeKind.Local).AddTicks(1089));

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDate",
                value: new DateTime(2023, 5, 26, 9, 49, 12, 719, DateTimeKind.Local).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDate",
                value: new DateTime(2023, 5, 26, 9, 49, 12, 719, DateTimeKind.Local).AddTicks(1162));
        }
    }
}
