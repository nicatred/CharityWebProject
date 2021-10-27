using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcUI.Controllers
{
    public class CausesController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Page = "causes";
            return View("_Causes");
        }
    }
}
