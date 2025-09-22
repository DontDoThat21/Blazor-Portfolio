using System;
using System.Collections.Generic;

namespace PortfolioBlazor.UI;

public partial class PortfolioImage
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string FileName { get; set; } = null!;

    public string DisplayText { get; set; } = null!;
}
