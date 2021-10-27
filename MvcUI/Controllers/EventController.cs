using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcUI.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Page = "event";
            return View("_Event");
        }
    }
}
