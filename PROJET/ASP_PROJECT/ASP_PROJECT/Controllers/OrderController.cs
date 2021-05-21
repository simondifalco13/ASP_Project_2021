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
        //


        [HttpPost]
        public IActionResult AddMenuToCart(int menuId) {
            Order order = new Order();

            if (HttpContext.Session.GetString("MenusId") != null) {
                string sessionMenusIds = HttpContext.Session.GetString("MenusId");
                sessionMenusIds += ";" + menuId.ToString();
                HttpContext.Session.SetString("MenusId", sessionMenusIds);
                string[] menusIdsSplited = sessionMenusIds.Split(";");

                foreach (var item in menusIdsSplited) {
                    int id = Int32.Parse(item);

                    Menu menuAdded = Menu.GetMenuById(id, _menuDAL);
                    order.listMenuOrdered.Add(menuAdded);
                }
            } else {
                Menu menuAdded = Menu.GetMenuById(menuId, _menuDAL);
                order.listMenuOrdered.Add(menuAdded);

                HttpContext.Session.SetString("MenusId", menuId.ToString());
            }

            return View("Views/Restaurant/ConsultRestaurantMenuDish.cshtml",order);
        }

        [HttpPost]
        public IActionResult AddDishToCart(int dishId) {
            Order order = new Order();

            if (HttpContext.Session.GetString("DishesId") != null) {
                string sessionDishesIds = HttpContext.Session.GetString("MenusId");
                sessionDishesIds += ";" + dishId.ToString();
                HttpContext.Session.SetString("DishesId", sessionDishesIds);
                string[] dishesIdsSplited = sessionDishesIds.Split(";");

                foreach (var item in dishesIdsSplited) {
                    int id = Int32.Parse(item);

                    Dish dishAdded = Dish.GetDishById(id, _menuDAL);
                    
                    order.listDishOrdered.Add(dishAdded);
                }
            } else {
                Dish dishAdded = Dish.GetDishById(dishId, _menuDAL);
                order.listDishOrdered.Add(dishAdded);

                HttpContext.Session.SetString("MenusId", dishId.ToString());
            }

            return View("Views/Restaurant/ConsultRestaurantMenuDish.cshtml", order);
        }

        public IActionResult ConsultCart(Order order) {

            // ?? 
            return View("Views/Order/ConsultCart.cshtml");
        }
        public IActionResult ValidateOrder() {

            


            TempData["StatutOrder"] = "OK";
            TempData["StatutOrder"] = "NOTOK";

            return View("Views/Restaurant/ConsultRestaurantMenuDish.cshtml");
        }
    }
}
