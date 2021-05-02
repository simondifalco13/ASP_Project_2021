using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.Models.Project
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
        public string Country { get; set; }
        public string Description { get; set; }
        public string Tel { get; set; }
        public int Pc { get; set; }
        public string NumTVA { get; set; }

        public List<string> DeliveryCities;
        public DateTime[][] OpeningHours;

        public List<Opinion> opinionList;
        public List<Meal> mealList;

        public Restaurant()
        {

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
    }
}
