using Microsoft.EntityFrameworkCore;
using SoccerAnalyticModels;

namespace SoccerAnalyticsDataAccess.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Player> Players { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Player>();
        }
    }
}
