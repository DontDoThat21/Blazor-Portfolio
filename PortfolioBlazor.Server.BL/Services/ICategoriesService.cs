using PortfolioBlazor.DTO.Models;

namespace PortfolioBlazor.Server.BL.Services
{
    public interface ICategoriesService : IService<Category>
    {
        Task<List<Category>> FetchCategoriesAsync();
    }
}
