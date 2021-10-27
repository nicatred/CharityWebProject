using AutoMapper;
using Entities.Concrete;
using Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcUI.Mapper.AutoMapper
{
    public class MappingCarousel:Profile
    {
        public MappingCarousel()
        {
            CreateMap<CarouselItem, CarouselViewModel>();
        }
    }
}
