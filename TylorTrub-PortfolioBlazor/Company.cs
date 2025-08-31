using System;
using System.Collections.Generic;

namespace TylorTrubPortfolioBlazor.UI;

public partial class Company
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? StreetAddress { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? PostalCode { get; set; }

    public string? PhoneNumber { get; set; }

    public virtual ICollection<AspNetUser> AspNetUsers { get; set; } = new List<AspNetUser>();
}
