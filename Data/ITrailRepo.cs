using System.Collections.Generic;
using TrailService.Models;

namespace TrailService.Data
{
    public interface ITrailRepo
    {
        bool SaveChanges();

        IEnumerable<Trail> GetAllTrails();
        Trail GetTrailById(int id);
        void CreateTrail(Trail tr);
    }
}