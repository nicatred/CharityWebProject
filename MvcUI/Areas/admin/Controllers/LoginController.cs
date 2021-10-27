using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcUI.Areas.admin.Controllers
{
    [Area("admin")]

    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
