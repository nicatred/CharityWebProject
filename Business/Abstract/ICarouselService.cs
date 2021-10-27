using Entities.Concrete;
using Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarouselService
    {
        Task<List<CarouselItem>> GetAllAsync();
        Task<CarouselItem> GetByIdAsync(int carouselId);
        Task Add(CarouselItem carouselItem);
        Task Delete(CarouselItem carouselItem);
        Task Update(CarouselItem carouselItem);
        Task<List<CarouselViewModel>> GetCarouselHome();
       
    }
}
