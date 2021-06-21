using BLL.Interfaces;
using Microsoft.Extensions.Logging;
using sharps_ent.Entity;
using System.Collections.Generic;
using System.Linq;

namespace sharps_ent.Controllers
{
    public sealed class EmployeeController : GenericController
    {

        private readonly IEmployeeService employeeService;
        private readonly IBankService bankService;
        private readonly IStreetService streetService;
        public EmployeeController(ILogger<GenericController> logger, IEmployeeService employeeService, IBankService bankService, IStreetService streetService) : base(logger)
        {
            this.employeeService = employeeService;
            this.bankService = bankService;
            this.streetService = streetService;
        }

        public override string[] Labels => new string[]{ "Bank", "Street", "NameOfEmployee"};

        protected override void AddObject()
        {
            var @object = new Employee
            {
                BankId = int.Parse(HttpContext.Request.Form["1"]),
                StreetId = int.Parse(HttpContext.Request.Form["2"]),
                NameOfEmployee = HttpContext.Request.Form["3"]
            };
            employeeService.CreateEmployee(@object);
        }

        protected override string[][] GetObjects(bool id = false)
        {
            var objects = employeeService.GetEmployees();
            if (HttpContext.Request.Method == "POST")
            {
                if (id)
                {
                    objects = objects.Where(x => x.EmployeeId.ToString() == HttpContext.Request.Form["id"]);
                }
                else
                {
                    if (HttpContext.Request.Form.ContainsKey("0") && HttpContext.Request.Form["0"] != "")
                    {
                        objects = objects.Where(x => x.EmployeeId.ToString() == HttpContext.Request.Form["0"]);
                    }
                    if (HttpContext.Request.Form.ContainsKey("1") && HttpContext.Request.Form["1"] != "")
                    {
                        objects = objects.Where(x => bankService.GetBankById(x.BankId).NameOfBank.ToString() == HttpContext.Request.Form["1"]);
                    }
                    if (HttpContext.Request.Form.ContainsKey("2") && HttpContext.Request.Form["2"] != "")
                    {
                        objects = objects.Where(x => streetService.GetStreetById(x.StreetId).NameOfStreet.ToString() == HttpContext.Request.Form["2"]);
                    }
                    if (HttpContext.Request.Form.ContainsKey("3") && HttpContext.Request.Form["3"] != "")
                    {
                        objects = objects.Where(x => x.NameOfEmployee.ToString() == HttpContext.Request.Form["3"]);
                    }
                }
            }
            var cells = objects.Select(x => new string[] {
                x.EmployeeId.ToString(), x.BankId.ToString(), x.StreetId.ToString(), x.NameOfEmployee.ToString()
            }).ToArray();
            return cells;
        }

        protected override void UpdateObject()
        {
            var @object = employeeService.GetEmployeeById(int.Parse(HttpContext.Request.Form["0"]));
            @object.BankId = int.Parse(HttpContext.Request.Form["1"]);
            @object.StreetId = int.Parse(HttpContext.Request.Form["2"]);
            @object.NameOfEmployee = HttpContext.Request.Form["3"];
            employeeService.UpdateEmployee(@object);
        }

        protected override void RemoveObject()
        {
            employeeService.DeleteEmployee(employeeService.GetEmployeeById(int.Parse(HttpContext.Request.Form["id"])));
        }
        protected override Dictionary<int, string> GetAttributes() => new Dictionary<int, string>() { { 1, "Bank" }, { 2, "Street" } };

        protected override object GetNames() => new Dictionary<int, string[]> {
            { 1, employeeService.GetEmployees().Where(x => GetObjects().Select(y => y[0]).Contains(x.EmployeeId.ToString())).Select(x => bankService.GetBankById(x.BankId).NameOfBank).ToArray() } ,
            { 2, employeeService.GetEmployees().Where(x => GetObjects().Select(y => y[0]).Contains(x.EmployeeId.ToString())).Select(x => streetService.GetStreetById(x.StreetId).NameOfStreet).ToArray() }
        };
    }
}
