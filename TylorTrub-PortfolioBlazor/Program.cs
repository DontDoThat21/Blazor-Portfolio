using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;
using TylorTrubPortfolioBlazor.Server.BL.Data;
using TylorTrubPortfolioBlazor.Server.BL.Services;
using Toolbelt.Blazor.Extensions.DependencyInjection;
using Fluxor;
using System.Reflection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Fluxor.Blazor.Web.ReduxDevTools;

namespace TylorTrubPortfolioBlazor
{
    public class Program()
    {
        public static IConfiguration Configuration { get; set; }

        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            
            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();           

            //builder.Services.AddDbContext<PortfolioDBContext>(options =>
            //  options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            // Disable database for demo purposes - just show UI migration
            // builder.Services.AddDbContext<PortfolioDBContext>(options =>
            //     options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            // Disable Identity for demo purposes - just show UI migration
            // builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<PortfolioDBContext>().AddDefaultTokenProviders();
            // builder.Services.ConfigureApplicationCookie(options =>
            // {
            //     options.LoginPath = $"/Identity/Account/Login";
            //     options.LogoutPath = $"/Identity/Account/Logout";
            //     options.AccessDeniedPath = $"/Identity/Account/AccessDenied";
            // });

            // Disable all database-dependent services for demo purposes
            // builder.Services.AddScoped<IPortfolioImagesService, PortfolioImagesService>();
            // builder.Services.AddScoped<IProjectsService, ProjectsService>();
            // builder.Services.AddScoped<IMotorcycleVideosService, MotorcycleVideosService>();
            // builder.Services.AddScoped<IMotorcyclesService, MotorcyclesService>();
            // builder.Services.AddScoped<IProductsService, ProductsService>();
            // builder.Services.AddScoped<IGamesService, GamesService>();
            // builder.Services.AddScoped<ICompaniesService, CompaniesService>();
            // builder.Services.AddScoped<ICategoriesService, CategoriesService>();

            // builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            // builder.Services.AddScoped<TylorTrubPortfolio.Client.BL.IEmailSender, TylorTrubPortfolio.Client.BL.EmailSender>();

            builder.Services.AddRazorComponents().AddInteractiveServerComponents();
            builder.Services.AddCascadingAuthenticationState();
            builder.Services.AddHotKeys2();

            builder.Services.AddFluxor(options =>
            {
                options.ScanAssemblies(Assembly.GetExecutingAssembly());
                options.UseReduxDevTools();
            });

            builder.Services.AddHttpContextAccessor();

            builder.Services.Configure<ForwardedHeadersOptions>(options =>
            {
                options.ForwardedHeaders =
                    ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto;
            });

            var app = builder.Build();
            
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            
            app.UseRouting();
            
            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");
            
            app.Run();
        }
    }
}

