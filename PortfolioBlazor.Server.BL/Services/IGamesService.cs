using PortfolioBlazor.DTO.Models;

namespace PortfolioBlazor.Server.BL.Services
{
    public interface IGamesService : IService<Game>
    {
        Task<List<Game>> FetchGamesAsync();
    }
}
