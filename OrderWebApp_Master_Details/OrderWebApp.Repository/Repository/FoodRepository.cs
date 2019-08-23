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
    public class FoodRepository
    {
        OrderDbContext _db = new OrderDbContext();
        public List<Food> GetByFoodID(int foodid)
        {
            return _db.Foods.Where(c => c.ID == foodid).ToList();
        }

 
    }
}
