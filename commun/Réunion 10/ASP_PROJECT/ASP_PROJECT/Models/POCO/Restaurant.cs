using ASP_PROJECT.DAL.IDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.Models.POCO
{
    //public enum RestaurantType
    //{
    //    Asian,
    //    Mexican,
    //    Snack,
    //    African,
    //    Thaï,
    //    Greek,
    //    Sushi,
    //    Spanish,
    //    Pizza,
    //    Italian
    //}
    public enum RestaurantType
    {
        Asiatique,
        Mexicain,
        Snack,
        Africain,
        Thaï,
        Grec,
        Sushi,
        Espagnol,
        Pizza,
        Italien
    }
    public class Restaurant
    {
        public int Id { get; set; }
        public RestaurantType Type { get; set; }

        [Display(Name="Nom du restaurant")]
        [Required(ErrorMessage = "Champs obligatoire")]
        [StringLength(20, MinimumLength = 3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Champs obligatoire")]
        [StringLength(50, MinimumLength = 10)]
        [Display(Name = "Adresse du restaurant")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Champs obligatoire")]
        [StringLength(35, MinimumLength = 5)]
        [Display(Name = "Ville du restaurant")]
        public string City { get; set; }

        [Required(ErrorMessage = "Champs obligatoire")]
        [StringLength(20, MinimumLength = 3)]
        [Display(Name = "Pays du restaurant")]
        public string Country { get; set; }

        [StringLength(500)]
        [Display(Name="Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Champs obligatoire")]
        [Display(Name = "Téléphone du restaurant")]
        [DataType(DataType.PhoneNumber)]
        public string Tel { get; set; }

        [Required(ErrorMessage = "Champs obligatoire")]
        [StringLength(6, MinimumLength = 3)]
        [Display(Name = "Code Postal")]
        public string Pc { get; set; }

        [Required(ErrorMessage = "Champs obligatoire")]
        [StringLength(20, MinimumLength = 10)]
        [Display(Name = "N° TVA")]
        public string NumTVA { get; set; }

        public Restorer Owner { get; set; }

        public List<string> DeliveryCities;
        public List<DateTime> OpeningsTimes { get; set; }
        public List<DateTime> CloseTimes { get; set; }

        public List<Opinion> opinionList;
        public List<Meal> mealList;
        public List<Order> OrdersList;

        public Restaurant()
        {
            OpeningsTimes = new List<DateTime>();
            CloseTimes = new List<DateTime>();
            DeliveryCities = new List<string>();
            mealList = new List<Meal>();
            OrdersList = new List<Order>();
            Owner = new Restorer();
        }
        public Restaurant(Restorer resto):this()
        {
            Owner = resto;
        }
        public Restaurant(string name,string adress,string country,string description,string tel,string pc,string ntva,string type):this()
        {
            Name = name;
            Address = adress;
            Country = country;
            Description = description;
            Tel = tel;
            Pc = pc;
            NumTVA = ntva;
            RestaurantType t;
            Enum.TryParse(type, out t);
            Type = t;
        }

        ////restorer
        //public void GetRestaurant(Restaurant r,IRestaurantDAL restaurantDAL){
        //    r = restaurantDAL.GetRestaurantById(r);
        //}

        //normalement ici : OK
        public static List<Restaurant> GetAllRestaurants(IRestaurantDAL DAL) {
            return DAL.GetAllRestaurants();
        }

        //pour compléter l'objet ==> OK
        public Restaurant GetRestaurantDishesAndMenus(IRestaurantDAL restaurantDAL,IMenuDAL menuDAL)
        {
            Restaurant RecuperatedResto = restaurantDAL.GetRestaurantById(this);
            List<Menu> RestaurantMenus = menuDAL.GetMenus(this);
            foreach (var menu in RestaurantMenus)
            {
                RecuperatedResto.mealList.Add(menu);
            }
            List<Dish> RestaurantDishes=menuDAL.GetDishes(this);
            foreach (var dish in RestaurantDishes)
            {
                RecuperatedResto.mealList.Add(dish);
            }
            return RecuperatedResto;
        }

        //OK
        public Restaurant GetScheduleResto(IRestaurantDAL restoDAL)
        {
            restoDAL.GetRestaurantSchedules(this);
            return this;
        }

        //OK
        public  Restaurant GetRestaurantById(IRestaurantDAL restoDAL)
        {
            return restoDAL.GetRestaurantById(this);
        }

        //OK
        public  bool AddDish(Dish d, IMenuDAL menuDAL)
        {
            bool success;
            success = menuDAL.AddDish(d, this);
            return success;
        }

        //OK
        public List<Dish> GetDishes(IMenuDAL menuDAL)
        {
            List<Dish> list;
            list = menuDAL.GetDishes(this);
            return list;
        }

        //OK
        public  List<Menu> GetMenus(IMenuDAL menuDAL)
        {

            return menuDAL.GetMenus(this);
        }

        //OK
        public  bool AddMenu(Menu menu, IMenuDAL menuDAL)
        {
            return menuDAL.AddMenu(menu, this);
        }

        //OK
        public  List<Order> GetRestaurantOrders(IOrderDAL orderDAL, IMenuDAL menuDAL, IAccountDAL accountDAL)
        {
            List<Order> RestaurantOrders = orderDAL.GetRestaurantOrders(this);
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
    }
}
