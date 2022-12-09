using System.Collections.Generic;
using TrailService.Models;

namespace TrailService.Data
{
    public interface ITrailRepo
    {
        bool SaveChanges();

        IEnumerable<TrailView> GetAllTrails();

        TrailView GetTrailById(int id);
        void CreateTrail(TrailView tr);

        IEnumerable<UserView> GetAllUsers();

        UserView GetUserById(string username);
    }
}