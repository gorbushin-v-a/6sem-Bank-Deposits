using BLL.Interfaces;
using Microsoft.Extensions.Logging;
using sharps_ent.Entity;
using System.Linq;

namespace sharps_ent.Controllers
{
    public sealed class DepositorController : GenericController
    {

        private readonly IDepositorService depositorService;
        public DepositorController(ILogger<GenericController> logger, IDepositorService depositorService) : base(logger)
        {
            this.depositorService = depositorService;
        }

        public override string[] Labels => new string[]{ "NameOfDepositor", "Position" };

        protected override void AddObject()
        {
            var @object = new Depositor
            {
                NameOfDepositor = HttpContext.Request.Form["1"],
                Position = HttpContext.Request.Form["2"],
            };
            depositorService.CreateDepositor(@object);
        }

        protected override string[][] GetObjects(bool id = false)
        {
            var objects = depositorService.GetDepositors();
            if (HttpContext.Request.Method == "POST")
            {
                if (id)
                {
                    objects = objects.Where(x => x.DepositorId.ToString() == HttpContext.Request.Form["id"]);
                }
                else
                {
                    if (HttpContext.Request.Form.ContainsKey("0") && HttpContext.Request.Form["0"] != "")
                    {
                        objects = objects.Where(x => x.DepositorId.ToString() == HttpContext.Request.Form["0"]);
                    }
                    if (HttpContext.Request.Form.ContainsKey("1") && HttpContext.Request.Form["1"] != "")
                    {
                        objects = objects.Where(x => x.NameOfDepositor == HttpContext.Request.Form["1"]);
                    }
                    if (HttpContext.Request.Form.ContainsKey("2") && HttpContext.Request.Form["2"] != "")
                    {
                        objects = objects.Where(x => x.Position == HttpContext.Request.Form["2"]);
                    }
                }
            }
            var cells = objects.Select(x => new string[] {
                x.DepositorId.ToString(), x.NameOfDepositor, x.Position
            }).ToArray();
            return cells;
        }

        protected override void UpdateObject()
        {
            var @object = depositorService.GetDepositorById(int.Parse(HttpContext.Request.Form["0"]));
            @object.NameOfDepositor = HttpContext.Request.Form["1"];
            @object.Position = HttpContext.Request.Form["2"];
            depositorService.UpdateDepositor(@object);
        }

        protected override void RemoveObject()
        {
            depositorService.DeleteDepositor(depositorService.GetDepositorById(int.Parse(HttpContext.Request.Form["id"])));
        }
    }
}
