using BLL.Interfaces;
using Microsoft.Extensions.Logging;
using sharps_ent.Entity;
using System.Collections.Generic;
using System.Linq;

namespace sharps_ent.Controllers
{
    public sealed class LogController : GenericController
    {

        private readonly ILogOfOperationsService logService;
        public LogController(ILogger<GenericController> logger, ILogOfOperationsService logService) : base(logger)
        {
            this.logService = logService;
        }

        public override string[] Labels => new string[] { "EmployeeId", "DepositorId", "TypeId", "Quantity" };

        protected override void AddObject()
        {
            var @object = new LogOfOperations
            {
                EmployeeId = int.Parse(HttpContext.Request.Form["1"]),
                DepositorId = int.Parse(HttpContext.Request.Form["2"]),
                TypeId = int.Parse(HttpContext.Request.Form["3"]),
                Quantity = int.Parse(HttpContext.Request.Form["4"])
            };
            logService.CreateLogOfOperations(@object);
        }

        protected override string[][] GetObjects(bool id = false)
        {
            var objects = logService.GetLogOfOperations();
            if (HttpContext.Request.Method == "POST")
            {
                if (id)
                {
                    objects = objects.Where(x => x.OperationId.ToString() == HttpContext.Request.Form["id"]);
                }
                else
                {
                    if (HttpContext.Request.Form.ContainsKey("0") && HttpContext.Request.Form["0"] != "")
                    {
                        objects = objects.Where(x => x.OperationId.ToString() == HttpContext.Request.Form["0"]);
                    }
                    if (HttpContext.Request.Form.ContainsKey("1") && HttpContext.Request.Form["1"] != "")
                    {
                        objects = objects.Where(x => x.EmployeeId.ToString() == HttpContext.Request.Form["1"]);
                    }
                    if (HttpContext.Request.Form.ContainsKey("2") && HttpContext.Request.Form["2"] != "")
                    {
                        objects = objects.Where(x => x.DepositorId.ToString() == HttpContext.Request.Form["2"]);
                    }
                    if (HttpContext.Request.Form.ContainsKey("3") && HttpContext.Request.Form["3"] != "")
                    {
                        objects = objects.Where(x => x.TypeId.ToString() == HttpContext.Request.Form["3"]);
                    }
                    if (HttpContext.Request.Form.ContainsKey("4") && HttpContext.Request.Form["4"] != "")
                    {
                        objects = objects.Where(x => x.Quantity.ToString() == HttpContext.Request.Form["4"]);
                    }
                }
            }
            var cells = objects.Select(x => new string[] {
                x.OperationId.ToString(), x.EmployeeId.ToString(), x.DepositorId.ToString(), x.TypeId.ToString(), x.Quantity.ToString()
            }).ToArray();
            return cells;
        }

        protected override void UpdateObject()
        {
            var @object = logService.GetLogOfOperationsById(int.Parse(HttpContext.Request.Form["0"]));
            @object.EmployeeId = int.Parse(HttpContext.Request.Form["1"]);
            @object.DepositorId = int.Parse(HttpContext.Request.Form["2"]);
            @object.TypeId = int.Parse(HttpContext.Request.Form["3"]);
            @object.Quantity = int.Parse(HttpContext.Request.Form["4"]);
            logService.UpdateLogOfOperations(@object);
        }

        protected override void RemoveObject()
        {
            logService.DeleteLogOfOperations(logService.GetLogOfOperationsById(int.Parse(HttpContext.Request.Form["id"])));
        }
        protected override Dictionary<int, string> GetAttributes() => new Dictionary<int, string>() { { 1, "Employee" }, { 2, "Depositor" }, { 3, "Type" } };

        protected override List<string> GetStat() => new List<string>{ $"Количество денег: {((IEnumerable<LogOfOperations>)GetStatObj()).Select(x => x.Quantity).Sum()}", $"Количество вкладчиков: {((IEnumerable<LogOfOperations>)GetStatObj()).Select(x => x.DepositorId).Distinct().Count()}", $"Количество работников: {((IEnumerable<LogOfOperations>)GetStatObj()).Select(x => x.EmployeeId).Distinct().Count()}" };

        protected override object GetStatObj()
        {
            var objects = logService.GetLogOfOperations();
            if (HttpContext.Request.Method == "POST")
            {
                if (HttpContext.Request.Form.ContainsKey("0") && HttpContext.Request.Form["0"] != "")
                {
                    objects = objects.Where(x => x.OperationId.ToString() == HttpContext.Request.Form["0"]);
                }
                if (HttpContext.Request.Form.ContainsKey("1") && HttpContext.Request.Form["1"] != "")
                {
                    objects = objects.Where(x => x.EmployeeId.ToString() == HttpContext.Request.Form["1"]);
                }
                if (HttpContext.Request.Form.ContainsKey("2") && HttpContext.Request.Form["2"] != "")
                {
                    objects = objects.Where(x => x.DepositorId.ToString() == HttpContext.Request.Form["2"]);
                }
                if (HttpContext.Request.Form.ContainsKey("3") && HttpContext.Request.Form["3"] != "")
                {
                    objects = objects.Where(x => x.TypeId.ToString() == HttpContext.Request.Form["3"]);
                }
                if (HttpContext.Request.Form.ContainsKey("4") && HttpContext.Request.Form["4"] != "")
                {
                    objects = objects.Where(x => x.Quantity.ToString() == HttpContext.Request.Form["4"]);
                }
            }
            return objects;
        }
    }
}
