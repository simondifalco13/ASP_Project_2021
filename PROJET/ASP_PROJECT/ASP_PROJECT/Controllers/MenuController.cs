using ASP_PROJECT.DAL.CDAL;
using ASP_PROJECT.DAL.IDAL;
using ASP_PROJECT.Models.POCO;
using ASP_PROJECT.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.Controllers
{
    public class MenuController : Controller
    {
        private readonly IMenuDAL _menuDAL;
       
        public MenuController(IMenuDAL menuDAL)
        {
            _menuDAL = menuDAL;
        }

        //public static List<Dish> ListDish = new List<Dish>();
        public IActionResult Index()
        {
            return View("Views/Menu/Index.cshtml");
        }

        public IActionResult AddMenu()
        {
            MenuViewModel vm = new MenuViewModel();
            //en dur a modifier
            Restaurant r = new Restaurant();
            r.Id = 1;
            vm.Dlist = Dish.GetDishes(r, _menuDAL);
            return View("Views/Menu/AddMenu.cshtml", vm);
        }
        public IActionResult AddDish()
        {
            DishViewModel vm = new DishViewModel();
            return View("Views/Menu/AddDish.cshtml",vm);
        }

        public IActionResult GetViewModel(MenuViewModel vm = null)
        {
            if (vm == null)
            {
                Restaurant r = new Restaurant();
                r.Id = 1;
                //appel a la db 
                List<Dish> dishes = Dish.GetDishes(r, _menuDAL);
                vm = new MenuViewModel(dishes);

            }
            return View("Views/Menu/AddMenu.cshtml", vm);

        }
        public IActionResult ConsultDishes()
        {
            Restaurant r = new Restaurant();
            r.Id = 1;
            List<Dish> ld= Dish.GetDishes(r, _menuDAL);
            ListDishViewModel vm = new ListDishViewModel(ld);
            return View("Views/Menu/ConsultDishes.cshtml",vm);
        }

        public IActionResult ConsultMenus(int RestoId)
        {
            Restaurant r = new Restaurant();
            r.Id = RestoId;
            List<Menu> ListMenu = Menu.GetMenus(_menuDAL,r);
            ListMenuViewModel vm = new ListMenuViewModel(ListMenu);
            return View("ConsultMenus", vm);
        }

        public IActionResult ModifyDish(Dish dishToModify)
        {
            DishViewModel vm = new DishViewModel();
            vm.Dish = dishToModify;
            return View("Views/Menu/ModifyDish.cshtml", vm);
        }

        public IActionResult DeleteDish()
        {
            Restaurant r = new Restaurant();
            r.Id = 1;
            List<Dish> ld = Dish.GetDishes(r, _menuDAL);
            ListDishViewModel vm = new ListDishViewModel(ld);
            return View("DeleteDish", vm);

        }

        public IActionResult DeleteDishById(int Dishid)
        {
            Dish SearchedDish = Dish.GetDishById(Dishid, _menuDAL);
            Restaurant r = new Restaurant();
            r.Id = 1;
            bool success = Dish.DeleteDish(SearchedDish, r, _menuDAL);
            if (success == true)
            {
                TempData["Suppressing"] = "La suppression du plat à été effectuée";
                return RedirectToAction("ConsultDishes");
            }
            else
            {
                TempData["Suppressing"] = "La suppression du plat à échoué";
                return RedirectToAction("ConsultDishes");
            }
        }

        public IActionResult DeleteMenuById(int MenuId)
        {
            Menu SearchedMenu = Menu.GetMenuById(MenuId, _menuDAL);
            bool success = Menu.DeleteMenu(SearchedMenu, _menuDAL);
            return RedirectToAction("ConsultAllRestaurant");
        }

        public IActionResult ModifyDishById(int Dishid)
        {
            Dish dishToModify = Dish.GetDishById(Dishid, _menuDAL);
            Restaurant r = new Restaurant();
            r.Id = 1;
            DishViewModel vm = new DishViewModel();
            vm.Dish = dishToModify;
            TempData["ModifyDishId"] = vm.Dish.Id;
            return View("ModifyDish", vm);
        }

        public IActionResult AddDishToMenu(int DishId)
        {
            Dish AddedDish = Dish.GetDishById(DishId, _menuDAL);
            //ajouter dans variable de session afin de récuperer dans la fonction suivante
            if (!String.IsNullOrEmpty(HttpContext.Session.GetString("restorerConnected")))
            {
                HttpContext.Session.SetString("Dish", DishId.ToString());
            }
            Restaurant r = new Restaurant();
            r.Id = 1;
            //vm.Dlist = Dish.GetDishes(r, _menuDAL);
            //vm.SelectedDish = 0;
            return View("AddMenu");
            //pourquoi ne passe pas la dishlist  : tester avec viewdata puis appliquer au model dans razor block
        }

        //POST METHODS

        [HttpPost]
        public IActionResult AddDish(DishViewModel vm)
        {
            if (ModelState.IsValid)
            {
                ViewData["success"] = "true";
                Dish d = vm.Dish;
                Restaurant r = new Restaurant();
                r.Id = 1;
                bool success =Dish.AddDish(d, r, _menuDAL);
                //ajouter dans la list du restaurant aussi 
                return View("Views/Menu/Index.cshtml");
            }
            return View("Views/Menu/AddDish.cshtml", vm);
        }

        [HttpPost]
        public IActionResult AddMenu(MenuViewModel vm)
        {
            if (ModelState.IsValid)
            {
                ViewData["success"] = "true";
                return View("Views/Simon/Menu/Index.cshtml");
            }
            return View("Views/Menu/AddMenu.cshtml", vm);
        }


        [HttpPost]
        public IActionResult UpdatingDish(DishViewModel vm)
        {
            TempData["Updating"] = null;
            Dish DishToUpdate = vm.Dish;
            DishToUpdate.Id = (int)TempData["ModifyDishId"];
            if (ModelState.IsValid)
            {
                bool success = Dish.UpdateDish(DishToUpdate, _menuDAL);
                if (success == true)
                {
                    TempData["Updating"] = "success";
                    return RedirectToAction("ConsultDishes");
                }
                else
                {
                    TempData["Updating"] = "error";
                    return RedirectToAction("ModifyDishById", vm.Dish);
                }
            }
            else
            {
                TempData["Updating"] = "Invalid";
                return RedirectToAction("ModifyDishById", vm.Dish);
            }

        }

        

        // 
        //public IActionResult ConsultMenuAndDish(int idResto) {
        //    // Parce que objet restaurant envoyé dans GetDishes
        //    Restaurant resto = new Restaurant();
        //    resto.Id = idResto;

        //    List<Menu> menus = Menu.GetMenus(_menuDAL,idResto);

        //    TempData["menus"] = menus;
        //    TempData["dishes"] = Dish.GetDishes(resto, _menuDAL);
        //    return View();
        //}
    }
}
