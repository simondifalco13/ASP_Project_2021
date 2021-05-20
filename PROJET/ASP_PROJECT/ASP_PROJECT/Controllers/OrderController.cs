using ASP_PROJECT.DAL.IDAL;
using ASP_PROJECT.Models.POCO;
using ASP_PROJECT.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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
    ////    // eSPACE TEST
    ////    public IActionResult AddToCartTest() {

    ////        Restaurant r = new Restaurant();
    ////        r.Id = 1;
    ////        List<Dish> ld = Dish.GetDishes(r, _menuDAL);
    ////        ListDishViewModel vm = new ListDishViewModel(ld);
    ////        return View("Views/Order/ZTestDishPanier.cshtml",vm);
    ////    }
    ////    public void AddToCartTest2(Dish dish) {
   
    ////        if (String.IsNullOrEmpty(HttpContext.Session.GetString("DishAdded"))) {
    ////            HttpContext.Session.SetObjectAsJson("test", dish);
    ////        }
    ////    }
        
    ////    public IActionResult CheckCart() {

    ////        return View();
    ////    }

    ////    public static void SetObjectAsJson(this ISession session, string key, object value) {
    ////        session.SetString(key, JsonConvert.SerializeObject(value));
    ////    }

    ////    public static T GetObjectFromJson<T>(this ISession session, string key) {
    ////        var value = session.GetString(key);
    ////        return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
    ////    }
       
    ////}
}
