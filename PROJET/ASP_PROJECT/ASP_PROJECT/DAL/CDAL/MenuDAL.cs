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
    public class MenuDAL : IMenuDAL
    {
        private string connectionString;
        public MenuDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public bool AddDish(Dish d,Restaurant r)
        {
            string request = "INSERT INTO dbo.Dishes(Name,Price,TypeService,Description,TypeDish,RestaurantId) VALUES (@Name,@Price,@TypeService,@Description,@TypeDish,@RestaurantId)";
            bool success = false;
            using (SqlConnection connection=new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(request,connection);
                cmd.Parameters.AddWithValue("Name", d.Name);
                cmd.Parameters.AddWithValue("Price", d.Price);
                cmd.Parameters.AddWithValue("TypeService", d.Service);
                cmd.Parameters.AddWithValue("Description", d.Description);
                string typeDish = d.Type.ToString();
                cmd.Parameters.AddWithValue("TypeDish", d.Type);
                //get the restaurant id by method ou adding attribute to restaurantclass (option 2 done)
                cmd.Parameters.AddWithValue("RestaurantId", r.Id);
                connection.Open();
                int res = cmd.ExecuteNonQuery();
                success = res > 5;
            }
            return success;
        }

        public List<Dish> GetDishes(Restaurant r)
        {
            List<Dish> listDishes = new List<Dish>();
            Dish temp = new Dish();
            TypeService serviceType;
            TypeDish typeDish;
            decimal price;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string request = "SELECT DishId,Name,Price,TypeService,Description,TypeDish FROM dbo.Dishes WHERE RestaurantId=@RestaurantId";
                SqlCommand cmd = new SqlCommand(request, connection);
                cmd.Parameters.AddWithValue("RestaurantId", r.Id);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        temp.Id = reader.GetInt32("DishId");
                        temp.Name=reader.GetString("Name");
                        price=reader.GetDecimal("Price");
                        temp.Price = (double)price;
                        Enum.TryParse(reader.GetString("TypeService"), out serviceType);
                        temp.Service = serviceType;
                        temp.Description= reader.GetString("Description");
                        Enum.TryParse(reader.GetString("TypeDish"), out typeDish);
                        temp.Type = typeDish;
                        listDishes.Add(temp);
                        temp = new Dish();
                    }
                }
            }
            return listDishes;
        }

        public bool SuppressDish(Dish d)
        {
            bool success = false;
            success = DeleteMenuDetailsByDishId(d.Id);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string request = "DELETE FROM dbo.Dishes WHERE DishId=@DishId";
                SqlCommand cmd = new SqlCommand(request, connection);
                cmd.Parameters.AddWithValue("DishId", d.Id);
                connection.Open();
                int res = cmd.ExecuteNonQuery();
                success = res >0;

            }
            return success;
        }

        public bool SuppressMenu(Menu menu)
        {
            bool success = false;
            success = DeleteMenuDetailsByMenuId(menu.Id);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string request = "DELETE FROM dbo.Menus WHERE MenuId=@MenuId";
                SqlCommand cmd = new SqlCommand(request, connection);
                cmd.Parameters.AddWithValue("MenuId", menu.Id);
                connection.Open();
                int res = cmd.ExecuteNonQuery();
                success = res > 0;

            }
            return success;
        }

        public bool DeleteMenuDetailsByMenuId(int menuId)
        {
            bool success = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string request = "DELETE FROM dbo.MenuDetails WHERE MenuId=@MenuId";
                SqlCommand cmd = new SqlCommand(request, connection);
                cmd.Parameters.AddWithValue("MenuId", menuId);
                connection.Open();
                int res = cmd.ExecuteNonQuery();
                success = res > 0;

            }
            return success;
        }

        public bool DeleteMenuDetailsByDishId(int dishId)
        {
            bool success = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string request = "DELETE FROM dbo.MenuDetails WHERE DishId=@DishId";
                SqlCommand cmd = new SqlCommand(request, connection);
                cmd.Parameters.AddWithValue("DishId", dishId);
                connection.Open();
                int res = cmd.ExecuteNonQuery();
                success = res > 0;

            }
            return success;
        }

        public List<Menu> GetMenus(int id) {
            List<Menu> listMenus = new List<Menu>();
            Menu menu = new Menu();
            TypeService serviceType;
            decimal price;
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                string request = "SELECT MenuId,Name,Price,Description,TypeService FROM dbo.Menus WHERE RestaurantId=@RestaurantId";
                SqlCommand cmd = new SqlCommand(request, connection);
                cmd.Parameters.AddWithValue("RestaurantId", id);
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
                        menu = new Menu();
                    }
                }
            }
            foreach (var item in listMenus)
            {
                item.DishList = GetMenuDetails(item.Id);
            }
            return listMenus;
        }

        public Menu GetMenuById(int MenuId)
        {
            Menu menu = new Menu();
            TypeService serviceType;
            decimal price;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string request = "SELECT MenuId,Name,Price,Description,TypeService FROM dbo.Menus WHERE MenuId=@MenuId";
                SqlCommand cmd = new SqlCommand(request, connection);
                cmd.Parameters.AddWithValue("MenuId", MenuId);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        menu.Id = reader.GetInt32("MenuId");
                        menu.Name = reader.GetString("Name");
                        price = reader.GetDecimal("Price");
                        menu.Price = (double)price;
                        Enum.TryParse(reader.GetString("TypeService"), out serviceType);
                        menu.Service = serviceType;
                        menu.Description = reader.GetString("Description");
                    }
                }
            }
            
            menu.DishList = GetMenuDetails(menu.Id);
            return menu;
        }
        public List<Dish> GetMenuDetails(int menuId)
        {
            List<Dish> MenuDetails = new List<Dish>();
            Dish Detail = new Dish();
            int id;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string request = "SELECT DishId FROM dbo.MenuDetails WHERE MenuId=@MenuId";
                SqlCommand cmd = new SqlCommand(request, connection);
                cmd.Parameters.AddWithValue("MenuId", menuId);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id = reader.GetInt32("DishId");
                        Detail = GetDishById(id);
                        MenuDetails.Add(Detail);
                        Detail = new Dish();
                    }
                }
            }
            return MenuDetails;
        }
        public Dish GetDishById(int id)
        {
            Dish SearchedDish = new Dish();
            TypeService serviceType;
            decimal price;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string request = "SELECT * FROM dbo.Dishes WHERE DishId=@DishId";
                SqlCommand cmd = new SqlCommand(request, connection);
                cmd.Parameters.AddWithValue("DishId", id);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        SearchedDish.Id = reader.GetInt32("DishId");
                        SearchedDish.Name = reader.GetString("Name");
                        price = reader.GetDecimal("Price");
                        SearchedDish.Price = (double)price;
                        Enum.TryParse(reader.GetString("TypeService"), out serviceType);
                        SearchedDish.Service = serviceType;
                        SearchedDish.Description = reader.GetString("Description");
                    }
                }
            }
            return SearchedDish;
        }

        public bool UpdatingDish(Dish dish)
        {
            string request = "UPDATE dbo.Dishes SET Name=@Name ,Price=@Price ,TypeService=@TypeService ,Description=@Description ,TypeDish=@TypeDish WHERE DishId=@DishId";
            bool success = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(request, connection);
                cmd.Parameters.AddWithValue("Name", dish.Name);
                cmd.Parameters.AddWithValue("Price", dish.Price);
                cmd.Parameters.AddWithValue("TypeService", dish.Service);
                cmd.Parameters.AddWithValue("Description", dish.Description);
                cmd.Parameters.AddWithValue("TypeDish", dish.Type);
                cmd.Parameters.AddWithValue("DishId", dish.Id);
                connection.Open();
                int res = cmd.ExecuteNonQuery();
                success = res > 0;
            }
            return success;
        }

       
    }
}
