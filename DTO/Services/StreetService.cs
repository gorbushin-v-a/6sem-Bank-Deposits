using BLL.Interfaces;
using sharps_ent.Entity;
using sharps_ent.Repository.Interface;
using System.Collections.Generic;

namespace BLL.Services
{
    public class StreetService : IStreetService
    {
        private IRepository<Street> StreetRepository;

        public StreetService(IRepository<Street> StreetRepository)
        {
            this.StreetRepository = StreetRepository;
        }

        public void CreateStreet(Street Street)
        {
            StreetRepository.Add(Street);
        }

        public void DeleteStreet(Street Street)
        {
            StreetRepository.Remove(Street);
        }
        public Street GetStreetById(int id)
        {
            return StreetRepository.Get(id);
        }

        public IEnumerable<Street> GetStreets()
        {
            return StreetRepository.Get();
        }

        public void UpdateStreet(Street Street)
        {
            StreetRepository.Update(Street);
        }
    }
}
