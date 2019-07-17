using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMVC.Models.Models;

namespace TestMVC.DatabaseContext.DatabaseContext
{
    public class StudentDbContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
