using Microsoft.EntityFrameworkCore;
using Portfolio.Server.BL.Repository;
using PortfolioBlazor.DTO.Models;
using PortfolioBlazor.Server.BL.Data;

namespace PortfolioBlazor.Server.BL.Services
{
    public class MotorcycleVideosService : Service<MotorcycleVideo>, IMotorcycleVideosService
    {
        private readonly PortfolioDBContext dbContext;

        public MotorcycleVideosService(PortfolioDBContext dBContext) : base(dBContext)
        {
            this.dbContext = dBContext;
        }

        public async Task<List<MotorcycleVideo>> FetchMotorcycleVideosAsync()
        {
            var motorcycleVideos = await dbContext.MotorcycleVideos.ToListAsync();

            return motorcycleVideos;
        }
    }
}
