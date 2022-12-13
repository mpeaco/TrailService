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

        public IEnumerable<UserView> GetAllUsers()
        {
            return _context.UserViews.ToList();
        }

        public IEnumerable<TrailView> GetAllTrails()
        {
            return _context.TrailViews.ToList();
        }

        public IEnumerable<LocationPointsView> GetAllLocationPoints()
        {
            return _context.LocationPointsViews.ToList();
        }

        public TrailView GetTrailById(int id)
        {
            return _context.TrailViews.FirstOrDefault(t => t.TrailId == id);
        }

        public UserView GetUserById(string username)
        {
            return _context.UserViews.FirstOrDefault(u => u.Username == username);
        }

        public IEnumerable<LocationPointsView> GetLocationPointsForTrail(string trailName)
        {
            // TODO: This only returns a single location point and it needs to return all
            return _context.LocationPointsViews.Where(t => t.TrailName == trailName);

        }

        public bool SaveChanges() // Used for unsafe changes
        {
            return _context.SaveChanges() >= 0;
        }
    }
}