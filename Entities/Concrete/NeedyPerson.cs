using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class NeedyPerson: BaseEntity, IEntity
    {
        public string Title { get; set; }
        public string Info { get; set; }
        public string? Image { get; set; } 
        public string? Video { get; set; }
        
        public int NeedyPersonInfoId { get; set; }
        public NeedyPersonInfo NeedyPersonInfo { get; set; }
        public CarouselItem CarouselItem{ get; set; }
    }
}
