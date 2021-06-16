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
        public CityController(ILogger<GenericController> logger, ICityService cityService) : base(logger)
        {
            this.cityService = cityService;
        }

        public override string[] Labels => new string[]{ "NameOfCity", "CountryId" };

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
                        objects = objects.Where(x => x.CountryId.ToString() == HttpContext.Request.Form["2"]);
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
    }
}
