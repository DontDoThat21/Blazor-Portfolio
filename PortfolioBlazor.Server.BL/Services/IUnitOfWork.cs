using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioBlazor.Server.BL.Services
{
    public interface IUnitOfWork
    {
        ICategoriesService Categories { get; }
        IProductsService Products { get; }
        IMotorcyclesService Motorcycles { get; }
        ICartsService ShoppingCarts { get; }

        //IApplicationUsersService ApplicationUser { get; }

        IMotorcycleVideosService MotorcycleVideos { get; }
        IPortfolioImagesService PortfolioImages { get; }
        IProductsService ProductImages { get; }
        ICompaniesService Companies { get; }
        IGamesService Games { get; }
        //IOrdersService aka IOrderDetailRepository OrderDetails { get; }

        //IOrderHeaderRepository OrderHeaders { get; }
        IProjectsService Projects { get; }
    }
}
