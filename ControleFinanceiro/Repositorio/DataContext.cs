using Entities;
using System;
using System.Data.Entity;
using System.Linq;

namespace Repository
{
    public class DataContext : DbContext, IDisposable, IDataContext
    {
        IQueryable<Transacao> IDataContext.Transacoes
        {
            get { return this.Set<Transacao>(); }
        }

        public DbSet DbSet<T>() where T : class
        {
            return Set<T>();
        }
    }
}