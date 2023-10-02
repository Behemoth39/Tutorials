using Microsoft.EntityFrameworkCore;
using Delegates.Models;

namespace Delegates.Data
{
    public class DelegatesDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={AppDomain.CurrentDomain.BaseDirectory}.DelegatesDb.db");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<User> Users { get; set; }

    }
}