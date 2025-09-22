using Microsoft.EntityFrameworkCore;
using Portfolio.Server.BL.Repository;
using PortfolioBlazor.DTO.Models;
using PortfolioBlazor.Server.BL.Data;

namespace PortfolioBlazor.Server.BL.Services
{
    public class ProductsService : Service<Product>, IProductsService
    {
        private readonly PortfolioDBContext dbContext;

        public ProductsService(PortfolioDBContext dBContext) : base(dBContext)
        {
            this.dbContext = dBContext;
        }

        public async Task<List<Product>> FetchProductsAsync()
        {
            var products = await dbContext.Products.ToListAsync();

            return products;
        }
        
        public async Task<Product> FetchProductAsync(int productId)
        {
            //Motorcycle motorcycle = (Motorcycle)await dbContext.FindAsync(motorcycleId);
            //return motorcycle;

            return await dbContext.Products.FindAsync(productId);
        }
    }
}
