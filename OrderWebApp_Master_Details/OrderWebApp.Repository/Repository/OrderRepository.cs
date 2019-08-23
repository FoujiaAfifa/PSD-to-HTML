using OrderWebApp.DatabaseContext.DatabaseContext;
using OrderWebApp.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace OrderWebApp.Repository.Repository
{
   public class OrderRepository
    {
      private  OrderDbContext _db = new OrderDbContext();
        public List<Food> GetAll()
        {

            return _db.Foods.ToList();
        }

        public List<SelectListItem> GetDefaultSelectListItem()
        {
            var dataList = new List<SelectListItem>();
            var defaultSelectListItem = new SelectListItem();
            defaultSelectListItem.Text = "---Select---";
            defaultSelectListItem.Value = "";
            dataList.Add(defaultSelectListItem);
            return dataList;
        }


        public bool Add(Order order)
        {
            bool isSaved = false;
            _db.Orders.Add(order);
            int Saved = _db.SaveChanges();

            if (Saved > 0)
            {
                isSaved = true;
            }

            return isSaved;
        }
    }
}
