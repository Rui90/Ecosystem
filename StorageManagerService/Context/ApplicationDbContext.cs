using Microsoft.EntityFrameworkCore;
using StorageManagerService.Entities;

namespace StorageManagerService.Context
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
    base(options)
        {

        }

        #region Entity Configurations
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasIndex(b => b.Name)
                .IsUnique();

            modelBuilder.Entity<Product>()
                  .Property(b => b.Name)
                  .IsRequired()
                  .HasMaxLength(512);

            modelBuilder.Entity<Brand>()
                .HasIndex(b => b.Name)
                .IsUnique();

            modelBuilder.Entity<Brand>()
                  .Property(b => b.Name)
                  .IsRequired()
                  .HasMaxLength(512);

            modelBuilder.Entity<Store>()
                .HasIndex(b => b.Name)
                .IsUnique();
        }
        #endregion

        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }

        public DbSet<Store> Stores { get; set; }
    }
}
