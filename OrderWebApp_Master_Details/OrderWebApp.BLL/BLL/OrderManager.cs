using OrderWebApp.Models.Models;
using OrderWebApp.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderWebApp.BLL.BLL
{
   public class OrderManager
    {
        OrderRepository _orderRepository = new OrderRepository();
        public List<Food> GetAll()
        {
            return _orderRepository.GetAll();
        }

        public bool Add(Order order)
        {
            return _orderRepository.Add(order);
        }

    }
}
