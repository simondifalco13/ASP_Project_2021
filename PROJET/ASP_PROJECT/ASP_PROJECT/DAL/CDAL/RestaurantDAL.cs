using ASP_PROJECT.DAL.IDAL;
using ASP_PROJECT.Models.POCO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.DAL.CDAL
{
    public class RestaurantDAL : IRestaurantDAL
    {
        private string connectionString;
        public RestaurantDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Restaurant GetRestaurantById(int id)
        {
            Restaurant r = new Restaurant();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string request = "SELECT Name,City,Adress,PostalCode,PhoneNumber,RestaurantType,Description,TvaNumber,Country FROM dbo.Restaurants WHERE RestaurantId=@RestaurantId";
                SqlCommand cmd = new SqlCommand(request, connection);
                cmd.Parameters.AddWithValue("Restaurantid",id);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        r.Id = id;
                        r.Name = reader.GetString("Name");
                        r.City= reader.GetString("City");
                        r.Address= reader.GetString("Adress");
                        r.Pc = reader.GetString("PostalCode");
                        r.Tel= reader.GetString("PhoneNumber");
                        RestaurantType type;
                        Enum.TryParse(reader.GetString("RestaurantType"), out type);
                        r.Type = type;
                        r.Description= reader.GetString("Description");
                        r.NumTVA= reader.GetString("TvaNumber");
                        r.Country= reader.GetString("Country");

                        GetRestaurantSchedules(r);
                    }
                }
            }
            return r;
        }
        /// gab

        public List<Restaurant> GetAllRestaurants() {
            List<Restaurant> restos = new List<Restaurant>();

            using (SqlConnection connection = new SqlConnection(connectionString)) {
                string request = "SELECT * FROM dbo.Restaurants";
                SqlCommand cmd = new SqlCommand(request, connection);
                connection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader()) {
                    while (reader.Read()) {
                        Restaurant resto = new Restaurant();
                        RestaurantType type;
                        Enum.TryParse(reader.GetString("RestaurantType"), out type);
                        resto.Type = type;
                        resto.Name = reader.GetString("Name");
                        resto.Address = reader.GetString("Adress");
                        resto.City = reader.GetString("City");
                        resto.Country = reader.GetString("Country");
                        resto.Description = reader.GetString("Description");
                        resto.Tel = reader.GetString("PhoneNumber");
                        resto.Pc = reader.GetString("PostalCode");
                        resto.NumTVA = reader.GetString("TvaNumber");
                        resto.Id = reader.GetInt32("RestaurantId");
                        restos.Add(resto);
                    }
                }
            }
            foreach (var resto in restos)
            {
                GetRestaurantSchedules(resto);
            }
                return restos;
        }

        public Restaurant GetRestaurantMenuAndDishById(Restaurant resto) {
            Restaurant restaurant = new Restaurant();

            using (SqlConnection connection = new SqlConnection(connectionString)) {
                string request = "SELECT * FROM dbo.Restaurants WHERE RestaurantId=@RestaurantId";
                SqlCommand cmd = new SqlCommand(request, connection);
                cmd.Parameters.AddWithValue("RestaurantId", resto.Id );
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader()) {
                    while (reader.Read()) {
                        restaurant.Id = resto.Id;
                        restaurant.Name = reader.GetString("Name");
                        restaurant.City = reader.GetString("City");
                        restaurant.Address = reader.GetString("Adress");
                        restaurant.Pc = reader.GetString("PostalCode");
                        restaurant.Tel = reader.GetString("PhoneNumber");
                        RestaurantType type;
                        Enum.TryParse(reader.GetString("RestaurantType"), out type);
                        restaurant.Type = type;
                        restaurant.Description = reader.GetString("Description");
                        restaurant.NumTVA = reader.GetString("TvaNumber");
                        restaurant.Country = reader.GetString("Country");

                        GetRestaurantSchedules(restaurant);
                        GetRestaurantDishes(restaurant);
                        GetRestaurantMenus(restaurant);
                    }
                }
            }
            return restaurant;
        }

        public void GetRestaurantMenus(Restaurant resto) {
            List<Menu> listMenus = new List<Menu>();
            Menu menu = new Menu();

            TypeService serviceType;
            decimal price;
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                string request = "SELECT * FROM dbo.Menus WHERE RestaurantId=@RestaurantId";
                SqlCommand cmd = new SqlCommand(request, connection);
                cmd.Parameters.AddWithValue("RestaurantId", resto.Id);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader()) {
                    while (reader.Read()) {
                        menu.Id = reader.GetInt32("MenuId");
                        menu.Name = reader.GetString("Name");
                        price = reader.GetDecimal("Price");
                        menu.Price = (double)price;
                        Enum.TryParse(reader.GetString("TypeService"), out serviceType);
                        menu.Service = serviceType;
                        menu.Description = reader.GetString("Description");
                        listMenus.Add(menu);
                    }
                }
            }
            foreach (var m in listMenus) {
                resto.mealList.Add(m);
            }
        }
        public void GetRestaurantDishes(Restaurant resto) {
            List<Dish> listDishes = new List<Dish>();
            Dish dish = new Dish();

            TypeService serviceType;
            TypeDish dishType;
            decimal price;
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                string request = "SELECT * FROM dbo.Dishes WHERE restaurantId=@RestaurantId";
                SqlCommand cmd = new SqlCommand(request, connection);
                cmd.Parameters.AddWithValue("RestaurantId", resto.Id);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader()) {
                    while (reader.Read()) {
                        dish.Id = reader.GetInt32("DishId");
                        dish.Name = reader.GetString("Name");
                        price = reader.GetDecimal("Price");
                        dish.Price = (double)price;
                        Enum.TryParse(reader.GetString("TypeService"), out serviceType);
                        dish.Service = serviceType;
                        Enum.TryParse(reader.GetString("Typedish"), out dishType);
                        dish.Type = dishType;
                        dish.Description = reader.GetString("Description");
                        listDishes.Add(dish);
                    }
                }
            }
            foreach (var d in listDishes) {
                resto.mealList.Add(d);
            }
        }
        //
        public bool SignRestaurant(Restorer restorer, Restaurant restaurant)
        {
            throw new NotImplementedException();
        }

        public void GetRestaurantSchedules(Restaurant resto)
        {
            List<DateTime> OpeningTime = new List<DateTime>();
            List<DateTime> CloseTime = new List<DateTime>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                    string request = "SELECT OpenTime,CloseTime FROM dbo.Schedules WHERE RestaurantId=@RestaurantId";
                    SqlCommand cmd = new SqlCommand(request, connection);
                    cmd.Parameters.AddWithValue("RestaurantId", resto.Id);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            OpeningTime.Add(reader.GetDateTime("OpenTime"));
                            CloseTime.Add(reader.GetDateTime("CloseTime"));
                        }
                    }
                    resto.OpeningsTimes = OpeningTime;
                    resto.CloseTimes = CloseTime;
            }
        }
    }
}
