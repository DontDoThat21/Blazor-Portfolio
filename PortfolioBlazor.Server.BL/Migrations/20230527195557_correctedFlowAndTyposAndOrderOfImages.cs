using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PortfolioBlazor.Server.BL.Migrations
{
    /// <inheritdoc />
    public partial class correctedFlowAndTyposAndOrderOfImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDate",
                value: new DateTime(2023, 5, 27, 15, 55, 57, 112, DateTimeKind.Local).AddTicks(103));

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDate",
                value: new DateTime(2023, 5, 27, 15, 55, 57, 112, DateTimeKind.Local).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDate",
                value: new DateTime(2023, 5, 27, 15, 55, 57, 112, DateTimeKind.Local).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DisplayText",
                value: "Motorcycling is a big hobby of mine. As you scroll down, you will see more of my travels, what I like to do for fun,and core pieces of who I am.");

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "Auburn Hills is a beautiful area, with tons of activities and exciting opportunities.", "homeauburnhills1.jpg", "AH DET Apt 1" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "It can even snow in Auburn Hills when it's sunny out!", "homeauburnhills2.jpg", "AH DET Apt 2" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "The snow build up can be quite intense at times. That's when you take off traction control, and find an empty parking lot!", "homeauburnhills3.jpg", "AH DET Apt 3" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "Crossing the Upper Peninsula of Michigan on a sport-bike is wild! The middle connection is grated, leaving you with an intimidating view down! It's worth it just to see all Michigan offers of course.", "homedancininseptemba1.jpg", "CA Work Warehouse 1" });

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
                keyValue: 22,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "Motorcycling with pals, and Baby Yoda sponsored FOX hoodies? Sign me up! I miss this hoodie and wish I could find a replacement. So many compliments with it!", "homebikeyoda1.jpg", "Motorcycling MI Yoda 1" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "I for one, enjoyed the experiences that COVID offered me. More room for motorcycles on the road; it was a great opportunity to improve my desktop, and enjoy working from home at the same time.", "homedesk1.jpg", "Desk MI Signs 1" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "The fam out here in NC is great! Nothing like spending time with those you love. From fishing, to driving to beautiful scenery, to concerts, we do it all!", "homegroupnc1.jpg", "Home NC Group 1" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DisplayText", "FileName" },
                values: new object[] { "I really enjoy playing my guitar when I have time to do so. One day I am sure I'll have a nice guitar collection! *starts playing dear god by a7x*.", "homeguitarpontiac1.jpg" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "Michigan will probably always be 'home' to me; I was raised close to 9 mile and the streets here have definitely had a large influence on my life.", "homemichigan1.jpg", "Home MI Sky 1" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "I am a big fan of Bicycling! It's good exercise and I love to see new trails and new people who share the same hobby. Feels like you're part of a club or something sometimes..", "homemichiganbike1.jpg", "Home MI Sky 1" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DisplayText", "FileName" },
                values: new object[] { "The beauty of Michigan is sometimes understated. You truly experience all seasons, and the spring and fall feels like free air conditioning outside! It's great.", "homemichiganboulevard1.jpg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: 10,
                column: "DisplayText",
                value: "Motorcycling is a big hobby of mine. As you scroll down,you will see more of my travels, what I like to do for fun,and core pieces of who I am.");

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
                keyValue: 22,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "I used to take the scenic routes of Detroit after work, and just enjoy the sky. Nothing like the smell of the Earth's Petrichor into a pleasant ride around town. Sure makes wheelies scary though!", "homebikejoslyn1.jpg", "Motorcycling MI Joslyn 1" });

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

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DisplayText", "FileName" },
                values: new object[] { "I for one, enjoyed the experiences that COVID offered me. More room for motorcycles on the road; it was a great opportunity to improve my desktop, and enjoy working from home at the same time.", "homedesk1.jpg" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "The fam out here in NC is great! Nothing like spending time with those you love. From fishing, to driving to beautiful scenery, to concerts, we do it all!", "homegroupnc1.jpg", "Home NC Group 1" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DisplayText", "FileName", "Name" },
                values: new object[] { "I really enjoy playing my guitar when I have time to do so. One day I am sure I'll have a nice guitar collection! *starts playing dear god by a7x*.", "homeguitarpontiac1.jpg", "Desk MI Signs 1" });

            migrationBuilder.UpdateData(
                table: "PortfolioImageVideos",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DisplayText", "FileName" },
                values: new object[] { "Michigan will probably always be 'home' to me; I was raised close to 9 mile and the streets here have definitely had a large influence on my life.", "homemichigan1.jpg" });

            migrationBuilder.InsertData(
                table: "PortfolioImageVideos",
                columns: new[] { "Id", "DisplayText", "FileName", "Name" },
                values: new object[,]
                {
                    { 29, "I am a big fan of Bicycling! It's good exercise and I love to see new trails and new people who share the same hobby. Feels like you're part of a club or something sometimes..", "homemichiganbike1.jpg", "Home MI Sky 1" },
                    { 30, "The beauty of Michigan is sometimes understated. You truly experience all seasons, and the spring and fall feels like free air conditioning outside! It's great.", "homemichiganboulevard1.jpg", "Home MI Sky 1" }
                });
        }
    }
}
