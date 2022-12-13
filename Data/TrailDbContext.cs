using Microsoft.EntityFrameworkCore;
using TrailService.Models;

namespace TrailService.Data
{
    public class TrailDbContext : DbContext
    {
        public TrailDbContext(DbContextOptions<TrailDbContext> opt) : base(opt)
        {

        }

        public DbSet<TrailView> TrailViews { get; set; }
        public DbSet<UserView> UserViews { get; set; }
        public DbSet<LocationPointsView> LocationPointsViews { get; set; }
    }
}