using Microsoft.EntityFrameworkCore;
using TrailService.Models;

namespace TrailService.Data
{
    public class TrailDbContext : DbContext
    {
        public TrailDbContext(DbContextOptions<TrailDbContext> opt) : base(opt)
        {

        }

        public DbSet<TrailPoint> TrailPoints { get; set; }
    }
}