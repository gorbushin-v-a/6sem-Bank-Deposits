using BLL.Interfaces;
using Microsoft.Extensions.Logging;
using sharps_ent.Entity;
using System.Linq;

namespace sharps_ent.Controllers
{
    public sealed class StatusController : GenericController
    {

        private readonly IStatusService statusService;
        public StatusController(ILogger<GenericController> logger, IStatusService statusService) : base(logger)
        {
            this.statusService = statusService;
        }

        public override string[] Labels => new string[]{ "NameOfStatus" };

        protected override void AddObject()
        {
            var @object = new Status
            {
                NameOfStatus = HttpContext.Request.Form["1"],
            };
            statusService.CreateStatus(@object);
        }

        protected override string[][] GetObjects(bool id = false)
        {
            var objects = statusService.GetStatuses();
            if (HttpContext.Request.Method == "POST")
            {
                if (id)
                {
                    objects = objects.Where(x => x.StatusId.ToString() == HttpContext.Request.Form["id"]);
                }
                else
                {
                    if (HttpContext.Request.Form.ContainsKey("0") && HttpContext.Request.Form["0"] != "")
                    {
                        objects = objects.Where(x => x.StatusId.ToString() == HttpContext.Request.Form["0"]);
                    }
                    if (HttpContext.Request.Form.ContainsKey("1") && HttpContext.Request.Form["1"] != "")
                    {
                        objects = objects.Where(x => x.NameOfStatus.ToString() == HttpContext.Request.Form["1"]);
                    }
                }
            }
            var cells = objects.Select(x => new string[] {
                x.StatusId.ToString(), x.NameOfStatus.ToString()
            }).ToArray();
            return cells;
        }

        protected override void UpdateObject()
        {
            var @object = statusService.GetStatusById(int.Parse(HttpContext.Request.Form["0"]));
            @object.NameOfStatus = HttpContext.Request.Form["1"];
            statusService.UpdateStatus(@object);
        }

        protected override void RemoveObject()
        {
            statusService.DeleteStatus(statusService.GetStatusById(int.Parse(HttpContext.Request.Form["id"])));
        }
    }
}
