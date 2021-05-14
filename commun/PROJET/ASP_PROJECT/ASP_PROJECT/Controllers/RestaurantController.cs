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

        //Simon : (délimitation pour m'y retrouver quand je fais des copier coller en attendant de résoudre le problème de versionning)
        public IActionResult SignRestaurant()
        {
            Restaurant r = new Restaurant();
            return View("SignRestaurant", r);
        }

        [HttpPost]
        public IActionResult SignRestaurant(Restaurant r)
        {
            if (ModelState.IsValid)
            {
                TempData["RestaurantSign"] = "L'ajout du restaurant s'est déroulée avec succès";
                return View("Index");
            }
            else
            {
                TempData["RestaurantSignError"] = "Le restaurant avec ce nom existe dèjà dans vos restaurants";
                return View("SignRestaurant", r);

            }

        }
    }
}