using System;
using System.Collections.Generic;

namespace PortfolioBlazor.UI;

public partial class Game
{
    public int Id { get; set; }

    public string GameName { get; set; } = null!;

    public string Preview { get; set; } = null!;
}
