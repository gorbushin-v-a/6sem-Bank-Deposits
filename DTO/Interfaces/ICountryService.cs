using sharps_ent.Entity;
using System.Collections.Generic;

namespace BLL.Interfaces
{
    public interface ICountryService
    {
        void CreateCountry(Country Country);
        void DeleteCountry(Country Country);
        Country GetCountryById(int id);
        IEnumerable<Country> GetCountries();
        void UpdateCountry(Country Country);
    }
}
