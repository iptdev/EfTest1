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
