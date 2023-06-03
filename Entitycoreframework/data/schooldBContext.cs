using Entitycoreframework.module;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitycoreframework.data
{
   
    public  class schooldBContext: DbContext
    {
        public DbSet<student> student { get; set; } = null!;
        public DbSet<staff> staff { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-VQ226Q4\SQLEXPRESS;Initial Catalog=SchoolDB;Integrated Security=true;TrustServerCertificate=True;");
        }
    }
}
