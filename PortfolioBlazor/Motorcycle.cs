using System;
using System.Collections.Generic;

namespace PortfolioBlazor.UI;

public partial class Motorcycle
{
    public int Id { get; set; }

    public string MotorcycleName { get; set; } = null!;

    public int? MotorcycleCc { get; set; }

    public string Manufacturer { get; set; } = null!;

    public string? Hp { get; set; }

    public byte? Year { get; set; }

    public string? EngineStyle { get; set; }

    public string? Torque { get; set; }

    public string? Brakes { get; set; }

    public string? Picture { get; set; }

    public DateTime AddDate { get; set; }
}
