using ASP_PROJECT.DAL.IDAL;
using System;
using System.Collections.Generic;
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
        public RestaurantType Type { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public string Tel { get; set; }
        public string Pc { get; set; }
        public string NumTVA { get; set; }

        public int Id { get; set; }

        public List<string> DeliveryCities;
        public DateTime[][] OpeningHours;

        public List<Opinion> opinionList;
        public List<Meal> mealList;

        public Restaurant()
        {

        }

        public Restaurant(string name,string adress,string country,string description,string tel,string pc,string ntva,string type)
        {
            Name = name;
            Adress = adress;
            Country = country;
            Description = description;
            Tel = tel;
            Pc = pc;
            NumTVA = ntva;
            RestaurantType t;
            Enum.TryParse(type, out t);
            Type = t;
        }

        public void OrderByRestaurant()
        {

        }
        public void SignRestaurant()
        {

        }
        public void DisplayOpinion()
        {

        }

        public void GetRestaurant(Restaurant r,IRestaurantDAL restaurantDAL)
        {
            r = restaurantDAL.GetRestaurantById(r.Id);
        }
    }
}
