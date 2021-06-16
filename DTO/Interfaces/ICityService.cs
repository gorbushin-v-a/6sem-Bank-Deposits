using sharps_ent.Entity;
using System.Collections.Generic;

namespace BLL.Interfaces
{
    public interface ICityService
    {
        void CreateCity(City City);
        void DeleteCity(City City);
        City GetCityById(int id);
        IEnumerable<City> GetCities();
        void UpdateCity(City City);
    }
}
