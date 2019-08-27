using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SmallBusinessManagementApp.Models.Models.Purchase
{
   public class PurchaseDetails
    {
       public int Id { get; set; }
    
       public string Code { get; set; }

       [DisplayName("Manufactured Date")]
       public string ManufacturedDate { get; set; }

       [DisplayName("Expired Date")]
       public string ExpiredDate { get; set; }

       [DisplayName("Purchase Quantity")]
       public int PurchaseQuantity  { get; set; }
       [DisplayName("Unit Price")]
       public int UnitPrice { get; set; }
       [DisplayName("Total Price")]
       public int TotalPrice { get; set; }
       [DisplayName("Previous MRP")]
       public int PreviousMRP { get; set; }
       public int PurchaseId { get; set; }

       [DisplayName("New MRP")]
       public int NewMRP { get; set; }
       public int ProductId { get; set; }
       public virtual Product Product { get; set; }
       public virtual Purchase Purchase { get; set; }

       

       
    }
}
