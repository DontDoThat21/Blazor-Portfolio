using PortfolioBlazor.DTO.Models;

namespace PortfolioBlazor.Server.BL.Services
{
    public interface ICompaniesService : IService<Company>
    {
        Task<List<Company>> FetchCompaniesAsync();
    }
}
