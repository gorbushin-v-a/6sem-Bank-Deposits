using BLL.Interfaces;
using Microsoft.Extensions.Logging;
using sharps_ent.Entity;
using System.Collections.Generic;
using System.Linq;

namespace sharps_ent.Controllers
{
    public sealed class BranchController : GenericController
    {

        private readonly IBranchService branchService;
        private readonly IBankService bankService;
        private readonly IStreetService streetService;
        public BranchController(ILogger<GenericController> logger, IBranchService branchService, IBankService bankService, IStreetService streetService) : base(logger)
        {
            this.branchService = branchService;
            this.bankService = bankService;
            this.streetService = streetService;
        }

        public override string[] Labels => new string[] { "Bank", "Street" };

        protected override void AddObject()
        {
            var @object = new Branch
            {
                BankId = int.Parse(HttpContext.Request.Form["1"]),
                StreetId = int.Parse(HttpContext.Request.Form["2"]),
            };
            branchService.CreateBranch(@object);
        }

        protected override string[][] GetObjects(bool id = false)
        {
            var objects = branchService.GetBranches();
            if (HttpContext.Request.Method == "POST")
            {
                if (id)
                {
                    objects = objects.Where(x => x.BranchId.ToString() == HttpContext.Request.Form["id"]);
                }
                else
                {
                    if (HttpContext.Request.Form.ContainsKey("0") && HttpContext.Request.Form["0"] != "")
                    {
                        objects = objects.Where(x => x.BranchId.ToString() == HttpContext.Request.Form["0"]);
                    }
                    if (HttpContext.Request.Form.ContainsKey("1") && HttpContext.Request.Form["1"] != "")
                    {
                        objects = objects.Where(x => bankService.GetBankById(x.BankId).NameOfBank.ToString() == HttpContext.Request.Form["1"]);
                    }
                    if (HttpContext.Request.Form.ContainsKey("2") && HttpContext.Request.Form["2"] != "")
                    {
                        objects = objects.Where(x => streetService.GetStreetById(x.StreetId).NameOfStreet.ToString() == HttpContext.Request.Form["2"]);
                    }
                }
            }
            var cells = objects.Select(x => new string[] {
                x.BranchId.ToString(), x.BankId.ToString(), x.StreetId.ToString()
            }).ToArray();
            return cells;
        }

        protected override void UpdateObject()
        {
            var @object = branchService.GetBranchById(int.Parse(HttpContext.Request.Form["0"]));
            @object.BankId = int.Parse(HttpContext.Request.Form["1"]);
            @object.StreetId = int.Parse(HttpContext.Request.Form["2"]);
            branchService.UpdateBranch(@object);
        }

        protected override void RemoveObject()
        {
            branchService.DeleteBranch(branchService.GetBranchById(int.Parse(HttpContext.Request.Form["id"])));
        }
        protected override Dictionary<int, string> GetAttributes() => new Dictionary<int, string>() { { 1, "Bank" }, { 2, "Street" } };

        protected override object GetNames() => new Dictionary<int, string[]> { 
            { 1, branchService.GetBranches().Where(x => GetObjects().Select(y => y[0]).Contains(x.BranchId.ToString())).Select(x => bankService.GetBankById(x.BankId).NameOfBank).ToArray() } ,
            { 2, branchService.GetBranches().Where(x => GetObjects().Select(y => y[0]).Contains(x.BranchId.ToString())).Select(x => streetService.GetStreetById(x.StreetId).NameOfStreet).ToArray() }
        };
    }
}
