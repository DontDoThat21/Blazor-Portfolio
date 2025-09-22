using System;
using System.Collections.Generic;

namespace PortfolioBlazor.UI;

public partial class OrderDetail
{
    public int Id { get; set; }

    public int OrderHeaderId { get; set; }

    public int ProductId { get; set; }

    public int Count { get; set; }

    public double Price { get; set; }

    public virtual OrderHeader OrderHeader { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
