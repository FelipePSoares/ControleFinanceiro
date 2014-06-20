using System.Collections.Generic;

namespace Repository.Repository.Contracts
{
    public interface IGenericRepository
    {
        IEnumerable<TEntity> GetAll<TEntity>() where TEntity : class;

        TEntity GetByID<TEntity>(object id) where TEntity : class;

        void add<TEntity>(TEntity model) where TEntity : class;

        void Update<TEntity>(TEntity model) where TEntity : class;

        void Delete<TEntity>(object id) where TEntity : class;

        void Delete<TEntity>(TEntity model) where TEntity : class;
    }
}