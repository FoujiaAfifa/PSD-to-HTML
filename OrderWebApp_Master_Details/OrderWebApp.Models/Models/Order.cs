using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace OrderWebApp.Models.Models
{
    public class Order
    {
        public int ID { get; set; }

        public int MemberID { get; set; }

        public virtual Member Member { get; set; }

        public int MemberTypeID { get; set; }
        public virtual MemberType MemberType { get; set; }

        public int FoodID { get; set; }

        public virtual Food Food { get; set; }
        [NotMapped]
        public virtual List<Member> Memberses { get; set; }

        [NotMapped]
        public virtual List<SelectListItem> FoodList { get; set; }

        public virtual List<OrderDetails> OrderDetailses { get; set; }

        [NotMapped]
        public virtual OrderDetails OrderDetails { get; set; }

        [NotMapped]
        public virtual IEnumerable<SelectListItem> MemberList { get; set; }

        public int Qunatity { get; set; }

        public DateTime Date { get; set; }
    }
}
