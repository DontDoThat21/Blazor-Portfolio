using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using PortfolioBlazor.Server.BL.Data;
using PortfolioBlazor.Server.BL.Services;

namespace Portfolio.Server.BL.Repository
{
    public class Service<T> : IService<T> where T : class
    {
        private readonly PortfolioDBContext _portfolioDBContext;
        internal DbSet<T> dbSet;

        /// <summary>
        /// The motorcycle and portfolio DBs are separated intentionally.
        /// I don't see why they would logically be connected. Also, I like the challenge of
        /// juggling two context and seeing how .NET Core 8 handles it. Seems good!
        /// 
        /// Edit: No. No.. NO! :) The systems in question were connected and even normalization wise, logically related.
        /// Do not separate connected contexts. Consult a professional for real advice :)
        /// Later me (9/26/2025): ROFL ^
        /// </summary>
        /// <param name="db">Portfolio DB.</param> 
        public Service(DbContext db)
        {
            _portfolioDBContext = (PortfolioDBContext?)db;
            this.dbSet = _portfolioDBContext.Set<T>();
            _portfolioDBContext.Products.Include(u => u.Category).Include(u => u.CategoryId);
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public T Get(Expression<Func<T, bool>> filter, string? includeProperties = null, bool tracked = false)
        {
            IQueryable<T> query;
            if (tracked)
            {
                query = dbSet;

            }
            else
            {
                query = dbSet.AsNoTracking();
            }

            query = query.Where(filter);
            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var includeProp in includeProperties
                    .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }
            }
            return query.FirstOrDefault();

        }

        // Category, CategoryId
        public IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter, string? includeProperties = null)
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var includeProp in includeProperties
                    .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }
            }
            return query.ToList();
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            dbSet.RemoveRange(entity);
        }
        
    }
}
