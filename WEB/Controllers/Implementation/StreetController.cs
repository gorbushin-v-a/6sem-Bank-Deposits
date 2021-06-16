using BLL.Interfaces;
using Microsoft.Extensions.Logging;
using sharps_ent.Entity;
using System.Collections.Generic;
using System.Linq;

namespace sharps_ent.Controllers
{
    public sealed class StreetController : GenericController
    {

        private readonly IStreetService streetService;
        public StreetController(ILogger<GenericController> logger, IStreetService streetService) : base(logger)
        {
            this.streetService = streetService;
        }

        public override string[] Labels => new string[]{ "NameOfStreet", "CityId" };

        protected override void AddObject()
        {
            var @object = new Street
            {
                NameOfStreet = HttpContext.Request.Form["1"],
                CityId = int.Parse(HttpContext.Request.Form["2"]),
            };
            streetService.CreateStreet(@object);
        }

        protected override string[][] GetObjects(bool id = false)
        {
            var objects = streetService.GetStreets();
            if (HttpContext.Request.Method == "POST")
            {
                if (id)
                {
                    objects = objects.Where(x => x.StreetId.ToString() == HttpContext.Request.Form["id"]);
                }
                else
                {
                    if (HttpContext.Request.Form.ContainsKey("0") && HttpContext.Request.Form["0"] != "")
                    {
                        objects = objects.Where(x => x.StreetId.ToString() == HttpContext.Request.Form["0"]);
                    }
                    if (HttpContext.Request.Form.ContainsKey("1") && HttpContext.Request.Form["1"] != "")
                    {
                        objects = objects.Where(x => x.NameOfStreet.ToString() == HttpContext.Request.Form["1"]);
                    }
                    if (HttpContext.Request.Form.ContainsKey("2") && HttpContext.Request.Form["2"] != "")
                    {
                        objects = objects.Where(x => x.CityId.ToString() == HttpContext.Request.Form["2"]);
                    }
                }
            }
            var cells = objects.Select(x => new string[] {
                x.StreetId.ToString(), x.NameOfStreet.ToString(), x.CityId.ToString()
            }).ToArray();
            return cells;
        }

        protected override void UpdateObject()
        {
            var @object = streetService.GetStreetById(int.Parse(HttpContext.Request.Form["0"]));
            @object.NameOfStreet = HttpContext.Request.Form["1"];
            @object.CityId = int.Parse(HttpContext.Request.Form["2"]);
            streetService.UpdateStreet(@object);
        }

        protected override void RemoveObject()
        {
            streetService.DeleteStreet(streetService.GetStreetById(int.Parse(HttpContext.Request.Form["id"])));
        }

        protected override Dictionary<int, string> GetAttributes() => new Dictionary<int, string>() { { 2, "City" } };
    }
}
