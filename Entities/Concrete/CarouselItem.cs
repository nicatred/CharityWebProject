using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CarouselItem: BaseEntity, IEntity
    {
        public string Image { get; set; }
        public string Video { get; set; }
        public string Title { get; set; }
        public string CarouselText { get; set; }
        public int NeedyPersonId { get; set; }
        public NeedyPerson NeedyPerson { get; set; }
    }
}
