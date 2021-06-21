using BLL.Interfaces;
using Microsoft.Extensions.Logging;
using sharps_ent.Entity;
using System.Collections.Generic;
using System.Linq;

namespace sharps_ent.Controllers
{
    public sealed class CityController : GenericController
    {

        private readonly ICityService cityService;
        private readonly ICountryService countryService;
        public CityController(ILogger<GenericController> logger, ICityService cityService, ICountryService countryService) : base(logger)
        {
            this.cityService = cityService;
            this.countryService = countryService;
        }

        public override string[] Labels => new string[]{ "NameOfCity", "Country" };

        protected override void AddObject()
        {
            var @object = new City
            {
                NameOfCity = HttpContext.Request.Form["1"],
                CountryId = int.Parse(HttpContext.Request.Form["2"]),
            };
            cityService.CreateCity(@object);
        }

        protected override string[][] GetObjects(bool id = false)
        {
            var objects = cityService.GetCities();
            if (HttpContext.Request.Method == "POST")
            {
                if (id)
                {
                    objects = objects.Where(x => x.CityId.ToString() == HttpContext.Request.Form["id"]);
                }
                else
                {
                    if (HttpContext.Request.Form.ContainsKey("0") && HttpContext.Request.Form["0"] != "")
                    {
                        objects = objects.Where(x => x.CityId.ToString() == HttpContext.Request.Form["0"]);
                    }
                    if (HttpContext.Request.Form.ContainsKey("1") && HttpContext.Request.Form["1"] != "")
                    {
                        objects = objects.Where(x => x.NameOfCity.ToString() == HttpContext.Request.Form["1"]);
                    }
                    if (HttpContext.Request.Form.ContainsKey("2") && HttpContext.Request.Form["2"] != "")
                    {
                        objects = objects.Where(x => countryService.GetCountryById(x.CountryId).NameOfCountry == HttpContext.Request.Form["2"]);
                    }
                }
            }
            var cells = objects.Select(x => new string[] {
                x.CityId.ToString(), x.NameOfCity.ToString(), x.CountryId.ToString()
            }).ToArray();
            return cells;
        }

        protected override void UpdateObject()
        {
            var @object = cityService.GetCityById(int.Parse(HttpContext.Request.Form["0"]));
            @object.NameOfCity = HttpContext.Request.Form["1"];
            @object.CountryId = int.Parse(HttpContext.Request.Form["2"]);
            cityService.UpdateCity(@object);
        }

        protected override void RemoveObject()
        {
            cityService.DeleteCity(cityService.GetCityById(int.Parse(HttpContext.Request.Form["id"])));
        }
        protected override Dictionary<int, string> GetAttributes() => new Dictionary<int, string>() { { 2, "Country" } };

        protected override object GetNames() => new Dictionary<int, string[]> {
            { 2, cityService.GetCities().Where(x => GetObjects().Select(y => y[0]).Contains(x.CityId.ToString())).Select(x => countryService.GetCountryById(x.CountryId)?.NameOfCountry).ToArray() }
        };
    }
}
