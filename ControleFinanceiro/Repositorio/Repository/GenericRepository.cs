using Repository.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Repository.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private IDataContext context { get; set; }

        public GenericRepository(IDataContext context)
        {
            this.context = context;
        }

        public IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate, String[] include)
        {
            //TODO: Adicionar pesquisa com include
            return context.DbSet<TEntity>().Where(predicate);
        }

        public virtual TEntity GetByID(object id)
        {
            return context.DbSet<TEntity>().Find(id);
        }

        public void add(TEntity model)
        {
            context.DbSet<TEntity>().Add(model);
        }

        public void Update(TEntity model)
        {
            context.DbSet<TEntity>().Attach(model);
        }

        public void Delete(object id)
        {
            var entityToDelete = context.DbSet<TEntity>().Find(id);
            Delete(entityToDelete);
        }

        public void Delete(TEntity model)
        {
            context.DbSet<TEntity>().Remove(model);
        }

        public Int64 Commit()
        {
            return context.SaveChanges();
        }
    }
}