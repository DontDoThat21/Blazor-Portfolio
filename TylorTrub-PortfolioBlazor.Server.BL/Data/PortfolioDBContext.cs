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
                    DisplayText = "I have managed and upgraded software systems in Los Angeles, Tennessee, and Detroit." +
                    " Warehousing software work and various improvements ranges from the initial definition of what is included in a show," +
                    " to the logistical transportation of goods to the show itself all through intranet software.",
                    FileName = "home1.jpg",
                    Name = "LA Flight View Home 1"
                });

            modelBuilder.Entity<PortfolioImage>().HasData(
               new PortfolioImage
               {
                   Id = 2,
                   DisplayText = "Working closely with shop carpenters and foreman," +
                   " creating tailored applications was an exciting opportunity to growas a developer," +
                   " and as a solutions architect.",
                   FileName = "homecawork2.jpg",
                   Name = "CA Work Warehouse 1"
               });

            modelBuilder.Entity<PortfolioImage>().HasData(
               new PortfolioImage
               {
                   Id = 3,
                   DisplayText = "I maintained, improved, and created paint management software as a developer," +
                   " and as a solutions architect.",
                   FileName = "homemiwork1.jpg",
                   Name = "MI Work Paint 1"
               });

            modelBuilder.Entity<PortfolioImage>().HasData(
                new PortfolioImage
                {
                    Id = 4,
                    DisplayText = "I've built many desktops, but this has to be my most nostalgic build." +
                    " A roughly rummaged together yet powerful machine to get the job done well is sometimes all it takes!",
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
                    DisplayText = "As a teen, I moved to North Carolina with my family to finish school " +
                    "and continue my education towards being a software developer. " +
                    "NC being known for it's hills, I was an avid skateboarder.",
                    FileName = "home2.jpg",
                    Name = "Home 2"
                }); ;

            modelBuilder.Entity<PortfolioImage>().HasData(
                new PortfolioImage
                {
                    Id = 10,
                    DisplayText = "Motorcycling is a big hobby of mine. " +
                    "As you scroll down, you will see more of my travels, what I like to do for fun, " +
                    "including pieces of who I am.",
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
                    "The middle connection is grated, leaving you with an intimidating view looking down! " +
                    "It's worth it just to see all Michigan offers.",
                    FileName = "homedancininseptemba1.jpg",
                    Name = "CA Work Warehouse 1"
                });

            modelBuilder.Entity<PortfolioImage>().HasData(
                new PortfolioImage
                {
                    Id = 15,
                    DisplayText = "I decided to buy a dirt-bike and assemble it from Amazon. Seriously. " +
                    "Fun building it and ripping around a few hills.",
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
                    DisplayText = "Gaming is in my blood! As a kid, I started getting into " +
                    "heavy back end programming with a title named Garry's Mod. " +
                    "Research TTT and look up WITD Server if curious!",
                    FileName = "homegaming1.jpg",
                    Name = "Gaming MI Halo 1"
                });

            modelBuilder.Entity<PortfolioImage>().HasData(
                new PortfolioImage
                {
                    Id = 19,
                    DisplayText = "StarCraft is my favorite game! It requires so much attention, and intense," +
                    " quick multi-tasking proficiencies while under stress." +
                    " Life is all about mastering the challenging! ",
                    FileName = "homegamingsc1.jpg",
                    Name = "Gaming MI Cuddles SC2 1"
                });

            modelBuilder.Entity<PortfolioImage>().HasData(
                new PortfolioImage
                {
                    Id = 20,
                    DisplayText = "Nothing like winding down with a beverage and some Dark Souls." +
                    " Most challenging title I've every played with a controller by far!" +
                    " Dex builds know what's up!",
                    FileName = "homebikegaming3.jpg",
                    Name = "Gaming MI Dark Souls 1"
                });

            modelBuilder.Entity<PortfolioImage>().HasData(
                new PortfolioImage
                {
                    Id = 21,
                    DisplayText = "I used to take the scenic routes of Detroit after work, and just enjoy the vibes." +
                    " Nothing like the smell of the Earth's petrichor into a pleasant ride around town." +
                    " Sure makes wheelies risky though!",
                    FileName = "homebikejoslyn1.jpg",
                    Name = "Motorcycling MI Joslyn 1"
                });

            modelBuilder.Entity<PortfolioImage>().HasData(
                new PortfolioImage
                {
                    Id = 22,
                    DisplayText = "Nothing like going on a group ride with your pals. + Dibs on the baby yoda merch.",
                    FileName = "homebikeyoda1.jpg",
                    Name = "Motorcycling MI Yoda 1"
                });

            modelBuilder.Entity<PortfolioImage>().HasData(
                new PortfolioImage
                {
                    Id = 23,
                    DisplayText = "COVID offered me less trafic, more isolation to ride after hours." +
                    " More room for motorcycles on the road; it was a great opportunity to improve my desktop," +
                    " and enjoy a more balanced work-life from home at the same time. Win-win.",
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
                    DisplayText = "I enjoy playing guitar. *starts playing dear god by a7x*.",
                    FileName = "homeguitarpontiac1.jpg",
                    Name = "Desk MI Signs 1"
                });

            modelBuilder.Entity<PortfolioImage>().HasData(
                new PortfolioImage
                {
                    Id = 26,
                    DisplayText = "Michigan will always be 'home' to me; miss those days.",
                    FileName = "homemichigan1.jpg",
                    Name = "Home MI Sky 1"
                });

            modelBuilder.Entity<PortfolioImage>().HasData(
                new PortfolioImage
                {
                    Id = 27,
                    DisplayText = "Big fan of Bicycling! I love to see new trails.",
                    FileName = "homemichiganbike1.jpg",
                    Name = "Home MI Sky 1"
                });

            modelBuilder.Entity<PortfolioImage>().HasData(
                new PortfolioImage
                {
                    Id = 28,
                    DisplayText = "The beauty of Michigan is truly understated. You experience all the seasons; the spring and fall mesh in harmony.",
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
                    Name = "FlickrPhotoSearcher", 
                    Language = "C#.NET FW",
                    Url = "https://github.com/DontDoThat21/PhotoSearcherFlickrAPI",
                    ProjectPhoto = "flickrImageSearcher.png"
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

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 57,
                    Name = "AIChess",
                    Language = "Python, JavaScript",
                    Url = "https://github.com/DontDoThat21/AIChess.git",
                    ProjectPhoto = "aiChess.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 58,
                    Name = "AlgorithmPractice",
                    Language = "C++, Python, Java",
                    Url = "https://github.com/DontDoThat21/AlgorithmPractice.git",
                    ProjectPhoto = "algorithmPractice.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 59,
                    Name = "Angular16EmployeeDepartment",
                    Language = "TypeScript, HTML, CSS",
                    Url = "https://github.com/DontDoThat21/Angular16EmployeeDepartment.git",
                    ProjectPhoto = "angular16EmployeeDepartment.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 60,
                    Name = "Angular18Calculator",
                    Language = "TypeScript, HTML, CSS",
                    Url = "https://github.com/DontDoThat21/Angular18Calculator.git",
                    ProjectPhoto = "angular18Calculator.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 61,
                    Name = "ArduinoMatrix",
                    Language = "C++, Arduino",
                    Url = "https://github.com/DontDoThat21/ArduinoMatrix.git",
                    ProjectPhoto = "arduinoMatrix.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 62,
                    Name = "ArticleCleaner",
                    Language = "Python, JavaScript",
                    Url = "https://github.com/DontDoThat21/ArticleCleaner.git",
                    ProjectPhoto = "articleCleaner.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 63,
                    Name = "ATBGE-GUI",
                    Language = "C#, WinForms",
                    Url = "https://github.com/DontDoThat21/ATBGE-GUI.git",
                    ProjectPhoto = "atbgeGui.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 64,
                    Name = "BankManagementSystem",
                    Language = "Java, SQL",
                    Url = "https://github.com/DontDoThat21/BankManagementSystem.git",
                    ProjectPhoto = "bankManagementSystem.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 65,
                    Name = "Blazor-Portfolio",
                    Language = "C#, Blazor, HTML, CSS",
                    Url = "https://github.com/DontDoThat21/Blazor-Portfolio.git",
                    ProjectPhoto = "blazorPortfolio.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 66,
                    Name = "BookOfGrudges",
                    Language = "C#.NET",
                    Url = "https://github.com/DontDoThat21/BookOfGrudges.git",
                    ProjectPhoto = "bookOfGrudges.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 67,
                    Name = "Calculator.WebAPI.NET-Core",
                    Language = "C#.NET Core",
                    Url = "https://github.com/DontDoThat21/Calculator.WebAPI.NET-Core.git",
                    ProjectPhoto = "calculatorWebApiNetCore.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 68,
                    Name = "Capstone",
                    Language = "C#, SQL",
                    Url = "https://github.com/DontDoThat21/Capstone.git",
                    ProjectPhoto = "capstone.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 69,
                    Name = "ChromeBorderlessVideoExtension",
                    Language = "JavaScript, HTML, CSS",
                    Url = "https://github.com/DontDoThat21/ChromeBorderlessVideoExtension.git",
                    ProjectPhoto = "chromeBorderlessVideo.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 70,
                    Name = "ChromeVolumeController",
                    Language = "JavaScript, HTML, CSS",
                    Url = "https://github.com/DontDoThat21/ChromeVolumeController.git",
                    ProjectPhoto = "chromeVolumeController.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 71,
                    Name = "chromiumBorderlessVideos",
                    Language = "JavaScript, HTML, CSS",
                    Url = "https://github.com/DontDoThat21/chromiumBorderlessVideos.git",
                    ProjectPhoto = "chromiumBorderlessVideos.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 72,
                    Name = "chromiumSearchEngineRedirect",
                    Language = "JavaScript, HTML",
                    Url = "https://github.com/DontDoThat21/chromiumSearchEngineRedirect.git",
                    ProjectPhoto = "chromiumSearchEngineRedirect.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 73,
                    Name = "ClassicWindowsDesktop",
                    Language = "C#, WinForms",
                    Url = "https://github.com/DontDoThat21/ClassicWindowsDesktop.git",
                    ProjectPhoto = "classicWindowsDesktop.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 74,
                    Name = "ConsoleInsiderListener",
                    Language = "C#.NET",
                    Url = "https://github.com/DontDoThat21/ConsoleInsiderListener.git",
                    ProjectPhoto = "consoleInsiderListener.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 75,
                    Name = "CppCalculator",
                    Language = "C++",
                    Url = "https://github.com/DontDoThat21/CppCalculator.git",
                    ProjectPhoto = "cppCalculator.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 76,
                    Name = "CS2RecoilHelper",
                    Language = "C++, C#",
                    Url = "https://github.com/DontDoThat21/CS2RecoilHelper.git",
                    ProjectPhoto = "cs2RecoilHelper.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 77,
                    Name = "Director",
                    Language = "C#.NET",
                    Url = "https://github.com/DontDoThat21/Director.git",
                    ProjectPhoto = "director.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 78,
                    Name = "DontsLLM",
                    Language = "Python, TensorFlow",
                    Url = "https://github.com/DontDoThat21/DontsLLM.git",
                    ProjectPhoto = "dontsLLM.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 79,
                    Name = "DreamKeeper",
                    Language = "C#, SQL",
                    Url = "https://github.com/DontDoThat21/DreamKeeper.git",
                    ProjectPhoto = "dreamKeeper.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 80,
                    Name = "FlickrImageSearcher",
                    Language = "C#, API",
                    Url = "https://github.com/DontDoThat21/FlickrImageSearcher.git",
                    ProjectPhoto = "flickrImageSearcher.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 81,
                    Name = "FrameworkWebForms",
                    Language = "C#.NET Framework, ASP.NET",
                    Url = "https://github.com/DontDoThat21/FrameworkWebForms.git",
                    ProjectPhoto = "frameworkWebForms.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 82,
                    Name = "GithubIssueManager",
                    Language = "C#, GitHub API",
                    Url = "https://github.com/DontDoThat21/GithubIssueManager.git",
                    ProjectPhoto = "githubIssueManager.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 83,
                    Name = "HighlightsVault",
                    Language = "JavaScript, HTML, CSS",
                    Url = "https://github.com/DontDoThat21/HighlightsVault.git",
                    ProjectPhoto = "highlightsVault.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 84,
                    Name = "History",
                    Language = "JavaScript, HTML",
                    Url = "https://github.com/DontDoThat21/History.git",
                    ProjectPhoto = "history.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 85,
                    Name = "HomePage",
                    Language = "HTML, CSS, JavaScript",
                    Url = "https://github.com/DontDoThat21/HomePage.git",
                    ProjectPhoto = "homePage.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 86,
                    Name = "JapaneseLearner",
                    Language = "JavaScript, HTML, CSS",
                    Url = "https://github.com/DontDoThat21/JapaneseLearner.git",
                    ProjectPhoto = "japaneseLearner.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 87,
                    Name = "JavaSpringMVC-TodoApp",
                    Language = "Java, Spring MVC",
                    Url = "https://github.com/DontDoThat21/JavaSpringMVC-TodoApp.git",
                    ProjectPhoto = "javaSpringMvcTodoApp.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 88,
                    Name = "KernAccessorHelper",
                    Language = "C++, Windows Kernel",
                    Url = "https://github.com/DontDoThat21/KernAccessorHelper.git",
                    ProjectPhoto = "kernAccessorHelper.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 89,
                    Name = "Mcdonalds",
                    Language = "JavaScript, HTML, CSS",
                    Url = "https://github.com/DontDoThat21/Mcdonalds.git",
                    ProjectPhoto = "mcdonalds.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 90,
                    Name = "Muffle",
                    Language = "C#, Audio Processing",
                    Url = "https://github.com/DontDoThat21/Muffle.git",
                    ProjectPhoto = "muffle.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 91,
                    Name = "MySQL-Database-with-GUI",
                    Language = "Java, MySQL, Swing",
                    Url = "https://github.com/DontDoThat21/MySQL-Database-with-GUI.git",
                    ProjectPhoto = "mysqlDatabaseWithGui.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 92,
                    Name = "NETMauiWithSQLiteTodos",
                    Language = "C#, .NET MAUI, SQLite",
                    Url = "https://github.com/DontDoThat21/NETMauiWithSQLiteTodos.git",
                    ProjectPhoto = "netMauiWithSqliteTodos.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 93,
                    Name = "NETWinFormsWithSQLiteTodos",
                    Language = "C#, WinForms, SQLite",
                    Url = "https://github.com/DontDoThat21/NETWinFormsWithSQLiteTodos.git",
                    ProjectPhoto = "netWinFormsWithSqliteTodos.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 94,
                    Name = "OBD.NET",
                    Language = "C#.NET, OBD-II",
                    Url = "https://github.com/DontDoThat21/OBD.NET.git",
                    ProjectPhoto = "obdNet.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 95,
                    Name = "OpenAITranscribing",
                    Language = "Python, OpenAI API",
                    Url = "https://github.com/DontDoThat21/OpenAITranscribing.git",
                    ProjectPhoto = "openAiTranscribing.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 96,
                    Name = "PolarnOranges",
                    Language = "C#.NET",
                    Url = "https://github.com/DontDoThat21/PolarnOranges.git",
                    ProjectPhoto = "polarnOranges.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 97,
                    Name = "PowerKeys",
                    Language = "C#, Windows API",
                    Url = "https://github.com/DontDoThat21/PowerKeys.git",
                    ProjectPhoto = "powerKeys.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 98,
                    Name = "PythonMaze",
                    Language = "Python",
                    Url = "https://github.com/DontDoThat21/PythonMaze.git",
                    ProjectPhoto = "pythonMaze.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 99,
                    Name = "QuickKeys",
                    Language = "C#, Windows API",
                    Url = "https://github.com/DontDoThat21/QuickKeys.git",
                    ProjectPhoto = "quickKeys.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 100,
                    Name = "Redactor",
                    Language = "C#, Text Processing",
                    Url = "https://github.com/DontDoThat21/Redactor.git",
                    ProjectPhoto = "redactor.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 101,
                    Name = "Redliner",
                    Language = "C#.NET",
                    Url = "https://github.com/DontDoThat21/Redliner.git",
                    ProjectPhoto = "redliner.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 102,
                    Name = "RemoteLink",
                    Language = "C#, Networking",
                    Url = "https://github.com/DontDoThat21/RemoteLink.git",
                    ProjectPhoto = "remoteLink.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 103,
                    Name = "RestaurantJavaApplicationSQLite",
                    Language = "Java, SQLite",
                    Url = "https://github.com/DontDoThat21/RestaurantJavaApplicationSQLite.git",
                    ProjectPhoto = "restaurantJavaAppSqlite.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 104,
                    Name = "VB-TicTacToeGame",
                    Language = "Visual Basic .NET",
                    Url = "https://github.com/DontDoThat21/VB-TicTacToeGame.git",
                    ProjectPhoto = "vbTicTacToeGame.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 105,
                    Name = "WinFormsSquirrel",
                    Language = "C#, WinForms, Squirrel",
                    Url = "https://github.com/DontDoThat21/WinFormsSquirrel.git",
                    ProjectPhoto = "winFormsSquirrel.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 106,
                    Name = "WebAPI.NET-Core",
                    Language = "C#.NET Core, Web API",
                    Url = "https://github.com/DontDoThat21/WebAPI.NET-Core.git",
                    ProjectPhoto = "webApiNetCore.png"
                });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 107,
                    Name = "WebAPI.NET-FW",
                    Language = "C#.NET Framework, Web API",
                    Url = "https://github.com/DontDoThat21/WebAPI.NET-FW.git",
                    ProjectPhoto = "webApiNetFw.png"
                });
        }
        
    }
}
