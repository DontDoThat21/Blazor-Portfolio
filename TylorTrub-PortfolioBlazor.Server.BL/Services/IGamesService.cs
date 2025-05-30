﻿using TylorTrubPortfolioBlazor.DTO.Models;

namespace TylorTrubPortfolioBlazor.Server.BL.Services
{
    public interface IGamesService : IService<Game>
    {
        Task<List<Game>> FetchGamesAsync();
    }
}
