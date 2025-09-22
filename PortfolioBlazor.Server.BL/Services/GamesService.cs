using Microsoft.EntityFrameworkCore;
using Portfolio.Server.BL.Repository;
using PortfolioBlazor.DTO.Models;
using PortfolioBlazor.Server.BL.Data;

namespace PortfolioBlazor.Server.BL.Services
{
    public class GamesService : Service<Game>, IGamesService
    {
        private readonly PortfolioDBContext dbContext;

        public GamesService(PortfolioDBContext dBContext) : base(dBContext)
        {
            this.dbContext = dBContext;
        }

        public async Task<List<Game>> FetchGamesAsync()
        {
            var games = await dbContext.Games.ToListAsync();

            return games;
        }
    }
}
