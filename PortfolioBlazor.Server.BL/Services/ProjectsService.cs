using Microsoft.EntityFrameworkCore;
using Portfolio.Server.BL.Repository;
using PortfolioBlazor.DTO.Models;
using PortfolioBlazor.Server.BL.Data;

namespace PortfolioBlazor.Server.BL.Services
{
    public class ProjectsService : Service<Project>, IProjectsService
    {
        private readonly PortfolioDBContext dbContext;

        public ProjectsService(PortfolioDBContext dBContext) : base(dBContext)
        {
            this.dbContext = dBContext;
        }

        public async Task<List<Project>> FetchProjectsAsync()
        {
            var projects = await dbContext.Projects.ToListAsync();

            return projects;
        }
    }
}
