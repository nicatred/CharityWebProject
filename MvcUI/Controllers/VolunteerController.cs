using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcUI.Controllers
{
    public class VolunteerController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Page = "volunteer";
            return View("_Volunteer");
        }
    }
}
