using BLL.Interfaces;
using sharps_ent.Entity;
using sharps_ent.Repository.Interface;
using System.Collections.Generic;

namespace BLL.Services
{
    public class CityService : ICityService
    {
        private IRepository<City> CityRepository;

        public CityService(IRepository<City> CityRepository)
        {
            this.CityRepository = CityRepository;
        }

        public void CreateCity(City City)
        {
            CityRepository.Add(City);
        }

        public void DeleteCity(City City)
        {
            CityRepository.Remove(City);
        }
        public City GetCityById(int id)
        {
            return CityRepository.Get(id);
        }

        public IEnumerable<City> GetCities()
        {
            return CityRepository.Get();
        }

        public void UpdateCity(City City)
        {
            CityRepository.Update(City);
        }
    }
}
