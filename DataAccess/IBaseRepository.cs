﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IBaseRepository<T> where T : class,IEntity,new()
    {
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T,bool>>filter=null);
        Task<T> GetAsync(Expression<Func<T,bool>>filter);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<bool> DeleteAsync(int id);
    }
}
