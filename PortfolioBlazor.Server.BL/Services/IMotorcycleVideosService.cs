using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortfolioBlazor.DTO.Models;

namespace PortfolioBlazor.Server.BL.Services
{
    public interface IMotorcycleVideosService : IService<MotorcycleVideo>
    {
        Task<List<MotorcycleVideo>> FetchMotorcycleVideosAsync();
    }
}
