using PortfolioBlazor.DTO.Models;

namespace PortfolioBlazor.Server.BL.Services
{
    public interface ICartsService : IService<ShoppingCartBundle>
    {
        Task<List<ShoppingCartBundle>> FetchCartsAsync();
    }
}
