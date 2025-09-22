using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioBlazor.Server.BL.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedContent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDate",
                value: new DateTime(2024, 4, 1, 17, 48, 46, 117, DateTimeKind.Local).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDate",
                value: new DateTime(2024, 4, 1, 17, 48, 46, 117, DateTimeKind.Local).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDate",
                value: new DateTime(2024, 4, 1, 17, 48, 46, 117, DateTimeKind.Local).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DisplayText",
                value: "Crossing the Upper Peninsula of Michigan on a sport-bike is wild! The middle connection is grated, leaving you with an intimidating view looking down! It's worth it just to see all Michigan offers.");

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DisplayText",
                value: "I decided to buy a dirt-bike and assemble it from Amazon. Seriously. Would not recommend! Fun building it and ripping around the dunes. One day I'll buy a real YZ250/450f.");

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DisplayText",
                value: "Finishing the assembly was a joy, I ultimately replaced the carb with a newer custom higher throughput one. This noticeably increased the BHP by about 10%.");

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 18,
                column: "DisplayText",
                value: "Gaming is in my blood! As a kid, I started getting into heavy back end programming with a title named Garry's Mod. Research TTT and look up WITD Server if curious!");

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 19,
                column: "DisplayText",
                value: "StarCraft is my favorite game! It requires so much attention, and intense, quick multi-tasking proficiencies under stress. Something I consider myself skilled at, I love StarCraft even though some consider it too difficult to learn with all the casual titles out these days. Life is about mastering difficult things!");

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 20,
                column: "DisplayText",
                value: "Nothing like winding down with a beverage and some Dark Souls. Most challenging title I've every played with a controller by far! Dex builds know what's up!");

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 21,
                column: "DisplayText",
                value: "I used to take the scenic routes of Detroit after work, and just enjoy the sky. Nothing like the smell of the Earth's petrichor into a pleasant ride around town. Sure makes wheelies risky though!");

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 23,
                column: "DisplayText",
                value: "I sort of enjoyed the experiences that COVID uniquely offered me. More room for motorcycles on the road; it was a great opportunity to improve my desktop, and enjoy a more balanced work-life from home at the same time. Win-win.");

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 25,
                column: "DisplayText",
                value: "I really enjoy playing my guitar when I have the time to do so. One day I am sure I'll have a legendary guitar collection! *starts playing dear god by a7x*.");

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 28,
                column: "DisplayText",
                value: "The beauty of Michigan is sometimes understated. You truly experience all seasons; the spring and fall feels like free air conditioning outside! It's great.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDate",
                value: new DateTime(2023, 6, 8, 17, 58, 30, 446, DateTimeKind.Local).AddTicks(9534));

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDate",
                value: new DateTime(2023, 6, 8, 17, 58, 30, 446, DateTimeKind.Local).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDate",
                value: new DateTime(2023, 6, 8, 17, 58, 30, 446, DateTimeKind.Local).AddTicks(9582));

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DisplayText",
                value: "Crossing the Upper Peninsula of Michigan on a sport-bike is wild! The middle connection is grated, leaving you with an intimidating view down! It's worth it just to see all Michigan offers of course.");

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DisplayText",
                value: "I decided to buy a cheap dirk-bike and assemble it from an online store. Would not recommend! Was underpowered and arrived with problems. Fun though!");

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DisplayText",
                value: "Finishing the assembly was a joy, however I ultimately had to replace the carb with a newer custom one. This increased the BHP by about 10%.");

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 18,
                column: "DisplayText",
                value: "Gaming is in my blood! As a kid, I started programming back end software with a title named Garry's Mod. Research TTT and look up WITD Server if curious!");

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 19,
                column: "DisplayText",
                value: "StarCraft is my favorite game! It requires so much attention, and intense multi tasking proficiency. Something I consider myself skilled at, I love StarCraft even though some consider it too difficult to learn. Life is about mastering difficult things anyways!");

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 20,
                column: "DisplayText",
                value: "Nothing like winding down with a beverage and some Dark Souls III. Most challenging title I've every played with a controller by far! Dex builds know what's up!");

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 21,
                column: "DisplayText",
                value: "I used to take the scenic routes of Detroit after work, and just enjoy the sky. Nothing like the smell of the Earth's Petrichor into a pleasant ride around town. Sure makes wheelies scary though!");

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 23,
                column: "DisplayText",
                value: "I for one, enjoyed the experiences that COVID offered me. More room for motorcycles on the road; it was a great opportunity to improve my desktop, and enjoy working from home at the same time.");

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 25,
                column: "DisplayText",
                value: "I really enjoy playing my guitar when I have time to do so. One day I am sure I'll have a nice guitar collection! *starts playing dear god by a7x*.");

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 28,
                column: "DisplayText",
                value: "The beauty of Michigan is sometimes understated. You truly experience all seasons, and the spring and fall feels like free air conditioning outside! It's great.");
        }
    }
}
