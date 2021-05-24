using ASP_PROJECT.DAL.IDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.Models.POCO
{
    public enum RestaurantType
    {
        Asian,
        Mexican,
        Snack,
        African,
        Thaï,
        Greek,
        Sushi,
        Spanish,
        Pizza,
        Italian
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

        public static bool SignRestaurant(Restaurant resto, Restorer restorer, IRestaurantDAL restaurantDAL)
        {
            try
            {
                bool success = restaurantDAL.SignRestaurant(restorer, resto);
                return success;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void GetRestaurant(Restaurant r,IRestaurantDAL restaurantDAL){
            restaurantDAL.GetRestaurantById(r);
        }

        public static List<Restaurant> GetAllRestaurants(IRestaurantDAL DAL) {
            return DAL.GetAllRestaurants();
        }

        public static Restaurant GetRestaurantDishesAndMenus(Restaurant r,IRestaurantDAL restaurantDAL,IMenuDAL menuDAL)
        {
            Restaurant RecuperatedResto = restaurantDAL.GetRestaurantById(r);
            //on va utiliser la menu DAL pour récuperer les DISHES ET LES MENUS
            List<Menu> RestaurantMenus = menuDAL.GetMenus(r);
            foreach (var menu in RestaurantMenus)
            {
                RecuperatedResto.mealList.Add(menu);
            }
            //on veut récuperer nos dishes
            List<Dish> RestaurantDishes=menuDAL.GetDishes(r);
            foreach (var dish in RestaurantDishes)
            {
                RecuperatedResto.mealList.Add(dish);
            }
            return RecuperatedResto;
        }

        public Restaurant GetScheduleResto(Restaurant resto, IRestaurantDAL restoDAL)
        {
            restoDAL.GetRestaurantSchedules(resto);

            return resto;
        }
        public static Restaurant GetRestaurantById(Restaurant resto, IRestaurantDAL restoDAL)
        {
            return restoDAL.GetRestaurantById(resto);
        }
    }
}
