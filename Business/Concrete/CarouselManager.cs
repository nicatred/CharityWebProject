using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarouselManager : ICarouselService
    {
        private ICarouselDal _carouselDal;
        public CarouselManager(ICarouselDal carouselDal)
        {
            _carouselDal = carouselDal;
        }

        public async Task Add(CarouselItem carouselItem)
        {
            _carouselDal.Add(carouselItem);
        }

        public Task<List<CarouselItem>> GetAllAsync()
        {
            return  _carouselDal.GetAllAsync();
        }

        public async Task Delete(CarouselItem carouselItem)
        {
            _carouselDal.Delete(carouselItem);
        }

        public async Task<CarouselItem> GetByIdAsync(int carouselId)
        {
            return await _carouselDal.GetAsync(e => e.Id == carouselId);
        }

        public async Task Update(CarouselItem carouselItem)
        {
            _carouselDal.Update(carouselItem);
        }

        public async Task<List<CarouselViewModel>> GetCarouselHome()
        {
            return await _carouselDal.GetCarosuelForHome();
        }

       
    }
}
