using BLL.Interfaces;
using Microsoft.Extensions.Logging;
using sharps_ent.Entity;
using System.Linq;

namespace sharps_ent.Controllers
{
    public sealed class BankController : GenericController
    {

        private readonly IBankService bankService;
        public BankController(ILogger<GenericController> logger, IBankService bankService) : base(logger)
        {
            this.bankService = bankService;
        }

        public override string[] Labels => new string[]{ "NameOfBank", "Information" };

        protected override void AddObject()
        {
            var @object = new Bank
            {
                NameOfBank = HttpContext.Request.Form["1"],
                Information = HttpContext.Request.Form["2"],
            };
            bankService.CreateBank(@object);
        }

        protected override string[][] GetObjects(bool id = false)
        {
            var objects = bankService.GetBanks();
            if (HttpContext.Request.Method == "POST")
            {
                if (id)
                {
                    objects = objects.Where(x => x.BankId.ToString() == HttpContext.Request.Form["id"]);
                }
                else
                {
                    if (HttpContext.Request.Form.ContainsKey("0") && HttpContext.Request.Form["0"] != "")
                    {
                        objects = objects.Where(x => x.BankId.ToString() == HttpContext.Request.Form["0"]);
                    }
                    if (HttpContext.Request.Form.ContainsKey("1") && HttpContext.Request.Form["1"] != "")
                    {
                        objects = objects.Where(x => x.NameOfBank == HttpContext.Request.Form["1"]);
                    }
                    if (HttpContext.Request.Form.ContainsKey("2") && HttpContext.Request.Form["2"] != "")
                    {
                        objects = objects.Where(x => x.Information == HttpContext.Request.Form["2"]);
                    }
                }
            }
            var cells = objects.Select(x => new string[] {
                x.BankId.ToString(), x.NameOfBank, x.Information
            }).ToArray();
            return cells;
        }

        protected override void UpdateObject()
        {
            var @object = bankService.GetBankById(int.Parse(HttpContext.Request.Form["0"]));
            @object.NameOfBank = HttpContext.Request.Form["1"];
            @object.Information = HttpContext.Request.Form["2"];
            bankService.UpdateBank(@object);
        }

        protected override void RemoveObject()
        {
            bankService.DeleteBank(bankService.GetBankById(int.Parse(HttpContext.Request.Form["id"])));
        }
    }
}
