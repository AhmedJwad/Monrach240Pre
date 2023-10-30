using Microsoft.EntityFrameworkCore;
using Monrach240Pre.Data.Entities;

namespace Monrach240Pre.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext>options):base(options)       
        {
                
        }

        public DbSet<TestData> Datasets { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TestData>().HasIndex(t => t.DEVICE_ID);
            modelBuilder.Entity<TestData>().HasIndex(t => t.TIMESTAMP);
        }
    }
}
