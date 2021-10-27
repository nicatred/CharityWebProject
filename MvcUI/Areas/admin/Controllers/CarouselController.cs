using Business.Abstract;
using Entities.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcUI.Areas.admin.Controllers
{
    [Area("admin")]
    public class CarouselController : Controller
    {
        private ICarouselService _carouselService;
        public CarouselController(ICarouselService carouselService)
        {
            _carouselService = carouselService;
        }
        public async Task<IActionResult> Index()
        {
           List<CarouselViewModel> carouselViewModels = await _carouselService.GetCarouselHome();

            return View(carouselViewModels);
        }
        [HttpGet]
        public async Task<IActionResult> New()
        {
            return View("_CarouselCrud");
        }
        [HttpPut]
        public async Task<IActionResult> Update()
        {

            return View("_CarouselCrud");
        }
        [HttpDelete]
        public async Task<IActionResult> Delete()
        {
            return View();
        }
    }
}
