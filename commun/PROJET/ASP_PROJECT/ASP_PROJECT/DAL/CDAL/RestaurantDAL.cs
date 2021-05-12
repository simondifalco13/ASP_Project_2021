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
                    }
                }
            }
            return r;
        }

        public List<Restaurant> GetAllRestaurants() {
            List<Restaurant> restos = new List<Restaurant>();

            using(SqlConnection connection = new SqlConnection(connectionString)) {
                string request = "SELECT * FROM dbo.Restaurants INNER JOIN dbo.Schedules ON dbo.Restaurants.restaurantID=dbo.Schedules.restaurantID";
                SqlCommand cmd = new SqlCommand(request, connection);
                connection.Open();

                using(SqlDataReader reader = cmd.ExecuteReader()) {
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
                        
                        //resto.OpeningHours = reader.GetString("OpeningDay");
                        //resto.OpeningHours = reader.GetTime("OpenTime");
                        //resto.OpeningHours = reader.GetTime("CloseTime");

                        restos.Add(resto);
                    }
                }
            }
            return restos;
        }
    }
}
