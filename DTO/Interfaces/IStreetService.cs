using sharps_ent.Entity;
using System.Collections.Generic;

namespace BLL.Interfaces
{
    public interface IStreetService
    {
        void CreateStreet(Street Street);
        void DeleteStreet(Street Street);
        Street GetStreetById(int id);
        IEnumerable<Street> GetStreets();
        void UpdateStreet(Street Street);
    }
}
