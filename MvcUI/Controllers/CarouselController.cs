using AutoMapper;
using Business.Abstract;
using Entities.Concrete;
using Entities.ViewModels;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcUI.Controllers
{
    public class CarouselController : Controller
    {
        private ICarouselService _carouselService;
        private IMapper _mapper;

        public CarouselController(ICarouselService carouselService, IMapper mapper)
        {
            _carouselService = carouselService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel();
            homeViewModel.CarouselViewModel = await _carouselService.GetCarouselHome();
           
            return View(homeViewModel);
        }
    }
}
