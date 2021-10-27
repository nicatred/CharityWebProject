using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class SosialAccount:BaseEntity,IEntity
    {
        public string AccountFacebook { get; set; }
        public string AccountInstagram { get; set; }
        public string AccountYoutube { get; set; }
        public string AccountLinkedin { get; set; }

    }
}
