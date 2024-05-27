using CriptoProjectTest.Data;
using CriptoProjectTest.Entityes;
using Microsoft.EntityFrameworkCore;

namespace NewForReact.Data
{
    public class DataDbContent : DbContext
    {
        public DataDbContent(DbContextOptions<DataDbContent> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AssetData());
        }

        public DbSet<Asset> Assets { get; set; }
    }
}
