using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Team:BaseEntity,IEntity
    {
        public string Title { get; set; }
        public string Slogan { get; set; }
        public string FullName { get; set; }
        public string Specialty { get; set; }

    }
}
