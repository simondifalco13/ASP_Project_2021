using ASP_PROJECT.DAL.CDAL;
using ASP_PROJECT.DAL.IDAL;
using ASP_PROJECT.Models.Project;
using ASP_PROJECT.ViewModels.Simon;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.Controllers.Simon
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
            return View("Views/Simon/Menu/Index.cshtml");
        }

        public IActionResult AddMenu()
        {
            MenuViewModel vm = new MenuViewModel(ListDish);
            Restaurant r = new Restaurant();
            r.Id = 1;
            vm.Dlist = Dish.GetDishes(r,_menuDAL);
            return View("Views/Simon/Menu/AddMenu.cshtml",vm);
        }

        

        public IActionResult AddDish()
        {
            DishViewModel vm = new DishViewModel();
            return View("Views/Simon/Menu/AddDish.cshtml",vm);
        }


        [HttpPost]
        public IActionResult AddDish(DishViewModel vm)
        {
            if (ModelState.IsValid)
            {
                ViewData["success"] = "true";
                Restaurant r = new Restaurant();
                r.Id = 1;
                Dish d = vm.Dish;
                bool success =Dish.AddDish(d, r, _menuDAL);
                return View("Views/Simon/Menu/Index.cshtml");
            }
            return View("Views/Simon/Menu/AddDish.cshtml", vm);
        }

        [HttpPost]
        public IActionResult AddMenu(MenuViewModel vm)
        {
            if (ModelState.IsValid)
            {
                ViewData["success"] = "true";
                return View("Views/Simon/Menu/Index.cshtml");
            }
            return View("Views/Simon/Menu/AddMenu.cshtml", vm);
        }


        [HttpPost]
        public IActionResult AddDishToMenu(MenuViewModel vm)
        {
            
            vm.MenuDishList.Add(vm.SelectedDish);
            return View("Views/Simon/Menu/AddMenu.cshtml", vm);
        }

    }
}
