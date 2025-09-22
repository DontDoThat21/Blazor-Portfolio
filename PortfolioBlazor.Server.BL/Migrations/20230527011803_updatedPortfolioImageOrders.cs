using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioBlazor.Server.BL.Migrations
{
    /// <inheritdoc />
    public partial class updatedPortfolioImageOrders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDate",
                value: new DateTime(2023, 5, 26, 21, 18, 3, 762, DateTimeKind.Local).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDate",
                value: new DateTime(2023, 5, 26, 21, 18, 3, 762, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDate",
                value: new DateTime(2023, 5, 26, 21, 18, 3, 762, DateTimeKind.Local).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "Working closely with shop carpenters and foreman, creating tailored applications was an exciting opportunity to growas a developer, and as a solutions architect.", "homecawork2.jpg", "CA Work Warehouse 1" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "I maintained, improved, and created paint management software as a developer, and as a solutions architect.", "homemiwork1.jpg", "MI Work Paint 1" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "I've built many desktops, but this has to be my most nostalgic build. A roughly rummaged together yet powerful machine to get the job done well is sometimes all it takes!", "homedesktopcustom1.jpg", "Desktop MI Desktop AH 1" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "My first professional desk after beginning a software engineering role, remotely. The pad at Boulevard Appts. was great, too many memories to count here. Would recommend.", "homedesk1.jpg", "Home Desk MI Desk AH 1" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "After a while I perfected my remote setup. Top monitor exclusively for StackOverflow and debugging knowledge/research!", "homedeskwork1.jpg", "Desktop MI Desk AH 2" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "I made custom Raspberry Pi projects come to life with HDMI inserts to feed off the current source, and thus illuminate the given corner/edge/vicinity with the same color, ambient style! Very neat project.", "homecomputerprojectpi1.jpg", "Raspberry Pi MI Yoda 1" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "As a teen, I moved to North Carolina with my family to finish school and continue my education towards being a software developer. NC being known for it's hills, I was quite the avid skateboarder.", "home2.jpg", "Home 2" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "Motorcycling is a big hobby of mine. As you scroll down,you will see more of my travels, what I like to do for fun,and core pieces of who I am.", "homebike3.jpg", "Fox Hoodie DET Home 3" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "Motorcycling is a big hobby of mine. As you scroll down,you will see more of my travels, what I like to do for fun,and core pieces of who I am.", "homebike1.jpg", "Shelby DET Home 1" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "Auburn Hills is a beautiful area, with tons of activities and exciting opportunities.", "homeauburnhills1.jpg", "AH DET Apt 1" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "It can even snow in Auburn Hills when it's sunny out!", "homeauburnhills2.jpg", "AH DET Apt 2" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "The snow build up can be quite intense at times. That's when you take off traction control, and find an empty parking lot!", "homeauburnhills3.jpg", "AH DET Apt 3" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "Crossing the Upper Peninsula of Michigan on a sport-bike is wild! The middle connection is grated, leaving you with an intimidating view down! It's worth it just to see all Michigan offers of course.", "homedancininseptemba1.jpg", "CA Work Warehouse 1" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DisplayText", "FileName" },
                values: new object[] { "I decided to buy a cheap dirk-bike and assemble it from an online store. Would not recommend! Was underpowered and arrived with problems. Fun though!", "homedirtbike1.jpg" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "Finishing the assembly was a joy, however I ultimately had to replace the carb with a newer custom one. This increased the BHP by about 10%.", "homedirtbike2.jpg", "Desktop MI AH Bike 2" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "I am a big fan of Columbian espresso. Cafe La Llave is the best! Would add some French Vanilla at the end of preparation for a perfect treat! ", "homeespresso1.jpg", "Desktop MI Espresso AH 1" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "Gaming is in my blood! As a kid, I started programming back end software with a title named Garry's Mod. Research TTT and look up WITD Server if curious!", "homegaming1.jpg", "Gaming MI Halo 1" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "StarCraft is my favorite game! It requires so much attention, and intense multi tasking proficiency. Something I consider myself skilled at, I love StarCraft even though some consider it too difficult to learn. Life is about mastering difficult things anyways!", "homegamingsc1.jpg", "Gaming MI Cuddles SC2 1" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "Nothing like winding down with a beverage and some Dark Souls III. Most challenging title I've every played with a controller by far! Dex builds know what's up!", "homebikegaming3.jpg", "Gaming MI Dark Souls 1" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "I used to take the scenic routes of Detroit after work, and just enjoy the sky. Nothing like the smell of the Earth's Petrichor into a pleasant ride around town. Sure makes wheelies scary though!", "homebikejoslyn1.jpg", "Motorcycling MI Joslyn 1" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "Motorcycling with pals, and Baby Yoda sponsored FOX hoodies? Sign me up! I miss this hoodie and wish I could find a replacement. So many compliments with it!", "homebikeyoda1.jpg", "Motorcycling MI Yoda 1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDate",
                value: new DateTime(2023, 5, 26, 17, 23, 31, 147, DateTimeKind.Local).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDate",
                value: new DateTime(2023, 5, 26, 17, 23, 31, 147, DateTimeKind.Local).AddTicks(2027));

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDate",
                value: new DateTime(2023, 5, 26, 17, 23, 31, 147, DateTimeKind.Local).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "As a teen, I moved to North Carolina with my family to finish school and continue my education towards being a software developer. NC being known for it's hills, I was quite the avid skateboarder.", "home2.jpg", "Home 2" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "Motorcycling is a big hobby of mine. As you scroll down,you will see more of my travels, what I like to do for fun,and core pieces of who I am.", "homebike3.jpg", "Fox Hoodie DET Home 3" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "Motorcycling is a big hobby of mine. As you scroll down,you will see more of my travels, what I like to do for fun,and core pieces of who I am.", "homebike1.jpg", "Shelby DET Home 1" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "Auburn Hills is a beautiful area, with tons of activities and exciting opportunities.", "homeauburnhills1.jpg", "AH DET Apt 1" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "It can even snow in Auburn Hills when it's sunny out!", "homeauburnhills2.jpg", "AH DET Apt 2" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "The snow build up can be quite intense at times. That's when you take off traction control, and find an empty parking lot!", "homeauburnhills3.jpg", "AH DET Apt 3" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "Working closely with shop carpenters and foreman, creating tailored applications was an exciting opportunity to growas a developer, and as a solutions architect.", "homecawork2.jpg", "CA Work Warehouse 1" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "I maintained, improved, and created as a developer, and as a solutions architect.", "homemiwork1.jpg", "MI Work Paint 1" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "Crossing the Upper Peninsula of Michigan on a sport-bike is wild! The middle connection is grated, leaving you with an intimidating view down! It's worth it just to see all Michigan offers of course.", "homedancininseptemba1.jpg", "CA Work Warehouse 1" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "My first professional desk after beginning a software engineering role, remotely. The pad at Boulevard Appts. was great, too many memories to count here. Would recommend.", "homedesk1.jpg", "Home Desk MI Desk AH 1" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "I've built many desktops, but this has to be my most nostalgic build. A roughly rummaged together yet powerful machine to get the job done well is sometimes all it takes!", "homedesktopcustom1.jpg", "Desktop MI Desktop AH 1" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "After a while I perfected my remote setup. Top monitor exclusively for StackOverflow and debugging knowledge/research!", "homedeskwork1.jpg", "Desktop MI Desk AH 2" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "I decided to buy a cheap dirk-bike and assemble it from an online store. Would not recommend! Was underpowered and arrived with problems. Fun though!", "homedirtbike1.jpg", "Desktop MI AH Bike 2" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DisplayText", "FileName" },
                values: new object[] { "Finishing the assembly was a joy, however I ultimately had to replace the carb with a newer custom one. This increased the BHP by about 10%.", "homedirtbike2.jpg" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "I am a big fan of Columbian espresso. Cafe La Llave is the best! Would add some French Vanilla at the end of preparation for a perfect treat! ", "homeespresso1.jpg", "Desktop MI Espresso AH 1" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "Gaming is in my blood! As a kid, I started programming back end software with a title named Garry's Mod. Research TTT and look up WITD Server if curious!", "homegaming1.jpg", "Gaming MI Halo 1" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "StarCraft is my favorite game! It requires so much attention, and intense multi tasking proficiency. Something I consider myself skilled at, I love StarCraft even though some consider it too difficult to learn. Life is about mastering difficult things anyways!", "homegamingsc1.jpg", "Gaming MI Cuddles SC2 1" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "Nothing like winding down with a beverage and some Dark Souls III. Most challenging title I've every played with a controller by far! Dex builds know what's up!", "homebikegaming3.jpg", "Gaming MI Dark Souls 1" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "I used to take the scenic routes of Detroit after work, and just enjoy the sky. Nothing like the smell of the Earth's Petrichor into a pleasant ride around town. Sure makes wheelies scary though!", "homebikejoslyn1.jpg", "Motorcycling MI Joslyn 1" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "Motorcycling with pals, and Baby Yoda sponsored FOX hoodies? Sign me up! I miss this hoodie and wish I could find a replacement. So many compliments with it!", "homebikeyoda1.jpg", "Motorcycling MI Yoda 1" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "I made custom Raspberry Pi projects come to life with HDMI inserts to feed off the current source, and thus illuminate the given corner/edge/vicinity with the same color, ambient style! Very neat project.", "homecomputerprojectpi1.jpg", "Raspberry Pi MI Yoda 1" });
        }
    }
}
