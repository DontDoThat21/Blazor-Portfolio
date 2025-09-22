using Microsoft.EntityFrameworkCore;
using Portfolio.Server.BL.Repository;
using PortfolioBlazor.DTO.Models;
using PortfolioBlazor.Server.BL.Data;

namespace PortfolioBlazor.Server.BL.Services
{
    public class CompaniesService : Service<Company>, ICompaniesService
    {
        private readonly PortfolioDBContext dbContext;

        public CompaniesService(PortfolioDBContext dBContext) : base(dBContext)
        {
            this.dbContext = dBContext;
        }

        public async Task<List<Company>> FetchCompaniesAsync()
        {
            var companies = await dbContext.Companies.ToListAsync();

            return companies;
        }
    }
}
