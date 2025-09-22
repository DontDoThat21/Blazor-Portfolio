using System;
using System.Collections.Generic;

namespace PortfolioBlazor.UI;

public partial class ShoppingCart
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int Count { get; set; }

    public string ApplicationUserId { get; set; } = null!;

    public virtual AspNetUser ApplicationUser { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
