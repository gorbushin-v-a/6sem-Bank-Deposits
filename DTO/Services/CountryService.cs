using BLL.Interfaces;
using sharps_ent.Entity;
using sharps_ent.Repository.Interface;
using System.Collections.Generic;

namespace BLL.Services
{
    public class CountryService : ICountryService
    {
        private IRepository<Country> CountryRepository;

        public CountryService(IRepository<Country> CountryRepository)
        {
            this.CountryRepository = CountryRepository;
        }

        public void CreateCountry(Country Country)
        {
            CountryRepository.Add(Country);
        }

        public void DeleteCountry(Country Country)
        {
            CountryRepository.Remove(Country);
        }
        public Country GetCountryById(int id)
        {
            return CountryRepository.Get(id);
        }

        public IEnumerable<Country> GetCountries()
        {
            return CountryRepository.Get();
        }

        public void UpdateCountry(Country Country)
        {
            CountryRepository.Update(Country);
        }
    }
}
