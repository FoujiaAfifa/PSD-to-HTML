using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderWebApp.Models.Models
{
    public class OrderDetails
    {
        public int ID { get; set; }

        public string Code { get; set; }
   
        public string Name { get; set; }

        public string Email { get; set; }

        public string Contact { get; set; }

        [DisplayName("Unit Price")]
        public int UnitPrice { get; set; }

        public int Quantity { get; set; }

        public DateTime Date { get; set; }

        public int OrderID { get; set; }
        public virtual Order Order { get; set; }
    }
}
