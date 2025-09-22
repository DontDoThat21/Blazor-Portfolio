using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PortfolioBlazor.Server.BL.Migrations
{
    /// <inheritdoc />
    public partial class AddedHomeViewModelAndMotorcycleVideoModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Motorcycles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MotorcycleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotorcycleCc = table.Column<int>(type: "int", nullable: true),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<byte>(type: "tinyint", nullable: true),
                    EngineStyle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Torque = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brakes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motorcycles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MotorcycleVideos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VideoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotorcycleVideos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Motorcycles",
                columns: new[] { "Id", "AddDate", "Brakes", "EngineStyle", "Hp", "Manufacturer", "MotorcycleCc", "MotorcycleName", "Picture", "Torque", "Year" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 16, 21, 34, 33, 637, DateTimeKind.Local).AddTicks(8546), "Brembo", "Four Stroke V4", "0", "Yamaha", 998, "Yamaha MT-10", "yamahamt10.jpg", "110.8ft", (byte)19 },
                    { 2, new DateTime(2023, 5, 16, 21, 34, 33, 637, DateTimeKind.Local).AddTicks(8595), "Brembo", "Four Stroke Supercharged", "0", "Kawasaki", 998, "Kawasaki H2-R", "kawasakih2r.png", "115ft", (byte)23 },
                    { 3, new DateTime(2023, 5, 16, 21, 34, 33, 637, DateTimeKind.Local).AddTicks(8598), "1-Disc-Rear, 2-Front", "4-Stroke Twin Boxer", "0", "BMW", 1085, "BMW R1100RS", "bmwk1100caferacer.jpg", "92.9ft", (byte)2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Motorcycles");

            migrationBuilder.DropTable(
                name: "MotorcycleVideos");
        }
    }
}
