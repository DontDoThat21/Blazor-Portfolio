using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
//these will be needed soon.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using TylorTrubPortfolioBlazor.DTO.Models;

namespace TylorTrubPortfolioBlazor.Server.BL.Data
{
    public class PortfolioDBContext : IdentityDbContext
    {

        public PortfolioDBContext(DbContextOptions<PortfolioDBContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Motorcycle> Motorcycles { get; set; }
        public DbSet<MotorcycleVideo> MotorcycleVideos { get; set; }
        public DbSet<PortfolioImage> PortfolioImages { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ApplicationUser> applicationUsers { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    Id = 1,
                    Name = "Tech Industrials",
                    StreetAddress = "321 Tech St.",
                    City = "Torrance",
                    PostalCode = "98001",
                    State = "CA",
                    PhoneNumber = "3105556612"
                },
                new Company
                {
                    Id = 2,
                    Name = "Elastic Books",
                    StreetAddress = "912 Vilardo St.",
                    City = "Royal Oak",
                    PostalCode = "48312",
                    State = "MI",
                    PhoneNumber = "2485556947"
                },
                new Company
                {
                    Id = 3,
                    Name = "Readers Club",
                    StreetAddress = "999 Main St.",
                    City = "Lala Land",
                    PostalCode = "99999",
                    State = "TN",
                    PhoneNumber = "6725556993"
                }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Fortune of Time",
                    Author = "Billy Spark",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ISBN = "SWD9999001",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 2,
                    Title = "Dark Skies",
                    Author = "Nancy Hoover",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ISBN = "CAW777777701",
                    ListPrice = 40,
                    Price = 30,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 3,
                    Title = "Vanish in the Sunset",
                    Author = "Julian Button",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ISBN = "RITO5555501",
                    ListPrice = 55,
                    Price = 50,
                    Price50 = 40,
                    Price100 = 35,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 4,
                    Title = "Cotton Candy",
                    Author = "Abby Muscles",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ISBN = "WS3333333301",
                    ListPrice = 70,
                    Price = 65,
                    Price50 = 60,
                    Price100 = 55,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 5,
                    Title = "Rock in the Ocean",
                    Author = "Ron Parker",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ISBN = "SOTJ1111111101",
                    ListPrice = 30,
                    Price = 27,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 6,
                    Title = "Leaves and Wonders",
                    Author = "Laura Phantom",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ISBN = "FOT000000001",
                    ListPrice = 25,
                    Price = 23,
                    Price50 = 22,
                    Price100 = 20,
                    CategoryId = 2
                });

            modelBuilder.Entity<MotorcycleVideo>().HasData(
                new MotorcycleVideo { Id = 1, VideoUrl = "https://drive.google.com/file/d/12D9eX-sjUJpMIvm1I8EOrcaQVuusSnly/preview" });
            modelBuilder.Entity<MotorcycleVideo>().HasData(
                new MotorcycleVideo { Id = 2, VideoUrl = "https://drive.google.com/file/d/1BS-22PZ8CDcDwrdYnYJ6vXbQ3j4_UQD9/preview" });
            modelBuilder.Entity<MotorcycleVideo>().HasData(
                new MotorcycleVideo { Id = 3, VideoUrl = "https://drive.google.com/file/d/1Zu6tYhZ8rPyWbW-3zoFWW4yCCZ_Wqbj1/preview" });

            modelBuilder.Entity<Motorcycle>().HasData(
                new Motorcycle
                {
                    Id = 1,
                    MotorcycleName = "Yamaha MT-10",
                    MotorcycleCc = 998,
                    Manufacturer = "Yamaha",
                    Hp = "0",
                    Year = 19,
                    EngineStyle = "Four Stroke V4",
                    Torque = "110.8ft",
                    Brakes = "Brembo",
                    Picture = "yamahamt10.jpg",
                    AddDate = DateTime.Now
                },
                new Motorcycle
                {
                    Id = 2,
                    MotorcycleName = "Kawasaki H2-R",
                    MotorcycleCc = 998,
                    Manufacturer = "Kawasaki",
                    Hp = "0",
                    Year = 23,
                    EngineStyle = "Four Stroke Supercharged",
                    Torque = "115ft",
                    Brakes = "Brembo",
                    Picture = "kawasakih2r.png",
                    AddDate = DateTime.Now
                },
                new Motorcycle
                {
                    Id = 3,
                    MotorcycleName = "BMW R1100RS",
                    MotorcycleCc = 1085,
                    Manufacturer = "BMW",
                    Hp = "0",
                    Year = 02,
                    EngineStyle = "4-Stroke Twin Boxer",
                    Torque = "92.9ft",
                    Brakes = "1-Disc-Rear, 2-Front",
                    Picture = "bmwk1100caferacer.jpg",
                    AddDate = DateTime.Now
                });

