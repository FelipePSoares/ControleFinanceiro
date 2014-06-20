using Entities;
using System;
using System.Data.Entity;
using System.Linq;

namespace Repository
{
    public interface IDataContext : IDisposable
    {
        IQueryable<Transacao> Transacoes { get; }

        DbSet DbSet<T>() where T : class;
    }
}