﻿using System.Linq.Expressions;
using Project.Core.Models;

namespace Project.Core.Repositories
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(int id);
        IQueryable<T> GetAll(Expression<Func<T, bool>> exp);
        IQueryable<T> Where(Expression<Func<T,bool>> exp);
        Task<bool> AnyAsync(Expression<Func<T, bool>> exp);
        Task AddAsync(T entity);
        void Update(T entity);
        void Remove(T entity);

    }
}