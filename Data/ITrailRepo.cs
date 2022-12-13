using System.Collections.Generic;
using TrailService.Models;

namespace TrailService.Data
{
    public interface ITrailRepo
    {
        bool SaveChanges();

        // For trails
        IEnumerable<TrailView> GetAllTrails();

        TrailView GetTrailById(int id);
        void CreateTrail(TrailView tr);

        // For users
        IEnumerable<UserView> GetAllUsers();

        UserView GetUserById(string username);

        IEnumerable<LocationPointsView> GetLocationPointsForTrail(string trailName);

        IEnumerable<LocationPointsView> GetAllLocationPoints();

    }
}