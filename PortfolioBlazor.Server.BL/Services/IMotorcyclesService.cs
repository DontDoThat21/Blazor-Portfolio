using PortfolioBlazor.DTO.Models;

namespace PortfolioBlazor.Server.BL.Services
{
    public interface IMotorcyclesService : IService<Motorcycle>
    {
        Task<List<Motorcycle>> FetchMotorcyclesAsync();
        Task<Motorcycle> FetchMotorcycleAsync(int motorcycleId);
    }
}
