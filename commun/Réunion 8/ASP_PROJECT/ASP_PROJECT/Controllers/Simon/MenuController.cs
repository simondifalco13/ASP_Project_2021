using ASP_PROJECT.Models.Project;
using ASP_PROJECT.ViewModels.Simon;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.Controllers.Simon
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View("Views/Simon/Menu/Index.cshtml");
        }

        public IActionResult AddMenu()
        {
            MenuViewModel vm = new MenuViewModel();
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

    }
}
