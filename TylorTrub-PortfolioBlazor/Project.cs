using System;
using System.Collections.Generic;

namespace TylorTrubPortfolioBlazor.UI;

public partial class Project
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Url { get; set; } = null!;

    public string ProjectPhoto { get; set; } = null!;

    public string Language { get; set; } = null!;
}
