using ASP_PROJECT.DAL.IDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.Models.POCO
{ 
    public enum OrderStatus
    {
        Validate,
        OnPreparation,
        //Retiré car manque de temps
        //OnDelivery,
        Finished
    }
    public class Order
    {

        public int Id { get; set; }

        public Customer Customer { get; set; }

        public Restaurant Restaurant { get; set; }

        public OrderStatus Status { get; set; }

        //public bool Delivery { get; set; }

        [Required(ErrorMessage = "Champs obligatoire")]
        [Display(Name = "Adresse de livraison")]
        public string DeliveryAdress { get; set; }

        [Display(Name = "Note")]
        public string Note { get; set; }

        [Display(Name = "Prix total")]
        public double TotalPrice { get; set; }

        [Display(Name = "Date de commande")]
        public DateTime DateOrder { get; set; }


        public List<Menu> listMenuOrdered;
        public List<Dish> listDishOrdered;

        public Order()
        {
            Customer = new Customer();
            Restaurant = new Restaurant();
            listMenuOrdered = new List<Menu>();
            listDishOrdered = new List<Dish>();
        }
        public Order(Restaurant resto,Customer customer) :this()
        {
            Restaurant = resto;
            Customer = customer;
        }
        public void DisplayOrder()
        {

        }
        public void ValidateOrder()
        {

        }
        public void CancelOrder()
        {

        }


        public void DisplayCart()
        {

        }

        public static List<Order> GetRestaurantOrders(Restaurant resto, IOrderDAL orderDAL, IMenuDAL menuDAL, IAccountDAL accountDAL)
        {
            List<Order> RestaurantOrders = orderDAL.GetRestaurantOrders(resto);
            //get details
            foreach (var order in RestaurantOrders)
            {
                List<int> MenuDetailsId = orderDAL.GetMenusIdInMenuDetails(order);
                List<int> DishDetailsId = orderDAL.GetDishesIdInMenuDetails(order);
                List<Meal> OrderMeals = new List<Meal>();
                Customer customer = accountDAL.GetCustomerById(order.Customer.Id);
                order.Customer = customer;
                foreach (var menuId in MenuDetailsId)
                {
                    OrderMeals.Add(menuDAL.GetMenuById(menuId));
                }
                foreach (var dishId in DishDetailsId)
                {
                    OrderMeals.Add(menuDAL.GetDishById(dishId));
                }
                foreach (var meal in OrderMeals)
                {
                    if (meal is Menu)
                    {
                        order.listMenuOrdered.Add(meal as Menu);
                    }
                    if (meal is Dish)
                    {
                        order.listDishOrdered.Add(meal as Dish);
                    }
                }
            }
            return RestaurantOrders;
        }

        public static List<Order> GetCustomerOrders(Customer customer, IOrderDAL orderDAL, IMenuDAL menuDAL, IRestaurantDAL restaurantDAL)
        {
            List<Order> CustomerOrders = orderDAL.GetCustomerOrders(customer);
            //get details
            foreach (var order in CustomerOrders)
            {
                List<int> MenuDetailsId = orderDAL.GetMenusIdInMenuDetails(order);
                List<int> DishDetailsId = orderDAL.GetDishesIdInMenuDetails(order);
                List<Meal> OrderMeals = new List<Meal>();
                Restaurant restaurant = restaurantDAL.GetRestaurantById(order.Restaurant);
                order.Restaurant = restaurant;
                foreach (var menuId in MenuDetailsId)
                {
                    OrderMeals.Add(menuDAL.GetMenuById(menuId));
                }
                foreach (var dishId in DishDetailsId)
                {
                    OrderMeals.Add(menuDAL.GetDishById(dishId));
                }
                foreach (var meal in OrderMeals)
                {
                    if (meal is Menu)
                    {
                        order.listMenuOrdered.Add(meal as Menu);
                    }
                    if (meal is Dish)
                    {
                        order.listDishOrdered.Add(meal as Dish);
                    }
                }
            }
            return CustomerOrders;
        }

        public bool UpdateOrderStatus()
        {
            bool success = false;
            return success;
        }

        public void CalculateTotalPrice(Order order)
        {
            double totalDishes=0;
            foreach (var dish in order.listDishOrdered)
            {
                totalDishes += dish.Price;
            }

            double totalMenus = 0;
            foreach (var menu in order.listMenuOrdered)
            {
                totalMenus += menu.Price;
            }

            order.TotalPrice = totalDishes + totalMenus;
        }

    }   
}
