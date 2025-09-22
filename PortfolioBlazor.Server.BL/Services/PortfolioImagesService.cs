using Microsoft.EntityFrameworkCore;
using Portfolio.Server.BL.Repository;
using PortfolioBlazor.DTO.Models;
using PortfolioBlazor.Server.BL.Data;

namespace PortfolioBlazor.Server.BL.Services
{
    public class PortfolioImagesService : Service<PortfolioImage>, IPortfolioImagesService
    {
        private readonly PortfolioDBContext dbContext;

        public PortfolioImagesService(PortfolioDBContext dBContext) : base(dBContext)
        {
            this.dbContext = dBContext;
        }

        public async Task<List<PortfolioImage>> FetchPortfolioImagesAsync()
        {
            var pfImages = await dbContext.PortfolioImages.ToListAsync();

            return pfImages;
        }
    }
}
