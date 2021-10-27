using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class NeedyPersonInfo:BaseEntity,IEntity
    {
        public  string  Name { get; set; }
        public string  SureName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public NeedyPerson NeedyPerson { get; set; }
    }
}
