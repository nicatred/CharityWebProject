using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities.ViewModels
{
    public class CarouselViewModel
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Video { get; set; }
        public string Title { get; set; }
        public string CarouselText { get; set; }
        public int NeedyPersonId { get; set; }
        public string NeedyPersonNameSureName { get; set; }

    }

}
