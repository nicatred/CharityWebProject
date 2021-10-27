using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public abstract class BaseEntity
    {
        [Column(Order =1)]
        public int Id { get; set; }
        [Column(Order =2)]
        public DateTime AddedDate { get; set; }
        [Column(Order =3)]
        public DateTime ModifiedDate { get; set; }
        [Column(Order = 4)]
        public string AddedBy { get; set; }
        [Column(Order = 5)]
        public string ModifiedBy { get; set; }
    }
}
