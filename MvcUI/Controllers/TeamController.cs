using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcUI.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Page = "team";
            return View("_Team");
        }
    }
}
