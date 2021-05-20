using ASP_PROJECT.DAL.IDAL;
using ASP_PROJECT.Models.POCO;
using ASP_PROJECT.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.Controllers
{
    public class OrderController : Controller
    {
        private readonly IMenuDAL _menuDAL;
        private readonly IOrderDAL _orderDAL;
        private readonly IAccountDAL _accountDAL;

        public OrderController(IMenuDAL menuDAL, IOrderDAL orderDAL,IAccountDAL accountDAL)
        {
            _menuDAL = menuDAL;
            _orderDAL = orderDAL;
            _accountDAL = accountDAL;

        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ConsultRestaurantOrders()
        {
            //get restorer informations and orders 
            RestaurantOrderViewModel vm = new RestaurantOrderViewModel();
            Restaurant resto = new Restaurant();
            resto.Id = 1;
            List<Order> RestaurantOrders = Order.GetRestaurantOrders(resto,_orderDAL,_menuDAL,_accountDAL);
            vm.Restaurant.OrdersList = RestaurantOrders;
            return View("ConsultRestaurantOrders",vm);
        }

        public IActionResult ModifyOrderStatus(string OrderIdStatus)
        {
            //modifier en db
            
            return RedirectToAction("ConsultRestaurantOrders");
        }
    }
}
