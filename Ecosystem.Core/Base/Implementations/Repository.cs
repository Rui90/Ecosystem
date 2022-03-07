using Core.Entitities;
using Ecosystem.Core.Base.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Ecosystem.Core.Base.Implementations
{
    public class Repository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly DbContext Context;
        public Repository(DbContext context)
        {
            Context = context;
        }

        public T Create(T entity)
        {
            entity.Id = Guid.NewGuid();
            entity.CreatedAt = DateTime.UtcNow;
            Context.Add(entity);
            Context.SaveChanges();
            return entity;
        }

        public void Delete(Guid id)
        {
            try
            {
                Context.Remove(GetById(id));
                Context.SaveChanges();
            } catch(Exception ex)
            {
                throw;
            }

        }

        public PaginatedViewModel<T> GetAll(int currentPage, int pageSize, params Expression<Func<T, object>>[] includes)
        {
            var counter = Context.Set<T>().Count();
            var entries = GetQueryable(includes)
                .OrderBy(x => x.CreatedAt)
                .Skip(currentPage)
                .Take(pageSize);

            return new PaginatedViewModel<T>(entries.ToList(), counter);
        }

        public T GetById(Guid id, params Expression<Func<T, object>>[] includes)
        {
            return GetQueryable(includes).First(x => x.Id == id);
        }

        public IQueryable<T> GetQuery(params Expression<Func<T, object>>[] includes)
        {
            var queryable = Context.Set<T>().AsQueryable();
            return includes != null && includes.Any() ? includes.Aggregate(queryable, (current, include) => current.Include(include)) : queryable;
        }

        public T Update(T entity)
        {
            Context.Update(entity); 
            Context.SaveChanges();
            return entity;
        }

        public IQueryable<T> GetQueryable(params Expression<Func<T, object>>[] includes)
        {
            var set = Context.Set<T>();
            IQueryable<T> queryable = null;
            foreach (var include in includes)
            {
                queryable = set.Include(include);
            }
            return queryable ?? set;
        }

        #region Interface IDisposable

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                Context?.Dispose();
            }
        }

        #endregion
    }
}
