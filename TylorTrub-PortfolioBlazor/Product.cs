using System;
using System.Collections.Generic;

namespace TylorTrubPortfolioBlazor.UI;

public partial class Product
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Isbn { get; set; } = null!;

    public string Author { get; set; } = null!;

    public double ListPrice { get; set; }

    public double Price { get; set; }

    public double Price50 { get; set; }

    public double Price100 { get; set; }

    public int CategoryId { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual ICollection<ProductImage> ProductImages { get; set; } = new List<ProductImage>();

    public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; } = new List<ShoppingCart>();
}
