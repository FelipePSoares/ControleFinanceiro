using Repository.Repository.Contracts;
using System;
using System.Collections.Generic;

namespace Repository.Repository
{
    public class GenericRepository : DataContext, IGenericRepository 
    {
        public virtual IEnumerable<TEntity> GetAll<TEntity>() where TEntity : class
        {
            throw new NotImplementedException("TODO");
        }

        public virtual TEntity GetByID<TEntity>(object id) where TEntity : class
        {
            throw new NotImplementedException("TODO");
        }

        public void add<TEntity>(TEntity model) where TEntity : class
        {
            this.DbSet<TEntity>().Add(model);
        }

        public void Update<TEntity>(TEntity model) where TEntity : class
        {
            this.DbSet<TEntity>().Attach(model);
        }

        public void Delete<TEntity>(object id) where TEntity : class
        {
            var entityToDelete = this.DbSet<TEntity>().Find(id);
            Delete(entityToDelete);
        }

        public void Delete<TEntity>(TEntity model) where TEntity : class
        {
            this.DbSet<TEntity>().Remove(model);
        }
    }
}