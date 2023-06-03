using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitycoreframework.module
{
    
    public  class staff
    {

        [Key]
        public int Id { get; set; }
        public string staffname { get; set; }
        public double salary { get; set; }
    }
}
