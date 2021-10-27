using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcUI.Controllers
{
    public class TestimonialController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Page = "testimonial";
            return View("_Testimonial");
        }
    }
}
