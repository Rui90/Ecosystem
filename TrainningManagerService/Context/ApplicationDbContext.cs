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

        public DbSet<Video> Videos { get; set; }
        public DbSet<Plan> Plans { get; set; }
    }
}
