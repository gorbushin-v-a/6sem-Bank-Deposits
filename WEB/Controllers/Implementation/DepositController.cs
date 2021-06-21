using BLL.Interfaces;
using Microsoft.Extensions.Logging;
using sharps_ent.Entity;
using System.Collections.Generic;
using System.Linq;

namespace sharps_ent.Controllers
{
    public sealed class DepositController : GenericController
    {
        private readonly IDepositService depositService;
        private readonly IEmployeeService employeeService;
        private readonly IDepositorService depositorService;
        private readonly IStatusService statusService;
        private readonly IBankService bankService;

        public DepositController(ILogger<GenericController> logger, IDepositService depositService, IEmployeeService employeeService, IDepositorService depositorService, IStatusService statusService, IBankService bankService) : base(logger)
        {
            this.depositService = depositService;
            this.employeeService = employeeService;
            this.depositorService = depositorService;
            this.statusService = statusService;
            this.bankService = bankService;
        }

        public override string[] Labels => new string[] { "Employee", "Depositor", "Status", "Bank", "Percent", "Description" };

        protected override void AddObject()
        {
            var @object = new Deposit
            {
                EmployeeId = int.Parse(HttpContext.Request.Form["1"]),
                DepositorId = int.Parse(HttpContext.Request.Form["2"]),
                StatusId = int.Parse(HttpContext.Request.Form["3"]),
                BankId = int.Parse(HttpContext.Request.Form["4"]),
                Percent = int.Parse(HttpContext.Request.Form["5"]),
                Description = HttpContext.Request.Form["6"]
            };
            depositService.CreateDeposit(@object);
        }

        protected override string[][] GetObjects(bool id = false)
        {
            var objects = depositService.GetDeposits();
            if (HttpContext.Request.Method == "POST")
            {
                if (id)
                {
                    objects = objects.Where(x => x.DepositId.ToString() == HttpContext.Request.Form["id"]);
                }
                else
                {
                    if (HttpContext.Request.Form.ContainsKey("0") && HttpContext.Request.Form["0"] != "")
                    {
                        objects = objects.Where(x => x.DepositId.ToString() == HttpContext.Request.Form["0"]);
                    }
                    if (HttpContext.Request.Form.ContainsKey("1") && HttpContext.Request.Form["1"] != "")
                    {
                        objects = objects.Where(x => employeeService.GetEmployeeById(x.EmployeeId).NameOfEmployee == HttpContext.Request.Form["1"]);
                    }
                    if (HttpContext.Request.Form.ContainsKey("2") && HttpContext.Request.Form["2"] != "")
                    {
                        objects = objects.Where(x => depositorService.GetDepositorById(x.DepositorId).NameOfDepositor == HttpContext.Request.Form["2"]);
                    }
                    if (HttpContext.Request.Form.ContainsKey("3") && HttpContext.Request.Form["3"] != "")
                    {
                        objects = objects.Where(x => statusService.GetStatusById(x.StatusId).NameOfStatus == HttpContext.Request.Form["3"]);
                    }
                    if (HttpContext.Request.Form.ContainsKey("4") && HttpContext.Request.Form["4"] != "")
                    {
                        objects = objects.Where(x => bankService.GetBankById(x.BankId).NameOfBank == HttpContext.Request.Form["4"]);
                    }
                    if (HttpContext.Request.Form.ContainsKey("5") && HttpContext.Request.Form["5"] != "")
                    {
                        objects = objects.Where(x => x.Percent.ToString() == HttpContext.Request.Form["5"]);
                    }
                    if (HttpContext.Request.Form.ContainsKey("6") && HttpContext.Request.Form["6"] != "")
                    {
                        objects = objects.Where(x => x.Description.ToString() == HttpContext.Request.Form["6"]);
                    }
                }
            }
            var cells = objects.Select(x => new string[] {
                x.DepositId.ToString(), x.EmployeeId.ToString(), x.DepositorId.ToString(), x.StatusId.ToString(), x.BankId.ToString(), x.Percent.ToString(), x.Description.ToString()
            }).ToArray();
            return cells;
        }

