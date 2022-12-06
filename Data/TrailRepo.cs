using TrailService.Models;
using System.Linq;

namespace TrailService.Data {
    public class TrailRepo : ITrailRepo
    {
        private readonly TrailDbContext _context;

        public TrailRepo(TrailDbContext context)
        {
            _context = context;
        }
        public void CreateTrail(Trail tr)
        {
            if(tr == null) {
                throw new ArgumentNullException(nameof(tr));
            }

            _context.Trails.Add(tr);
        }

        public IEnumerable<Trail> GetAllTrails()
        {
            return _context.Trails.ToList();
        }

        public Trail GetTrailById(int id)
        {
            return _context.Trails.FirstOrDefault(t => t.TrailId == id);
        }

        public bool SaveChanges() // Used for unsafe changes
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}