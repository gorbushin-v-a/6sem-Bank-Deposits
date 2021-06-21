using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace sharps_ent.Controllers
{
    public abstract class GenericController : Controller
    {

        private readonly ILogger<GenericController> _logger;
        public abstract string[] Labels { get; }

        public GenericController(ILogger<GenericController> logger)
        {
            _logger = logger;
        }

        public IActionResult AddRequestAction()
        {
            try
            {
                return View("~/Views/Generic/Request.cshtml",
                    new object[] { new string[] { "Id" }.Concat(Labels).ToArray(),
                    new string[] { "AddResponceAction" }
                    });
            }
            catch
            {
                return Ok("Ошибка во входных данных!");
            }
        }

        [HttpPost]
        public IActionResult AddResponceAction()
        {
            try
            {
                AddObject();
                _logger.LogInformation($"Added entity from {this.GetType().Name}");
                return Redirect(HttpContext.Request.Path.Value + "\\..\\GetResponceAction2");
            }
            catch
            {
                return Ok("Ошибка во входных данных!");
            }
        }

        public IActionResult UpdateRequestAction()
        {
            try
            {
                return View("~/Views/Generic/Request.cshtml",
                    new object[] { new string[] { "Id" }.Concat(Labels).ToArray(),
                    new string[] { "UpdateResponceAction" },
                    GetObjects(id: true).FirstOrDefault()
                    });
            }
            catch
            {
                return Ok("Ошибка во входных данных!");
            }
        }

        public IActionResult UpdateResponceAction()
        {
            try
            {
                UpdateObject();
                _logger.LogInformation($"Updated entity from {this.GetType().Name}");
                return Redirect(HttpContext.Request.Path.Value + "\\..\\GetResponceAction2");
            }
            catch
            {
                return Ok("Ошибка во входных данных!");
            }
        }

        public IActionResult GetRequestAction()
        {
            try
            {
                return View("~/Views/Generic/Request.cshtml",
                    new object[] { new string[] { "Id" }.Concat(Labels).ToArray(),
                    new string[] { "GetResponceAction" }
                    });
            }
            catch
            {
                return Ok("Ошибка во входных данных!");
            }
        }

        [HttpPost]
        public IActionResult GetResponceAction()
        {
            try
            {
                return View("~/Views/Generic/Responce.cshtml",
                    new object[] { new string[] { "Id" }.Concat(Labels).ToArray(),
                    GetObjects(),
                    GetAttributes(),
                    GetStat(),
                    GetNames()
                    });
            }
            catch
            {
                return Ok("Ошибка во входных данных!");
            }
        }

        public IActionResult GetResponceAction2()
        {
            try
            {
                return View("~/Views/Generic/Responce.cshtml",
                    new object[] { new string[] { "Id" }.Concat(Labels).ToArray(),
                    GetObjects(),
                    GetAttributes(),
                    GetStat(),
                    GetNames()
                    });
            }
            catch
            {
                return Ok("Ошибка во входных данных!");
            }
        }

        [HttpPost]
        public IActionResult DeleteResponceAction()
        {
            try
            {
                RemoveObject();
                _logger.LogInformation($"Deleted entity from {this.GetType().Name}");
                return View("~/Views/Generic/Responce.cshtml",
                    new object[] { new string[] { "Id" }.Concat(Labels).ToArray(),
                    GetObjects(),
                    GetAttributes(),
                    GetStat(),
                    GetNames()
                    });
            }
            catch
            {
                return Ok("Ошибка во входных данных!");
            }
        }

        protected abstract void AddObject();
        protected abstract string[][] GetObjects(bool id = false);
        protected abstract void UpdateObject();
        protected abstract void RemoveObject();
        protected virtual Dictionary<int, string> GetAttributes() => null;
        protected virtual List<string> GetStat() => null;
        protected virtual object GetStatObj() => null;
        protected virtual object GetNames() => null;
    }
}