            modelBuilder.Entity<PortfolioImage>().HasData(
                new PortfolioImage
                {
                    Id = 1,
                    DisplayText = "I have managed and upgraded software systems in Los Angeles, Tennessee," +
                    " and Detroit. Warehousing software work and various improvements ranges from the initial" +
                    " definition of what is included in a show, to the logistical transportation of goods to" +
                    " the show itself all through intranet software.",
                    FileName = "home1.jpg",
                    Name = "LA Flight View Home 1"
                });

            modelBuilder.Entity<PortfolioImage>().HasData(
               new PortfolioImage
               {
                   Id = 2,
                   DisplayText = "Working closely with shop carpenters and foreman, creating tailored applications was an exciting opportunity to grow" +
                   "as a developer, and as a solutions architect.",
                   FileName = "homecawork2.jpg",
                   Name = "CA Work Warehouse 1"
               });

            modelBuilder.Entity<PortfolioImage>().HasData(
               new PortfolioImage
               {
                   Id = 3,
                   DisplayText = "I maintained, improved, and created paint management software " +
                   "as a developer, and as a solutions architect.",
                   FileName = "homemiwork1.jpg",
                   Name = "MI Work Paint 1"
               });

            modelBuilder.Entity<PortfolioImage>().HasData(
                new PortfolioImage
                {
                    Id = 4,
                    DisplayText = "I've built many desktops, but this has to be my most nostalgic build. " +
                    "A roughly rummaged together yet powerful machine to get the job done well is sometimes all it takes!",
                    FileName = "homedesktopcustom1.jpg",
                    Name = "Desktop MI Desktop AH 1"
                });

            modelBuilder.Entity<PortfolioImage>().HasData(
                new PortfolioImage
                {
                    Id = 5,
                    DisplayText = "My first professional desk after beginning a software engineering role, remotely. " +
                    "The pad at Boulevard Appts. was great, too many memories to count here. Would recommend.",
                    FileName = "homedesk1.jpg",
                    Name = "Home Desk MI Desk AH 1"
                });

            modelBuilder.Entity<PortfolioImage>().HasData(
                new PortfolioImage
                {
                    Id = 6,
                    DisplayText = "After a while I perfected my remote setup. " +
                    "Top monitor exclusively for StackOverflow and debugging knowledge/research!",
                    FileName = "homedeskwork1.jpg",
                    Name = "Desktop MI Desk AH 2"
                });

            modelBuilder.Entity<PortfolioImage>().HasData(
                new PortfolioImage
                {
                    Id = 7,
                    DisplayText = "I made custom Raspberry Pi projects come to life with HDMI inserts to feed off the current source, " +
                    "and thus illuminate the given corner/edge/vicinity with the same color, ambient style! Very neat project.",
                    FileName = "homecomputerprojectpi1.jpg",
                    Name = "Raspberry Pi MI Yoda 1"
                });


            modelBuilder.Entity<PortfolioImage>().HasData(
                new PortfolioImage
                {
                    Id = 8,
                    DisplayText = "Traveling to California is always fun even for work; upgrading older Windows machines and downloading " +
                    "software to run the warehouse is an interesting task.",
                    FileName = "homecawork1.jpg",
                    Name = "CA Work Warehouse 1"
                });

            modelBuilder.Entity<PortfolioImage>().HasData(
                new PortfolioImage
                {
                    Id = 9,
                    DisplayText = "As a teen, I moved to North Carolina with my family to finish school and continue " +
                    "my education towards being a software developer. NC being known for it's hills, I was quite the avid skateboarder.",
                    FileName = "home2.jpg",
                    Name = "Home 2"
                }); ;

            modelBuilder.Entity<PortfolioImage>().HasData(
                new PortfolioImage
                {
                    Id = 10,
                    DisplayText = "Motorcycling is a big hobby of mine. As you scroll down, " +
                    "you will see more of my travels, what I like to do for fun," +
                    "and core pieces of who I am.",
                    FileName = "homebike3.jpg",
                    Name = "Fox Hoodie DET Home 3"
                });

            modelBuilder.Entity<PortfolioImage>().HasData(
                new PortfolioImage
                {
                    Id = 11,
                    DisplayText = "Auburn Hills is a beautiful area, with tons of activities and exciting opportunities.",
                    FileName = "homeauburnhills1.jpg",
                    Name = "AH DET Apt 1"
                });

            modelBuilder.Entity<PortfolioImage>().HasData(
                new PortfolioImage
                {
                    Id = 12,
                    DisplayText = "It can even snow in Auburn Hills when it's sunny out!",
                    FileName = "homeauburnhills2.jpg",
                    Name = "AH DET Apt 2"
                });

