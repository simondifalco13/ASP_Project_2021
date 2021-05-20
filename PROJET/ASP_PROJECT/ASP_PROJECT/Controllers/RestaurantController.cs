using ASP_PROJECT.DAL.IDAL;
using ASP_PROJECT.Models.POCO;
using ASP_PROJECT.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.Controllers {
    public class RestaurantController : Controller {
        

        private readonly IRestaurantDAL _restaurantDAL;
        private readonly IMenuDAL _menuDAL;


        public RestaurantController(IRestaurantDAL restaurantDAL,IMenuDAL menuDAL) {
            _restaurantDAL = restaurantDAL;
            _menuDAL = menuDAL;
        }
        public IActionResult Index() {
            return View();
        }

        public IActionResult ConsultRestaurant() {
            List<Restaurant> restos = Restaurant.GetAllRestaurants(_restaurantDAL);
            ListRestaurantsViewModel viewModel = new ListRestaurantsViewModel(restos);

            return View("Views/Restaurant/ConsultAllRestaurants.cshtml", viewModel);
        }

        //Simon : (délimitation pour m'y retrouver quand je fais des copier coller en attendant de résoudre le problème de versionning)
        public IActionResult SignRestaurant()
        {
            TempData["Previous"] = null;
            SignRestaurantViewModel vm = new SignRestaurantViewModel();
            vm.restorerId = 1;
            return View("SignRestaurant", vm);
        }

        ////[HttpPost]
        ////public IActionResult AddDeliveryCity(SignRestaurantViewModel vm)
        ////{
        ////    vm.cities.Add(vm.DeliveryCity);
        ////    return View("SignRestaurant", vm);
        ////}

        [HttpPost]
        public IActionResult SignRestaurant(SignRestaurantViewModel vm)
        {
            if (ModelState.IsValid)
            {
                Restaurant CreatedRestaurant = vm.Resto;
                CreatedRestaurant.OpeningsTimes.Add(DateTime.Parse(vm.MondayOt));
                CreatedRestaurant.OpeningsTimes.Add(DateTime.Parse(vm.TuesdayOt));
                CreatedRestaurant.OpeningsTimes.Add(DateTime.Parse(vm.WednesdayOt));
                CreatedRestaurant.OpeningsTimes.Add(DateTime.Parse(vm.ThursdayOt));
                CreatedRestaurant.OpeningsTimes.Add(DateTime.Parse(vm.FridayOt));
                CreatedRestaurant.OpeningsTimes.Add(DateTime.Parse(vm.SaturdayOt));
                CreatedRestaurant.OpeningsTimes.Add(DateTime.Parse(vm.SundayOt));

                CreatedRestaurant.CloseTimes.Add(DateTime.Parse(vm.MondayCt));
                CreatedRestaurant.CloseTimes.Add(DateTime.Parse(vm.TuesdayCt));
                CreatedRestaurant.CloseTimes.Add(DateTime.Parse(vm.WednesdayCt));
                CreatedRestaurant.CloseTimes.Add(DateTime.Parse(vm.ThursdayCt));
                CreatedRestaurant.CloseTimes.Add(DateTime.Parse(vm.FridayCt));
                CreatedRestaurant.CloseTimes.Add(DateTime.Parse(vm.SaturdayCt));
                CreatedRestaurant.CloseTimes.Add(DateTime.Parse(vm.SundayCt));

                TempData["RestaurantSign"] = "L'ajout du restaurant s'est déroulée avec succès";
                return View("Index");
            }
            else
            {
                TempData["RestaurantSignError"] = "Le restaurant avec ce nom existe dèjà dans vos restaurants";
                return View("SignRestaurant", vm);

            }
        }
        public IActionResult ConsultAll(int restaurantId) {
            Restaurant resto = new Restaurant();

            resto.Id = restaurantId;
            resto = Restaurant.GetRestaurantDishesAndMenus(resto, _restaurantDAL, _menuDAL);
            return View("Views/Restaurant/ConsultRestaurantMenuDish.cshtml",resto);
        }
    }
}