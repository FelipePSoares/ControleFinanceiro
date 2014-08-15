using Entities;
using System;
using System.Data.Entity;
using System.Linq;

namespace Repository
{
    public class DataContext : DbContext, IDisposable, IDataContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transacao>().ToTable("Transacao");
        }

        public DbSet<T> DbSet<T>() where T : class
        {
            return Set<T>();
        }
    }
}