            modelBuilder.Entity<PortfolioImage>().HasData(
                new PortfolioImage
                {
                    Id = 13,
                    DisplayText = "The snow build up can be quite intense at times. " +
                    "That's when you take off traction control, and find an empty parking lot!",
                    FileName = "homeauburnhills3.jpg",
                    Name = "AH DET Apt 3"
                });

            modelBuilder.Entity<PortfolioImage>().HasData(
                new PortfolioImage
                {
                    Id = 14,
                    DisplayText = "Crossing the Upper Peninsula of Michigan on a sport-bike is wild! " +
                    "The middle connection is grated, leaving you with an intimidating view looking down! It's worth it just to see all Michigan offers.",
                    FileName = "homedancininseptemba1.jpg",
                    Name = "CA Work Warehouse 1"
                });

            modelBuilder.Entity<PortfolioImage>().HasData(
                new PortfolioImage
                {
                    Id = 15,
                    DisplayText = "I decided to buy a dirt-bike and assemble it from Amazon. Seriously. " +
                    "Would not recommend! Fun building it and ripping around the dunes. One day I'll buy a real YZ250/450f.",
                    FileName = "homedirtbike1.jpg",
                    Name = "Desktop MI AH Bike 2"
                });

            modelBuilder.Entity<PortfolioImage>().HasData(
                new PortfolioImage
                {
                    Id = 16,
                    DisplayText = "Finishing the assembly was a joy, I ultimately replaced the carb with a newer custom higher throughput one. " +
                    "This noticeably increased the BHP by about 10%.",
                    FileName = "homedirtbike2.jpg",
                    Name = "Desktop MI AH Bike 2"
                });

            modelBuilder.Entity<PortfolioImage>().HasData(
                new PortfolioImage
                {
                    Id = 17,
                    DisplayText = "I am a big fan of Columbian espresso. Cafe La Llave is the best! " +
                    "Would add some French Vanilla at the end of preparation for a perfect treat! ",
                    FileName = "homeespresso1.jpg",
                    Name = "Desktop MI Espresso AH 1"
                });

            modelBuilder.Entity<PortfolioImage>().HasData(
                new PortfolioImage
                {
                    Id = 18,
                    DisplayText = "Gaming is in my blood! As a kid, I started getting into heavy back end programming with a title named Garry's Mod. " +
                    "Research TTT and look up WITD Server if curious!",
                    FileName = "homegaming1.jpg",
                    Name = "Gaming MI Halo 1"
                });

            modelBuilder.Entity<PortfolioImage>().HasData(
                new PortfolioImage
                {
                    Id = 19,
                    DisplayText = "StarCraft is my favorite game! It requires so much attention, and intense, quick multi-tasking proficiencies under stress. " +
                    "Something I consider myself skilled at, I love StarCraft even though some consider it too difficult to learn with all the casual titles out these days. " +
                    "Life is about mastering difficult things!",
                    FileName = "homegamingsc1.jpg",
                    Name = "Gaming MI Cuddles SC2 1"
                });

            modelBuilder.Entity<PortfolioImage>().HasData(
                new PortfolioImage
                {
                    Id = 20,
                    DisplayText = "Nothing like winding down with a beverage and some Dark Souls. " +
                    "Most challenging title I've every played with a controller by far! Dex builds know what's up!",
                    FileName = "homebikegaming3.jpg",
                    Name = "Gaming MI Dark Souls 1"
                });

            modelBuilder.Entity<PortfolioImage>().HasData(
                new PortfolioImage
                {
                    Id = 21,
                    DisplayText = "I used to take the scenic routes of Detroit after work, and just enjoy the sky. " +
                    "Nothing like the smell of the Earth's petrichor into a pleasant ride around town. Sure makes wheelies risky though!",
                    FileName = "homebikejoslyn1.jpg",
                    Name = "Motorcycling MI Joslyn 1"
                });

            modelBuilder.Entity<PortfolioImage>().HasData(
                new PortfolioImage
                {
                    Id = 22,
                    DisplayText = "Motorcycling with pals, and Baby Yoda sponsored FOX hoodies? Sign me up! " +
                    "I miss this hoodie and wish I could find a replacement. So many compliments with it!",
                    FileName = "homebikeyoda1.jpg",
                    Name = "Motorcycling MI Yoda 1"
                });

            modelBuilder.Entity<PortfolioImage>().HasData(
                new PortfolioImage
                {
                    Id = 23,
                    DisplayText = "I sort of enjoyed the experiences that COVID uniquely offered me. More room for motorcycles on the road; " +
                    "it was a great opportunity to improve my desktop, and enjoy a more balanced work-life from home at the same time. Win-win.",
                    FileName = "homedesk1.jpg",
                    Name = "Desk MI Signs 1"
                });

