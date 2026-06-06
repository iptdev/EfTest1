using DataModel;
using Microsoft.EntityFrameworkCore;

namespace EfDataLayer
{
    public class MyDbContext : DbContext
    {
        public DbSet<A> As { get; set; }
        public DbSet<B> Bs { get; set; }
        public DbSet<C> Cs { get; set; }
        public DbSet<R> Rs { get; set; }
        public DbSet<ComponentClass> Components { get; set; }
        public DbSet<ComponentClassPort> Ports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ComponentClass>().HasMany(s => s.Ports).WithOne(s => s.Component);

            modelBuilder.Entity<ComponentClass>().Navigation(e => e.Ports).AutoInclude();
        }
    }
     
    public class SQLiteDataContext : MyDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // The following configures EF to create a Sqlite database file in the
            // special "local" folder for your platform.  

            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            var DbPath = System.IO.Path.Join(path, "EfTest1.db");

            options.UseSqlite($"Data Source={DbPath}");
        }
    }

    public class InMemoryDataContext : MyDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseInMemoryDatabase("InMemory");
        }
    }
}
