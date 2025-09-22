using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Security.Claims;
using Portfolio.Server.BL.Repository;
using PortfolioBlazor.DTO.Models;
using PortfolioBlazor.DTO.ViewModels;
using PortfolioBlazor.Server.BL.Data;

namespace PortfolioBlazor.Server.BL.Services
{
    public class CartsService : Service<ShoppingCartBundle>, ICartsService
    {
        private readonly PortfolioDBContext dbContext;

        public CartsService(PortfolioDBContext dBContext) : base(dBContext)
        {
            this.dbContext = dBContext;
        }

        public ShoppingCartBundle bundles { get; set; }


        public async Task<List<ShoppingCartBundle>> FetchCartsAsync()
        {
            return null;
            //var claimsIdentity = (ClaimsIdentity)User.Identity;
            //var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;

            bundles = new()
            {
                //ShoppingCartList = dbContext.ShoppingCarts.GetAll(u => u.ApplicationUserId == userId,
                //includeProperties: "Product"),
                //OrderHeader = new()
            };

            //IEnumerable<ProductImage> productImages = _unitOfWork.ProductImage.GetAll();

            foreach (var cart in bundles.ShoppingCartList)
            {
                //cart.Product.ProductImages = productImages.Where(u => u.ProductId == cart.Product.Id).ToList();
                //cart.Price = GetPriceBasedOnQuantity(cart);
                bundles.OrderHeader.OrderTotal += (cart.Price * cart.Count);
            }

            //return View(bundles);
        }

        //IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, string? includeProperties = null);

    }
}
