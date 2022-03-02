using PublicForum.ApplicationCore.Interfaces.Repository;
using PublicForum.ApplicationCore.Interfaces.Services;
using PublicForum.ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PublicForum.ApplicationCore.Services
{
    public abstract class Service<T> : IService<T> where T : Entity
    {
        private readonly IRepository<T> repository;

        protected Service(IRepository<T> repository)
        {
            this.repository = repository;
        }

        public T Add(T entity)
        {
            return this.repository.Add(entity);
        }

        public Task<T> AddAsync(T entity)
        {
            return this.repository.AddAsync(entity);
        }

        public T Update(T entity)
        {
            return this.repository.Update(entity);
        }

        public Task<T> UpdateAsync(T entity)
        {
            return this.repository.UpdateAsync(entity);
        }

        public void Delete(int id)
        {
            this.repository.Delete(id);
        }

        public Task DeleteAsync(int id)
        {
            return this.repository.DeleteAsync(id);
        }

        public T Find(Expression<Func<T, bool>> match)
        {
            return this.repository.Find(match);
        }

        public Task<T> FindAsync(Expression<Func<T, bool>> match)
        {
            return this.repository.FindAsync(match);
        }

        public T GetByID(int id)
        {
            return this.repository.GetByID(id);
        }

        public Task<T> GetByIDAsync(int id)
        {
            return this.repository.GetByIDAsync(id);
        }

        public ICollection<T> FindAll(int offset, int limit)
        {
            return this.repository.FindAll(offset, limit);
        }

        public Task<ICollection<T>> FindAllAsync()
        {
            return this.repository.FindAllAsync();
        }

        public ICollection<T> FindAll(Expression<Func<T, bool>> match)
        {
            return this.repository.FindAll(match);
        }

        public Task<ICollection<T>> FindAllAsync(Expression<Func<T, bool>> match)
        {
            return this.repository.FindAllAsync(match);
        }
    }
}
