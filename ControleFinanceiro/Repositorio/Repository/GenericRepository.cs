using Repository.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Repository.Repository
{
    public class GenericRepository<TEntity> : DataContext, IGenericRepository<TEntity> where TEntity : class
    {
        public IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate, String[] include)
        {
            //TODO: Adicionar pesquisa com include
            return this.DbSet<TEntity>().Where(predicate);
        }

        public virtual TEntity GetByID(object id)
        {
            return this.DbSet<TEntity>().Find(id);
        }

        public void add(TEntity model)
        {
            this.DbSet<TEntity>().Add(model);
        }

        public void Update(TEntity model)
        {
            this.DbSet<TEntity>().Attach(model);
        }

        public void Delete(object id)
        {
            var entityToDelete = this.DbSet<TEntity>().Find(id);
            Delete(entityToDelete);
        }

        public void Delete(TEntity model)
        {
            this.DbSet<TEntity>().Remove(model);
        }
    }
}