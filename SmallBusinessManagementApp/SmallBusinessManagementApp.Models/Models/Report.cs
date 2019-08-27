using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallBusinessManagementApp.Models.Models
{
    public class Report
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }

        public int CP { get; set; }
        public int MRP { get; set; }
        public int Profit { get; set; }
        [DataType(DataType.Date)]
        public DateTime Startdate { get; set; }
        [DataType(DataType.Date)]
        public DateTime Enddate { get; set; }

  
   

    }
}
