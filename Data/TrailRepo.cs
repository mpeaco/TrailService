using TrailService.Models;
using System.Linq;

namespace TrailService.Data
{
    public class TrailRepo : ITrailRepo
    {
        private readonly TrailDbContext _context;

        public TrailRepo(TrailDbContext context)
        {
            _context = context;
        }
        public void CreateTrail(TrailView tr)
        {
            if (tr == null)
            {
                throw new ArgumentNullException(nameof(tr));
            }

            _context.TrailViews.Add(tr);
        }

        public IEnumerable<TrailView> GetAllTrails()
        {
            return _context.TrailViews.ToList();
        }

        public TrailView GetTrailById(int id)
        {
            return _context.TrailViews.FirstOrDefault(t => t.TrailId == id);
        }

        public bool SaveChanges() // Used for unsafe changes
        {
            return _context.SaveChanges() >= 0;
        }
    }
}