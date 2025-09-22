using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortfolioBlazor.Server.BL.Data;

namespace PortfolioBlazor.Server.BL.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private PortfolioDBContext _portfolioDBContext;
        public ICategoriesService Categories { get; private set; }
        public IProductsService Products { get; private set; }
        public IMotorcyclesService Motorcycles { get; private set; }
        public ICartsService ShoppingCarts { get; private set; }
        //public IApplicationUserRepository ApplicationUser { get; private set; }
        public IMotorcycleVideosService MotorcycleVideos { get; private set; }
        public IPortfolioImagesService PortfolioImages { get; private set; }
        public IProductsService ProductImages { get; private set; }
        public ICompaniesService Companies { get; private set; }
        public IGamesService Games { get; private set; }
        //public IOrderHeaderRepository OrderHeader { get; private set; }
        //public IOrderDetailRepository OrderDetail { get; private set; }
        public IProjectsService Projects { get; private set; }

        public UnitOfWork(PortfolioDBContext portfolioDb)
        {
            _portfolioDBContext = portfolioDb;

            Categories = new CategoriesService(_portfolioDBContext);
            Products = new ProductsService(_portfolioDBContext);
            Motorcycles = new MotorcyclesService(_portfolioDBContext);
            ShoppingCarts = new CartsService(_portfolioDBContext);
            //ApplicationUser = new ApplicationUserRepository(_portfolioDBContext);
            MotorcycleVideos = new MotorcycleVideosService(_portfolioDBContext);
            PortfolioImages = new PortfolioImagesService(_portfolioDBContext);
            Companies = new CompaniesService(_portfolioDBContext);
            Games = new GamesService(_portfolioDBContext);
            Projects = new ProjectsService(_portfolioDBContext);
            //OrderHeader = new OrderHeaderRepository(_portfolioDBContext);
            //OrderDetail = new OrderDetailRepository(_portfolioDBContext);
            ProductImages = new ProductsService(_portfolioDBContext);

        }

        public void Save()
        {
            _portfolioDBContext.SaveChanges();
        }
    }
}
