using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL1.DbContext
{

    [Table("Cars")]
    public class Car
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        /*  public string Brand { get; set; }
          public string Code { get; set; }*/
    }
}
