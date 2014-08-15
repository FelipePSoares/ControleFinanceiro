using Entities;
using System;
using System.Data.Entity;
using System.Linq;

namespace Repository
{
    public interface IDataContext : IDisposable
    {
        DbSet<T> DbSet<T>() where T : class;
    }
}