using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class AboutOptions:BaseEntity,IEntity
    {
        public string Title { get; set; }
        public string About { get; set; }
        public string Mission { get; set; }
        public string Image { get; set; }
    }
}
