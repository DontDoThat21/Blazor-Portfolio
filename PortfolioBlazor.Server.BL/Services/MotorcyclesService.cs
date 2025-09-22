using Microsoft.EntityFrameworkCore;
using Portfolio.Server.BL.Repository;
using PortfolioBlazor.DTO.Models;
using PortfolioBlazor.Server.BL.Data;

namespace PortfolioBlazor.Server.BL.Services
{
    public class MotorcyclesService : Service<Motorcycle>, IMotorcyclesService
    {
        private readonly PortfolioDBContext dbContext;

        public MotorcyclesService(PortfolioDBContext dBContext) : base(dBContext)
        {
            this.dbContext = dBContext;
        }

        public async Task<List<Motorcycle>> FetchMotorcyclesAsync()
        {
            var motorcycles = await dbContext.Motorcycles.ToListAsync();

            return motorcycles;
        }
        
        public async Task<Motorcycle> FetchMotorcycleAsync(int motorcycleId)
        {
            //Motorcycle motorcycle = (Motorcycle)await dbContext.FindAsync(motorcycleId);
            //return motorcycle;

            return await dbContext.Motorcycles.FindAsync(motorcycleId);
        }
    }
}
