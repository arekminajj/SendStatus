using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SendStatus.Services;

namespace SendStatus.Controllers
{
    public class StatusController : Controller
    {
        private readonly IMongoService _service;
        public StatusController(IMongoService service)
        {
            _service = service;
        }

        public IActionResult Index(string lineOne, string lineTwo)
        {
            return View();
        }

        public IActionResult Update(string lineOne, string lineTwo)
        {
            _service.SendUpdate(lineOne, lineTwo);

            return RedirectToAction("ThankYou", "Status");
        }
        public IActionResult ThankYou()
        {
            return View();
        }
    }
}