            modelBuilder.Entity<PortfolioImage>().HasData(
                new PortfolioImage
                {
                    Id = 24,
                    DisplayText = "The fam out here in NC is great! Nothing like spending time with those you love. " +
                    "From fishing, to driving to beautiful scenery, to concerts, we do it all!",
                    FileName = "homegroupnc1.jpg",
                    Name = "Home NC Group 1"
                });

            modelBuilder.Entity<PortfolioImage>().HasData(
                new PortfolioImage
                {
                    Id = 25,
                    DisplayText = "I really enjoy playing my guitar when I have the time to do so. " +
                    "One day I am sure I'll have a legendary guitar collection! *starts playing dear god by a7x*.",
                    FileName = "homeguitarpontiac1.jpg",
                    Name = "Desk MI Signs 1"
                });

            modelBuilder.Entity<PortfolioImage>().HasData(
                new PortfolioImage
                {
                    Id = 26,
                    DisplayText = "Michigan will probably always be 'home' to me; I was raised close to 9 mile " +
                    "and the streets here have definitely had a large influence on my life.",
                    FileName = "homemichigan1.jpg",
                    Name = "Home MI Sky 1"
                });

            modelBuilder.Entity<PortfolioImage>().HasData(
                new PortfolioImage
                {
                    Id = 27,
                    DisplayText = "I am a big fan of Bicycling! It's good exercise and I love to see new trails and new people who share " +
                    "the same hobby. Feels like you're part of a club or something sometimes..",
                    FileName = "homemichiganbike1.jpg",
                    Name = "Home MI Sky 1"
                });

            modelBuilder.Entity<PortfolioImage>().HasData(
                new PortfolioImage
                {
                    Id = 28,
                    DisplayText = "The beauty of Michigan is sometimes understated. You truly experience all seasons; the spring and fall feels " +
                    "like free air conditioning outside! It's great.",
                    FileName = "homemichiganboulevard1.jpg",
                    Name = "Home MI Sky 1"
                });


            modelBuilder.Entity<Game>().HasData(
                new Game { Id = 1, GameName = "Hangman", Preview = "hangman.png" });

            modelBuilder.Entity<Game>().HasData(
                new Game { Id = 2, GameName = "Simon Says", Preview = "simonsays.png" });



            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 1,
                    Name = "MauiTodos",
                    Language = "C# Maui",
                    Url = "https://github.com/DontDoThat21/NET7MauiWithSqliteTodos",
                    ProjectPhoto = "mauiTodos.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 2,
                    Name = "AngularEmployeeManager",
                    Language = "TypeScript, JS, C#",
                    Url = "https://github.com/DontDoThat21/Angular16",
                    ProjectPhoto = "angularEmployeeManager.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 3,
                    Name = "AngularAPI",
                    Language = "C#.NET FW",
                    Url = "https://github.com/DontDoThat21/WebAPI",
                    ProjectPhoto = "angularEmployeeDepartmentAPI.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 4,
                    Name = "HotSBot",
                    Language = "C#.NET FW",
                    Url = "https://github.com/DontDoThat21/HotSBot",
                    ProjectPhoto = "hotsBot.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 5,
                    Name = "Python Maze",
                    Language = "Python 3.11",
                    Url = "https://github.com/DontDoThat21/PythonMaze",
                    ProjectPhoto = "pythonMaze.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 6,
                    Name = "WinFormsTodos",
                    Language = "C#.NET FW",
                    Url = "https://github.com/DontDoThat21/NET7WinFormsWithSqliteTodos",
                    ProjectPhoto = "net7WinFormsSqlLiteTodos.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 7,
                    Name = "ModernDesignPizzaStore",
                    Language = "C#.NET Core WPF",
                    Url = "https://github.com/DontDoThat21/ModernDesignPizzaStore",
                    ProjectPhoto = "net7ModernWpf.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 8,
                    Name = "FlickrPhotoSearcher",
                    Language = "C#.NET FW",
                    Url = "https://github.com/DontDoThat21/PhotoSearcherFlickrAPI",
                    ProjectPhoto = "b.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 9,
                    Name = "FrameworkWebForms",
                    Language = "C#.NET FW",
                    Url = "https://github.com/DontDoThat21/FrameworkWebForms",
                    ProjectPhoto = "b.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 10,
                    Name = "CppCalculator",
                    Language = "C++",
                    Url = "https://github.com/DontDoThat21/TylorTrubCppCalculator",
                    ProjectPhoto = "cppCalculator.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 11,
                    Name = "BookOfGrudges",
                    Language = "C# MVC and JS",
                    Url = "https://github.com/DontDoThat21/WIP",
                    ProjectPhoto = "b.png"
                });

        }
        
    }
}
