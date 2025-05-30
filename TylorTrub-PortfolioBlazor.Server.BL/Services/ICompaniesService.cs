﻿using TylorTrubPortfolioBlazor.DTO.Models;

namespace TylorTrubPortfolioBlazor.Server.BL.Services
{
    public interface ICompaniesService : IService<Company>
    {
        Task<List<Company>> FetchCompaniesAsync();
    }
}
