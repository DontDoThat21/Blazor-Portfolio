using Microsoft.EntityFrameworkCore;
using Portfolio.Server.BL.Repository;
using PortfolioBlazor.DTO.Models;
using PortfolioBlazor.Server.BL.Data;

namespace PortfolioBlazor.Server.BL.Services
{
    public class CategoriesService : Service<Category>, ICategoriesService
    {
        private readonly PortfolioDBContext dbContext;

        public CategoriesService(PortfolioDBContext dBContext) : base(dBContext)
        {
            this.dbContext = dBContext;
        }

        public async Task<List<Category>> FetchCategoriesAsync()
        {
            var categories = await dbContext.Categories.ToListAsync();

            return categories;
        }
    }
}
