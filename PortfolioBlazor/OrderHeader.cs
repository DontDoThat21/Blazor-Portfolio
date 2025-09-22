using System;
using System.Collections.Generic;

namespace PortfolioBlazor.UI;

public partial class OrderHeader
{
    public int Id { get; set; }

    public string ApplicationUserId { get; set; } = null!;

    public DateTime OrderDate { get; set; }

    public DateTime ShippingDate { get; set; }

    public double OrderTotal { get; set; }

    public string? OrderStatus { get; set; }

    public string? PaymentStatus { get; set; }

    public string? TrackingNumber { get; set; }

    public string? Carrier { get; set; }

    public DateTime PaymentDate { get; set; }

    public DateTime PaymentDueDate { get; set; }

    public string? SessionId { get; set; }

    public string? PaymentIntentId { get; set; }

    public string PhoneNumber { get; set; } = null!;

    public string StreetAddress { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string PostalCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual AspNetUser ApplicationUser { get; set; } = null!;

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
