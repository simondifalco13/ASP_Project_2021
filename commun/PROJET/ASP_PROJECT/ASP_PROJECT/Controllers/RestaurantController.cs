using ASP_PROJECT.DAL.IDAL;
using ASP_PROJECT.Models.POCO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.Controllers {
    public class RestaurantController : Controller {
        
        private readonly IRestaurantDAL _restaurantDAL;

        public RestaurantController(IRestaurantDAL restaurantDAL) {
            _restaurantDAL = restaurantDAL;
        }
        public IActionResult Index() {
            return View();
        }

        public IActionResult ConsultRestaurant() {
            List<Restaurant> restos = Restaurant.GetAllRestaurants(_restaurantDAL);

            TempData["Restos"] = restos;
            return View();
        }
    }
}