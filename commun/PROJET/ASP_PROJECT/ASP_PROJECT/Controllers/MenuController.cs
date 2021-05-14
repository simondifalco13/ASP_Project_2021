using ASP_PROJECT.DAL.CDAL;
using ASP_PROJECT.DAL.IDAL;
using ASP_PROJECT.Models.POCO;
using ASP_PROJECT.ViewModels;
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

        public static List<Dish> ListDish = new List<Dish>();
        public IActionResult Index()
        {
            return View("Views/Menu/Index.cshtml");
        }

        public IActionResult AddMenu()
        {
            MenuViewModel vm = new MenuViewModel(ListDish);
            //en dur a modifier
            Restaurant r = new Restaurant();
            r.Id = 1;
            vm.Dlist = Dish.GetDishes(r,_menuDAL);
            return View("Views/Menu/AddMenu.cshtml",vm);
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

        
        public IActionResult ModifyDish(Dish d)
        {
            DishViewModel vm = new DishViewModel();
            vm.Dish = d;
            return View("Views/Menu/ModifyDish.cshtml",vm);
        }

        public IActionResult DeleteDish()
        {
            Restaurant r = new Restaurant();
            r.Id = 1;
            List<Dish> ld = Dish.GetDishes(r, _menuDAL);
            ListDishViewModel vm = new ListDishViewModel(ld);
            return View("DeleteDish", vm);

        }

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
        public IActionResult AddDishToMenu(MenuViewModel vm)
        {
            Restaurant r = new Restaurant();
            r.Id = 1;
            vm.Dlist = Dish.GetDishes(r, _menuDAL);
            vm.Menu.DishList = ListDish;
            return RedirectToAction("GetViewModel",vm);
        }

        [HttpPost]
        public IActionResult AddDishToMenuBis(Dish d)
        {
            ListDish.Add(d);
            return RedirectToAction("AddDishToMenu");
        }

        [HttpPost]
        public IActionResult UpdatingDish(DishViewModel vm)
        {
            if (ModelState.IsValid)
            {
                //on updtate en db
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("ModifyDish");
            }
           
        }

        //comment récuperer l'objet envoyé
        [HttpPost]
        public IActionResult DeleteDish(ListDishViewModel vm)
        {
            Dish d = vm.Dish;
            Restaurant r = new Restaurant();
            r.Id = 1;
            bool success = Dish.DeleteDish(d, r, _menuDAL);
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

        // 
        public IActionResult ConsultMenuAndDish(int idResto) {
            // Parce que objet restaurant envoyé dans GetDishes
            Restaurant resto = new Restaurant();
            resto.Id = idResto;

            List<Menu> menus = Menu.GetMenus(_menuDAL,idResto);

            TempData["menus"] = menus;
            TempData["dishes"] = Dish.GetDishes(resto, _menuDAL);
            return View();
        }
    }
}
