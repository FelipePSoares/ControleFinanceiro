using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Repository.Repository.Contracts
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate, String[] include);

        TEntity GetByID(object id);

        void add(TEntity model);

        void Update(TEntity model);

        void Delete(object id);

        void Delete(TEntity model);

        Int64 Commit();
    }
}