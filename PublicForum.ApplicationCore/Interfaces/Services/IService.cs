using PublicForum.ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PublicForum.ApplicationCore.Interfaces.Services
{
    public interface IService<T> where T : Entity
    {
        T Add(T entity);
        Task<T> AddAsync(T entity);
        T Update(T entity);
        Task<T> UpdateAsync(T entity);
        void Delete(int id);
        Task DeleteAsync(int id);
        T Find(Expression<Func<T, bool>> match);
        Task<T> FindAsync(Expression<Func<T, bool>> match);
        ICollection<T> FindAll(Expression<Func<T, bool>> match);
        Task<ICollection<T>> FindAllAsync(Expression<Func<T, bool>> match);
        ICollection<T> FindAll(int offset, int limit);
        Task<ICollection<T>> FindAllAsync();
        T GetByID(int id);
        Task<T> GetByIDAsync(int id);
    }
}
