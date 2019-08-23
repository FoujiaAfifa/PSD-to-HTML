using OrderWebApp.Models.Models;
using OrderWebApp.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderWebApp.BLL.BLL
{
    public class FoodManager
    {
        FoodRepository _foodRepository = new FoodRepository();
        public List<Food> GetByFoodID(int foodid)
        {
            return _foodRepository.GetByFoodID(foodid);
        }
    }
}
