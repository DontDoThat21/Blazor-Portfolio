using PortfolioBlazor.DTO.Models;

namespace PortfolioBlazor.Server.BL.Services
{
    public interface IProductsService : IService<Product>
    {
        Task<List<Product>> FetchProductsAsync();
        Task<Product> FetchProductAsync(int productId);
    }
}
