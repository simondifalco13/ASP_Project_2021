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

        public IActionResult AddMenuToCart(int menuId){

            if (HttpContext.Session.GetString("OrderExist") == "true") {
                if (HttpContext.Session.GetString("MenusOrder") != "") {
                    string sessionMenusIds = HttpContext.Session.GetString("MenusOrder");
                    sessionMenusIds += ";" + menuId.ToString();
                    HttpContext.Session.SetString("MenusOrder", sessionMenusIds);
                } else {
                    HttpContext.Session.SetString("MenusOrder", menuId.ToString());
                }
            }
            int restoId = (int)HttpContext.Session.GetInt32("restaurantId");
            return RedirectToAction("ConsultAll", "Restaurant", new { restaurantId = restoId });
        }

        public IActionResult AddDishToCart(int dishId){
           if(HttpContext.Session.GetString("OrderExist")== "true"){
                if (HttpContext.Session.GetString("DishesOrder") != ""){
                    string sessionDishesIds = HttpContext.Session.GetString("DishesOrder");
                    sessionDishesIds += ";" + dishId.ToString();
                    HttpContext.Session.SetString("DishesOrder", sessionDishesIds);
                }else{
                    HttpContext.Session.SetString("DishesOrder", dishId.ToString());
                }
            }
            int restoId =(int) HttpContext.Session.GetInt32("restaurantId");
            return RedirectToAction("ConsultAll", "Restaurant", new { restaurantId = restoId });
        }

        public IActionResult ConsultCart(Order order){
 
            if (HttpContext.Session.GetString("customerConnected") == "true") {
                if (HttpContext.Session.GetString("DishesOrder") != "" || HttpContext.Session.GetString("MenusOrder") != "") {
                    int customerId = (int)HttpContext.Session.GetInt32("CustomerId");
                    Restaurant restaurant = new Restaurant();
                    restaurant.Id=(int)HttpContext.Session.GetInt32("restaurantId");

                    restaurant=Restaurant.GetRestaurantById(restaurant, _restaurantDAL);
                    Customer customer = Customer.GetCustomerById(_accountDAL, customerId);

                    //traitement des id dans la variable de session ==> dans un tableau
                    //List<Dish> DishesInOrder = new List<Dish>();
                    //List<Menu> MenusInOrder = new List<Menu>();

                    string sessionMenusIds = HttpContext.Session.GetString("MenusOrder");
                    string[] menusIdsSplited = sessionMenusIds.Split(";");

                    string sessionDishesIds = HttpContext.Session.GetString("DishesOrder");
                    string[] dishesIdsSplited = sessionDishesIds.Split(";");

                    foreach (var item in menusIdsSplited) {
                        int menuId = Int32.Parse(item);
                        Menu menuAdded = Menu.GetMenuById(menuId, _menuDAL);
                        order.listMenuOrdered.Add(menuAdded);
                    }

                    foreach (var dId in dishesIdsSplited) {
                        int dishId = Int32.Parse(dId);
                        Dish dishAdded = Dish.GetDishById(dishId, _menuDAL);
                        order.listDishOrdered.Add(dishAdded);
                    }
                    order.Customer = customer;
                    order.Restaurant = restaurant;
                   
                    //order.TotalPrice = CalculatePrice();
                } else {
                    TempData["Message"] = "Vide";
                    return View("Views/Order/ConsultCart.cshtml", order);
                }
            }
            return View("Views/Order/ConsultCart.cshtml",order);
        }
        // Plutôt dans la poco ???
        public double CalculatePrice(Order order) {


            return order.TotalPrice;
        }
        public IActionResult DeleteDishOrdered(int dishId) {
            // supprimer de la session

            return View("Views/Order/ConsultCart.cshtml");
        }
        public IActionResult DeleteMenuOrdered(int menuId) {
            // supprimer de la session 

            return View("Views/Order/ConsultCart.cshtml");
        }

        public IActionResult DeleteCart(Order order) {
            HttpContext.Session.SetString("MenusOrder", null);
            HttpContext.Session.SetString("DishesOrder", null);
            order = null;

            return View("Views/Order/ConsultCart.cshtml", order);
        }
        public IActionResult ValidateOrder(Order order){

            // Passer par un view model ?
            OrderViewModel vm = new OrderViewModel();
            //Commande validée
            order.Status = 0;
            // j'ai déjà dans l'objet order
            //Restaurant resto = new Restaurant();
            //resto.Id = (int)HttpContext.Session.GetInt32("restaurantId");

            //order.Restaurant = Restaurant.GetRestaurantById(resto,_restaurantDAL) ;

            TempData["StatutOrder"] = "OK";
            TempData["StatutOrder"] = "NOTOK";

            return View("Views/Restaurant/ConsultRestaurantMenuDish.cshtml");
        }

    }
}
