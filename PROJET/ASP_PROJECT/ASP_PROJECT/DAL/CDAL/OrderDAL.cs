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
    public class OrderDAL : IOrderDAL
    {
        private string connectionString;

        public OrderDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public List<Order> GetRestaurantOrders(Restaurant restaurant)
        {
            decimal price;
            List<Order> RestaurantOrders = new List<Order>();
            Order Order = new Order();
            Order.Restaurant = restaurant;
            OrderStatus Status;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string request = "SELECT * FROM dbo.Orders WHERE RestaurantId=@RestaurantId";
                SqlCommand cmd = new SqlCommand(request, connection);
                cmd.Parameters.AddWithValue("RestaurantId", restaurant.Id);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Order.Id = reader.GetInt32("OrderId");
                        Order.DeliveryAdress = reader.GetString("DeliveryAdress");
                        price = reader.GetDecimal("Price");
                        Order.TotalPrice = (double)price;
                        Order.Customer.Id= reader.GetInt32("CustomerId");
                        Order.DateOrder = reader.GetDateTime("OrderDate");
                        Enum.TryParse(reader.GetString("OrderStatus"), out Status);
                        Order.Status = Status;

                        //get Order Dish and Menu Details
                        RestaurantOrders.Add(Order);
                        Order = new Order();

                    }
                }
            }
            return RestaurantOrders;
        }

       

        public List<int> GetMenusIdInMenuDetails(Order order)
        {
            List<int> MenuDetailsId = new List<int>();
            int id;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string request = "SELECT MenuId FROM dbo.OrderMenuDetails WHERE OrderId=@OrderId";
                SqlCommand cmd = new SqlCommand(request, connection);
                cmd.Parameters.AddWithValue("OrderId", order.Id);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id = reader.GetInt32("MenuId");
                        MenuDetailsId.Add(id);
                    }
                }
            }
            return MenuDetailsId;
        }

        public List<int> GetDishesIdInMenuDetails(Order order)
        {
            List<int> DishDetailsId = new List<int>();
            int id;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string request = "SELECT DishId FROM dbo.OrderDishDetails WHERE OrderId=@OrderId";
                SqlCommand cmd = new SqlCommand(request, connection);
                cmd.Parameters.AddWithValue("OrderId", order.Id);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id = reader.GetInt32("DishId");
                        DishDetailsId.Add(id);
                    }
                }
            }
            return DishDetailsId;
        }

        //eventuellement déplacer pour faire un appel a l'autre DAl

    }
}
