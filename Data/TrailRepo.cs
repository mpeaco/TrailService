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
        public void CreateTrail(TrailPoint tr)
        {
            if (tr == null)
            {
                throw new ArgumentNullException(nameof(tr));
            }

            _context.TrailPoints.Add(tr);
        }

        public IEnumerable<TrailPoint> GetAllTrails()
        {
            return _context.TrailPoints.ToList();
        }

        public TrailPoint GetTrailById(int id)
        {
            return _context.TrailPoints.FirstOrDefault(t => t.TrailId == id);
        }

        public bool SaveChanges() // Used for unsafe changes
        {
            return _context.SaveChanges() >= 0;
        }
    }
}