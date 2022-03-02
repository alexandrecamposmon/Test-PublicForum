using Microsoft.EntityFrameworkCore;
using PublicForum.ApplicationCore.Interfaces.Repository;
using PublicForum.ApplicationCore.Models;
using PublicForum.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PublicForum.Infrastructure.Repository
{
    public abstract class Repository<T> : IRepository<T> where T : Entity, new()
    {
        protected readonly ChallengeContext Db;
        protected readonly DbSet<T> DbSet;

        protected Repository(ChallengeContext db)
        {
            Db = db;
            DbSet = db.Set<T>();
        }

        public virtual T Add(T entity)
        {
            DbSet.Add(entity);
            Db.SaveChanges();
            return entity;
        }

        public virtual async Task<T> AddAsync(T entity)
        {
            DbSet.Add(entity);
            await Db.SaveChangesAsync();
            return entity;
        }

        public virtual T Update(T entity)
        {
            DbSet.Update(entity);
            Db.SaveChanges();
            return entity;
        }

        public virtual async Task<T> UpdateAsync(T entity)
        {
            DbSet.Update(entity);
            await Db.SaveChangesAsync();
            return entity;
        }

        public virtual void Delete(int id)
        {
            DbSet.Remove(new T { Id = id });
            Db.SaveChanges();
        }

        public virtual async Task DeleteAsync(int id)
        {
            DbSet.Remove(new T { Id = id });
            await Db.SaveChangesAsync();
        }
        public T Find(Expression<Func<T, bool>> predicate)
        {
            return DbSet.AsNoTracking().Where(predicate).FirstOrDefault();
        }
        public async Task<T> FindAsync(Expression<Func<T, bool>> predicate)
        {
            return await DbSet.AsNoTracking().Where(predicate).FirstOrDefaultAsync();
        }

        public ICollection<T> FindAll(Expression<Func<T, bool>> predicate)
        {
            return DbSet.AsNoTracking().Where(predicate).ToList();
        }
        public async Task<ICollection<T>> FindAllAsync(Expression<Func<T, bool>> predicate)
        {
            return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
        }

        public virtual ICollection<T> FindAll(int offset, int limit)
        {
            var entities = DbSet.ToList();
            if (entities == null)
            {
                return entities;
            }

            return entities.Skip(offset).Take(limit).ToList();
        }

        public virtual async Task<ICollection<T>> FindAllAsync()
        {
            return await DbSet.ToListAsync();
        }

        public virtual T EncontrarPorID(int id)
        {
            return DbSet.Find(id);
        }

        public virtual async Task<T> GetByIDAsync(int id)
        {
            return await DbSet.FindAsync(id);
        }

        public T GetByID(int id)
        {
            return DbSet.Find(id);
        }

        public async Task<int> SaveChanges()
        {
            return await Db.SaveChangesAsync();
        }

        public void Dispose()
        {
            Db?.Dispose();
        }
    }
}
