using Microsoft.EntityFrameworkCore;
using TrainningManagerService.Entities.Database;

namespace TrainningManagerService.Context
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
            modelBuilder.Entity<Video>()
                .Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(512);

            modelBuilder.Entity<Video>()
                .Property(b => b.DurationInSeconds)
                .IsRequired();

            modelBuilder.Entity<Plan>()
                .Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(512);

            modelBuilder.Entity<Author>()
                .Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(512);
        }
        #endregion

        public DbSet<Video> Videos { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
