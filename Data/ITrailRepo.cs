using System.Collections.Generic;
using TrailService.Models;

namespace TrailService.Data
{
    public interface ITrailRepo
    {
        bool SaveChanges();

        IEnumerable<TrailPoint> GetAllTrails();
        TrailPoint GetTrailById(int id);
        void CreateTrail(TrailPoint tr);
    }
}