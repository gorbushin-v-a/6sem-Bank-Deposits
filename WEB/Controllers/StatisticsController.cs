using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;
using System.Text;

namespace sharps_ent.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly IBankService serviceBank;
        private readonly IBranchService serviceBranch;
        private readonly IDepositorService serviceDepositor;
        private readonly IEmployeeService serviceEmployee;
        private readonly IStreetService serviceStreet;
        private readonly ICityService serviceCity;
        private readonly ICountryService serviceCountry;
        private readonly ILogOfOperationsService serviceLog;
        private readonly IDepositService serviceDeposit;

        public StatisticsController(ILogOfOperationsService serviceLog, IEmployeeService serviceEmployee, IBranchService serviceBranch, IDepositorService serviceDepositor = null, IBankService serviceBank = null, IStreetService serviceStreet = null, ICityService serviceCity = null, ICountryService serviceCountry = null, IDepositService serviceDeposit = null)
        {
            this.serviceLog = serviceLog;
            this.serviceEmployee = serviceEmployee;
            this.serviceBranch = serviceBranch;
            this.serviceDepositor = serviceDepositor;
            this.serviceBank = serviceBank;
            this.serviceStreet = serviceStreet;
            this.serviceCity = serviceCity;
            this.serviceCountry = serviceCountry;
            this.serviceDeposit = serviceDeposit;
        }

        private string[][] GetStat()
        {
            return new string[][] {
                        new string[] { "Количество денег в банках", serviceLog.GetLogOfOperations().Select(x => x.Quantity).Sum().ToString() },
                        new string[] { "Количество банков", serviceBank.GetBanks().Count().ToString() },
                        new string[] { "Количество банковских отделений", serviceBranch.GetBranches().Count().ToString() },
                        new string[] { "Количество клиентов банков", serviceDepositor.GetDepositors().Count().ToString() },
                        new string[] { "Количество рабочих в банках", serviceEmployee.GetEmployees().Count().ToString() },
                        new string[] { "Количество улиц", serviceStreet.GetStreets().Count().ToString() },
                        new string[] { "Количество городов", serviceCity.GetCities().Count().ToString() },
                        new string[] { "Количество стран", serviceCountry.GetCountries().Count().ToString() },
                        new string[] { "Количество операций", serviceLog.GetLogOfOperations().Count().ToString() },
                        new string[] { "Количество вкладов", serviceDeposit.GetDeposits().Count().ToString() },
                    };
        }

        public ActionResult Show()
        {
            return View("~/Views/Statistics.cshtml",
                new object[] { new string[] { "Метрика", "Значение" },
                    GetStat()
                });
        }

        public ActionResult Download()
        {
            var memStream = new MemoryStream();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var streamWriter = new StreamWriter(memStream, Encoding.GetEncoding("windows-1251"));
            foreach (var fe in GetStat())
            {
                streamWriter.WriteLine($"{fe[0]};{fe[1]}");
            }
            streamWriter.Flush();
            memStream.Seek(0, SeekOrigin.Begin);
            string file_type = "application/csv";
            string file_name = "Stat.csv";
            return File(memStream, file_type, file_name);
        }
    }
}
