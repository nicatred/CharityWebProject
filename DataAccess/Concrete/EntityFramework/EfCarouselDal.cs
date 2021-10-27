using DataAccess.Abstract;
using Entities.Concrete;
using Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarouselDal : EfEntityRepository<CarouselItem, EfCoreDbContext>, ICarouselDal
    {
        
        public async Task<List<CarouselViewModel>> GetCarosuelForHome()
        {
            using (var context = new EfCoreDbContext())
            {
                var result = from item in context.CarouselItems
                             join person in context.NeedyPersons on item.NeedyPersonId equals person.Id
                             join info in context.NeedyPersonInfos on person.NeedyPersonInfoId equals info.Id
                             select new CarouselViewModel
                             {
                                 Id = item.Id,
                                 Image = item.Image,
                                 CarouselText = item.CarouselText,
                                 Title = item.Title,
                                 Video = item.Video,
                                 NeedyPersonId = item.NeedyPersonId,
                                 NeedyPersonNameSureName = info.Name + " " + info.SureName
                             };
                return  result.ToList();
            }
        }
    }
}
