using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class SiteOptions: BaseEntity, IEntity
    {
        public string Icon { get; set; }
        public string Title { get; set; }
        public string ContactNumber { get; set; }
        public string ContactMail { get; set; }    
        public string Adress { get; set; }
        public SosialAccount SosialAccount { get; set; }
    }
}
