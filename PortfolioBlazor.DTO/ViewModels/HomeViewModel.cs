using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortfolioBlazor.DTO.Models;

namespace PortfolioBlazor.DTO.ViewModels
{
    public class HomeViewModel
    {
        public List<MotorcycleVideo> MotorcycleVideoList { get; set; }
        public List<PortfolioImage> PortfolioImageList { get; set; }

    }
}
