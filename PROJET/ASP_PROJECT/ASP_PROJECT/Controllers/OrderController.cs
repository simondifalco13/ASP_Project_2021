using ASP_PROJECT.DAL.IDAL;
using ASP_PROJECT.Models.POCO;
using ASP_PROJECT.ViewModels;
using Microsoft.AspNetCore.Http;
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
        private readonly IRestaurantDAL _restaurantDAL;

        public OrderController(IMenuDAL menuDAL, IOrderDAL orderDAL,IAccountDAL accountDAL,IRestaurantDAL restaurantDAL)
        {
            _menuDAL = menuDAL;
            _orderDAL = orderDAL;
            _accountDAL = accountDAL;
            _restaurantDAL = restaurantDAL;

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
        
        public IActionResult ConsultCustomerOrders()
        {
            CustomerOrderViewModel vm = new CustomerOrderViewModel();
            //en brut a modifier
            Customer customer = new Customer();
            customer.Id = 1;
            List<Order> CustomerOrders = Order.GetCustomerOrders(customer, _orderDAL, _menuDAL, _restaurantDAL);
            vm.Customer.OrdersList = CustomerOrders;
            return View("ConsultCustomerOrders",vm);
        }

        public IActionResult ModifyOrderStatus(string OrderIdStatus)
        {
            //modifier en db
            
            return RedirectToAction("ConsultRestaurantOrders");
        }

        [HttpPost]
        public IActionResult AddMenuToCart(int menuId)
        {
            Order order = new Order();

            if (HttpContext.Session.GetString("MenusId") != null)
            {
                string sessionMenusIds = HttpContext.Session.GetString("MenusId");
                sessionMenusIds += ";" + menuId.ToString();
                HttpContext.Session.SetString("MenusId", sessionMenusIds);
                string[] menusIdsSplited = sessionMenusIds.Split(";");

                foreach (var item in menusIdsSplited)
                {
                    int id = Int32.Parse(item);

                    Menu menuAdded = Menu.GetMenuById(id, _menuDAL);
                    order.listMenuOrdered.Add(menuAdded);
                }
            }
            else
            {
                Menu menuAdded = Menu.GetMenuById(menuId, _menuDAL);
                order.listMenuOrdered.Add(menuAdded);

                HttpContext.Session.SetString("MenusId", menuId.ToString());
            }

            return View("Views/Restaurant/ConsultRestaurantMenuDish.cshtml", order);
        }

        public IActionResult AddDishToCart(int dishId)
        {
           //si la variable de session OrderExists= true, si pas on la crée , on crée par la meme occasion DishesOrder="" et MenusOrder="" 
           if(HttpContext.Session.GetString("OrderExist")== "true")
            {
                if (HttpContext.Session.GetString("DishesOrder") != "")
                {
                    string sessionDishesIds = HttpContext.Session.GetString("DishesOrder");
                    sessionDishesIds += ";" + dishId.ToString();
                    HttpContext.Session.SetString("DishesOrder", sessionDishesIds);
                }
                else
                {
                    HttpContext.Session.SetString("DishesOrder", dishId.ToString());

                }
            }
            
            int restoId =(int) HttpContext.Session.GetInt32("restaurantId");
            // retourner vers action qui va sur cette vue , mais pour le customer
            return RedirectToAction("ConsultAll", "Restaurant", new { restaurantId = restoId });
        }

        public IActionResult ConsultCart(Order order)
        {
          
            //verification que user est connecté 
            //envoit un objet order, la vue sera basée sur un objet order => recuperer le customer par l'id et le restaurant par l'id, aussi les dishes et menu
            //via les variables de session et donc en appelant les méthodes des pocos 
            int customerId = (int)HttpContext.Session.GetInt32("CustomerId");
            Customer customer = Customer.GetCustomerById(_accountDAL, customerId);
            //traitement des id dans la variable de session ==> dans un tableau
            List<Dish> DishesInOrder = new List<Dish>();
            //foreach (var dishId in sessionDishesId)
            //{
            //    Dish Dish = Dish.GetDishById(_menuDAL,dishId);
            //    DishesInOrder.Add(Dish);
            //}
            order.listDishOrdered = DishesInOrder;

            return View("Views/Order/ConsultCart.cshtml",order);
        }
        public IActionResult ValidateOrder()
        {




            TempData["StatutOrder"] = "OK";
            TempData["StatutOrder"] = "NOTOK";

            return View("Views/Restaurant/ConsultRestaurantMenuDish.cshtml");
        }

    }

}
