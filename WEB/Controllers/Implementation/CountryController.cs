using BLL.Interfaces;
using Microsoft.Extensions.Logging;
using sharps_ent.Entity;
using System.Linq;

namespace sharps_ent.Controllers
{
    public sealed class CountryController : GenericController
    {

        private readonly ICountryService countryService;
        public CountryController(ILogger<GenericController> logger, ICountryService countryService) : base(logger)
        {
            this.countryService = countryService;
        }

        public override string[] Labels => new string[]{ "NameOfCountry" };

        protected override void AddObject()
        {
            var @object = new Country
            {
                NameOfCountry = HttpContext.Request.Form["1"],
            };
            countryService.CreateCountry(@object);
        }

        protected override string[][] GetObjects(bool id = false)
        {
            var objects = countryService.GetCountries();
            if (HttpContext.Request.Method == "POST")
            {
                if (id)
                {
                    objects = objects.Where(x => x.CountryId.ToString() == HttpContext.Request.Form["id"]);
                }
                else
                {
                    if (HttpContext.Request.Form.ContainsKey("0") && HttpContext.Request.Form["0"] != "")
                    {
                        objects = objects.Where(x => x.CountryId.ToString() == HttpContext.Request.Form["0"]);
                    }
                    if (HttpContext.Request.Form.ContainsKey("1") && HttpContext.Request.Form["1"] != "")
                    {
                        objects = objects.Where(x => x.NameOfCountry.ToString() == HttpContext.Request.Form["1"]);
                    }
                }
            }
            var cells = objects.Select(x => new string[] {
                x.CountryId.ToString(), x.NameOfCountry.ToString()
            }).ToArray();
            return cells;
        }

        protected override void UpdateObject()
        {
            var @object = countryService.GetCountryById(int.Parse(HttpContext.Request.Form["0"]));
            @object.NameOfCountry = HttpContext.Request.Form["1"];
            countryService.UpdateCountry(@object);
        }

        protected override void RemoveObject()
        {
            countryService.DeleteCountry(countryService.GetCountryById(int.Parse(HttpContext.Request.Form["id"])));
        }
    }
}
