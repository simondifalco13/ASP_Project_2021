using ASP_PROJECT.DAL.IDAL;
using ASP_PROJECT.Models.POCO;
using ASP_PROJECT.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.Controllers {
    public class RestaurantController : Controller {
        

        private readonly IRestaurantDAL _restaurantDAL;
        private readonly IMenuDAL _menuDAL;
        private readonly IAccountDAL _accountDAL;


        public RestaurantController(IRestaurantDAL restaurantDAL,IMenuDAL menuDAL, IAccountDAL accountDAL) {
            _restaurantDAL = restaurantDAL;
            _menuDAL = menuDAL;
            _accountDAL = accountDAL;
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
        public IActionResult SignRestaurant(int id)
        {
            TempData["RestaurantSignError"] = null;
            SignRestaurantViewModel vm = new SignRestaurantViewModel();
            vm.restorerId = id;
            return View("SignRestaurant", vm);
        }

        public IActionResult ConsultRestorerRestaurants(Restorer r)
        {
            //Restorer r = new Restorer();
            //r.Id = restorerId;
            r = Restorer.GetRestorerById(_accountDAL,r);
            r.restaurantList=r.GetRestorerRestaurants(_restaurantDAL);
            ListRestaurantsViewModel viewModel = new ListRestaurantsViewModel(r.restaurantList);
            viewModel.Restorer = r;
            return View("ConsultRestorerRestaurants", viewModel);
        }
        

        //Pas réalisé car pas assez de temps 
        //[HttpPost]
        //public IActionResult AddDeliveryCity(SignRestaurantViewModel vm)
        //{
        //    vm.cities.Add(vm.DeliveryCity);
        //    return View("SignRestaurant", vm);
        //}

        [HttpPost]
        public IActionResult SignRestaurant(SignRestaurantViewModel vm)
        {

            vm.restorerId = (int)HttpContext.Session.GetInt32("restorerId");
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

                try
                {
                    Restorer restorer = new Restorer();
                    restorer.Id = vm.restorerId;
                    restorer = Restorer.GetRestorerById(_accountDAL,restorer) ;
                    bool success = Restaurant.SignRestaurant(CreatedRestaurant, restorer, _restaurantDAL);
                    if (success == true)
                    {
                        TempData["RestaurantSign"] = "success";
                        return View("Index");
                    }
                    else
                    {
                        TempData["RestaurantSignError"] = "error";
                        return View("SignRestaurant", vm);

                    }
                }catch (Exception e)
                {
                    TempData["RestaurantSignError"] = e.Message;
                    return View("SignRestaurant", vm);
                }
            }
            else
            {
                return View("SignRestaurant", vm);
            }

        }

        public IActionResult ConsultAll(int restaurantId)
        {
            Restaurant resto = new Restaurant();
            resto.Id = restaurantId;
            HttpContext.Session.SetInt32("restaurantId", restaurantId);
            resto = Restaurant.GetRestaurantDishesAndMenus(resto, _restaurantDAL, _menuDAL);
            resto = resto.GetScheduleResto(resto, _restaurantDAL);

            ListRestaurantsViewModel vm = new ListRestaurantsViewModel(resto);

            return View("Views/Restaurant/ConsultRestaurantMenuDish.cshtml", vm);
        }
    }
}