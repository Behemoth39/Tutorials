using Microsoft.EntityFrameworkCore;

namespace WebApiTutorial.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Name> Names { get; set; }
    }
}