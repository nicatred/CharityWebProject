using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Causes:BaseEntity,IEntity
    {
        public string Title { get; set; }
        public decimal Goal { get; set; }
        public decimal Raised { get; set; }
        public string Info { get; set; }
        public int NeedyPersonId { get; set; }
        public NeedyPerson NeedyPerson { get; set; }
    }
}
