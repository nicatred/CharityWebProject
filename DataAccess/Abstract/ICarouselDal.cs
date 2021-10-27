using Entities.Concrete;
using Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarouselDal:IEntityRepository<CarouselItem>
    {
        Task<List<CarouselViewModel>> GetCarosuelForHome();
    }
}
