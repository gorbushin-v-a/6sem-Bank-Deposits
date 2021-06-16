using BLL.Interfaces;
using Microsoft.Extensions.Logging;
using sharps_ent.Entity;
using System.Linq;

namespace sharps_ent.Controllers
{
    public sealed class TypeController : GenericController
    {

        private readonly ITypeOperationService typeService;
        public TypeController(ILogger<GenericController> logger, ITypeOperationService typeService) : base(logger)
        {
            this.typeService = typeService;
        }

        public override string[] Labels => new string[]{ "NameOfType", "Action" };

        protected override void AddObject()
        {
            var @object = new TypeOperation
            {
                NameOfType = HttpContext.Request.Form["1"],
                Action = HttpContext.Request.Form["2"],
            };
            typeService.CreateTypeOperation(@object);
        }

        protected override string[][] GetObjects(bool id = false)
        {
            var objects = typeService.GetTypeOperations();
            if (HttpContext.Request.Method == "POST")
            {
                if (id)
                {
                    objects = objects.Where(x => x.TypeId.ToString() == HttpContext.Request.Form["id"]);
                }
                else
                {
                    if (HttpContext.Request.Form.ContainsKey("0") && HttpContext.Request.Form["0"] != "")
                    {
                        objects = objects.Where(x => x.TypeId.ToString() == HttpContext.Request.Form["0"]);
                    }
                    if (HttpContext.Request.Form.ContainsKey("1") && HttpContext.Request.Form["1"] != "")
                    {
                        objects = objects.Where(x => x.NameOfType == HttpContext.Request.Form["1"]);
                    }
                    if (HttpContext.Request.Form.ContainsKey("2") && HttpContext.Request.Form["2"] != "")
                    {
                        objects = objects.Where(x => x.Action == HttpContext.Request.Form["2"]);
                    }
                }
            }
            var cells = objects.Select(x => new string[] {
                x.TypeId.ToString(), x.NameOfType, x.Action
            }).ToArray();
            return cells;
        }

        protected override void UpdateObject()
        {
            var @object = typeService.GetTypeOperationById(int.Parse(HttpContext.Request.Form["0"]));
            @object.NameOfType = HttpContext.Request.Form["1"];
            @object.Action = HttpContext.Request.Form["2"];
            typeService.UpdateTypeOperation(@object);
        }

        protected override void RemoveObject()
        {
            typeService.DeleteTypeOperation(typeService.GetTypeOperationById(int.Parse(HttpContext.Request.Form["id"])));
        }
    }
}
