using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitycoreframework.module
{
    
    public  class student
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public double fees { get; set; }
    }


}