        protected override void UpdateObject()
        {
            var @object = depositService.GetDepositById(int.Parse(HttpContext.Request.Form["0"]));
            @object.EmployeeId = int.Parse(HttpContext.Request.Form["1"]);
            @object.DepositorId = int.Parse(HttpContext.Request.Form["2"]);
            @object.StatusId = int.Parse(HttpContext.Request.Form["3"]);
            @object.BankId = int.Parse(HttpContext.Request.Form["4"]);
            @object.Percent = int.Parse(HttpContext.Request.Form["5"]);
            @object.Description = HttpContext.Request.Form["6"];
            depositService.UpdateDeposit(@object);
        }

        protected override void RemoveObject()
        {
            depositService.DeleteDeposit(depositService.GetDepositById(int.Parse(HttpContext.Request.Form["id"])));
        }
        protected override Dictionary<int, string> GetAttributes() => new Dictionary<int, string>() { { 1, "Employee" }, { 2, "Depositor" }, { 3, "Status" }, { 4, "Bank" } };

        protected override List<string> GetStat() => new List<string> { $"Количество банков: {((IEnumerable<Deposit>)GetStatObj()).Select(x => x.BankId).Distinct().Count()}", $"Количество вкладчиков: {((IEnumerable<Deposit>)GetStatObj()).Select(x => x.DepositorId).Distinct().Count()}", $"Количество работников: {((IEnumerable<Deposit>)GetStatObj()).Select(x => x.EmployeeId).Distinct().Count()}" };

        protected override object GetStatObj()
        {
            var objects = depositService.GetDeposits();
            if (HttpContext.Request.Method == "POST")
            {
                if (HttpContext.Request.Form.ContainsKey("0") && HttpContext.Request.Form["0"] != "")
                {
                    objects = objects.Where(x => x.DepositId.ToString() == HttpContext.Request.Form["0"]);
                }
                if (HttpContext.Request.Form.ContainsKey("1") && HttpContext.Request.Form["1"] != "")
                {
                    objects = objects.Where(x => employeeService.GetEmployeeById(x.EmployeeId).NameOfEmployee == HttpContext.Request.Form["1"]);
                }
                if (HttpContext.Request.Form.ContainsKey("2") && HttpContext.Request.Form["2"] != "")
                {
                    objects = objects.Where(x => depositorService.GetDepositorById(x.DepositorId).NameOfDepositor == HttpContext.Request.Form["2"]);
                }
                if (HttpContext.Request.Form.ContainsKey("3") && HttpContext.Request.Form["3"] != "")
                {
                    objects = objects.Where(x => statusService.GetStatusById(x.StatusId).NameOfStatus == HttpContext.Request.Form["3"]);
                }
                if (HttpContext.Request.Form.ContainsKey("4") && HttpContext.Request.Form["4"] != "")
                {
                    objects = objects.Where(x => bankService.GetBankById(x.BankId).NameOfBank == HttpContext.Request.Form["4"]);
                }
                if (HttpContext.Request.Form.ContainsKey("5") && HttpContext.Request.Form["5"] != "")
                {
                    objects = objects.Where(x => x.Percent.ToString() == HttpContext.Request.Form["5"]);
                }
                if (HttpContext.Request.Form.ContainsKey("6") && HttpContext.Request.Form["6"] != "")
                {
                    objects = objects.Where(x => x.Description.ToString() == HttpContext.Request.Form["6"]);
                }
            }
            return objects;
        }

        protected override object GetNames() => new Dictionary<int, string[]> {
            { 1, depositService.GetDeposits().Where(x => GetObjects().Select(y => y[0]).Contains(x.DepositId.ToString())).Select(x => employeeService.GetEmployeeById(x.EmployeeId).NameOfEmployee).ToArray() } ,
            { 2, depositService.GetDeposits().Where(x => GetObjects().Select(y => y[0]).Contains(x.DepositId.ToString())).Select(x => depositorService.GetDepositorById(x.DepositorId).NameOfDepositor).ToArray() } ,
            { 3, depositService.GetDeposits().Where(x => GetObjects().Select(y => y[0]).Contains(x.DepositId.ToString())).Select(x => statusService.GetStatusById(x.StatusId).NameOfStatus).ToArray() } ,
            { 4, depositService.GetDeposits().Where(x => GetObjects().Select(y => y[0]).Contains(x.DepositId.ToString())).Select(x => bankService.GetBankById(x.BankId).NameOfBank).ToArray() }
        };
    }
}
