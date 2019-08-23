using OrderWebApp.BLL.BLL;
using OrderWebApp.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderWebApp.Controllers
{
    public class OrderController : Controller
    {
        MemberManager _memberManager = new MemberManager();
        OrderManager _orderManager = new OrderManager();
        FoodManager _foodManager = new FoodManager();
        // GET: Order

        public  ActionResult Add()
        {
            var order = new Order();

            //ViewBag.Members = _memberManager.GetAll().ToList();


            order.MemberList = _memberManager.GetAll().Select(s => new SelectListItem
            {
                Value = s.ID.ToString(),
                Text = s.Code

            }).ToList();


            ViewBag.FoodList = _orderManager.GetAll().ToList();


            return View(order);
        }

        [HttpPost]
      
        public ActionResult Add(Order order)
        {
            order.MemberList = _memberManager.GetAll().Select(s => new SelectListItem
            {
                Value = s.ID.ToString(),
                Text = s.Code

            }).ToList();


            ViewBag.FoodList = _orderManager.GetAll().ToList();


            if (order.OrderDetailses != null && order.OrderDetailses.Count > 0)
            {


                var isAdded = _orderManager.Add(order);
                if (isAdded)
                {
                    ViewBag.SMsg = "Reservation Success";
                    return View(order);
                }
            }
            ViewBag.FMsg = "Purchase Failed";
            return View(order);
        }

         

        public ActionResult GetByID(int id)
        {
          var Results=  _memberManager.GetByID(id);
            return Json(Results,JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetByFoodID(int foodid)
        {
            var foods = _foodManager.GetByFoodID(foodid);
            return Json(foods, JsonRequestBehavior.AllowGet);
        }
    }
}