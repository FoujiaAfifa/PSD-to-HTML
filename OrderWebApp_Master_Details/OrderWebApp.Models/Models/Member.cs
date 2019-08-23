using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace OrderWebApp.Models.Models
{
   public class Member
    {
        public int ID { get; set; }
        [Required]
        [StringLength(7,MinimumLength =5)]
        public  string Code { get; set; }
        [Required]
        public  string Name { get; set; }
        [Required]
        public  string Email { get; set; }
        [Required]
        public  string Contact { get; set; }
        public  int MemberTypeID { get; set; }
        public virtual MemberType MemberType { get; set; }

        [NotMapped]
        public virtual List<SelectListItem> TypeList { get; set; }

        [NotMapped]
        public virtual IEnumerable<SelectListItem> MemberList { get; set; }
    }
}
