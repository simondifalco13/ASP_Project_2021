using ASP_PROJECT.Models.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.DAL.IDAL
{
    public interface IRestaurantDAL 
    {
        Restaurant GetRestaurantById(Restaurant restaurant);
        List<Restaurant> GetRestaurantsById(Restorer restorer);

        bool SignRestaurant(Restorer restorer, Restaurant restaurant);

        List<Restaurant> GetAllRestaurants();

    }
}
