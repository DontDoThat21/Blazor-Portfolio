using PortfolioBlazor.DTO.Models;

namespace PortfolioBlazor.Server.BL.Services
{
    public interface IProjectsService : IService<Project>
    {
        Task<List<Project>> FetchProjectsAsync();
    }
}
