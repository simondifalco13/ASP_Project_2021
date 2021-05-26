using ASP_PROJECT.DAL.CDAL;
using ASP_PROJECT.DAL.IDAL;
using ASP_PROJECT.Models.POCO;
using ASP_PROJECT.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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

        public IActionResult Index()
        {
            HttpContext.Session.SetString("DishesId", "");
            return View("Views/Menu/Index.cshtml");
        }

        public IActionResult AddMenu(int restaurantId)
        {

            HttpContext.Session.SetString("DishesId","");
            MenuViewModel vm = new MenuViewModel();
            //en brut a enlever
            Restaurant r = new Restaurant();
            r.Id = restaurantId;
            vm.Dlist = r.GetDishes(_menuDAL);
            return View("AddMenu", vm);

        }


        public IActionResult AddDish(int restaurantId)
        {
            DishViewModel vm = new DishViewModel();
            vm.RestaurantId = restaurantId;
            HttpContext.Session.SetInt32("restaurantId", restaurantId);
            return View("Views/Menu/AddDish.cshtml",vm);
        }

        public IActionResult GetViewModel(MenuViewModel vm = null)
        {
            if (vm == null)
            {
                Restaurant r = new Restaurant();
                r.Id = 1;
                //appel a la db 
                List<Dish> dishes = r.GetDishes(_menuDAL);
                vm = new MenuViewModel(dishes);

            }
            return View("Views/Menu/AddMenu.cshtml", vm);

        }
        public IActionResult ConsultDishes()
        {
            Restaurant r = new Restaurant();
            r.Id = 1;
            List<Dish> ld= r.GetDishes(_menuDAL);
            ListDishViewModel vm = new ListDishViewModel(ld);
            return View("Views/Menu/ConsultDishes.cshtml",vm);
        }

        public IActionResult ConsultMenus(int RestoId)
        {
            Restaurant r = new Restaurant();
            r.Id = RestoId;
            List<Menu> ListMenu = r.GetMenus(_menuDAL);
            ListMenuViewModel vm = new ListMenuViewModel(ListMenu);
            return View("ConsultMenus", vm);
        }

        public IActionResult ModifyDish(Dish dishToModify)
        {
            DishViewModel vm = new DishViewModel();
            vm.Dish = dishToModify;
            return View("Views/Menu/ModifyDish.cshtml", vm);
        }

        //public IActionResult DeleteDish()
        //{
        //    Restaurant r = new Restaurant();
        //    r.Id = 1;
        //    List<Dish> ld = r.GetDishes(_menuDAL);
        //    ListDishViewModel vm = new ListDishViewModel(ld);
        //    return View("DeleteDish", vm);

        //}

        public IActionResult DeleteDishById(int Dishid)
        {
            Dish SearchedDish = Dish.GetDishById(Dishid, _menuDAL);
            Restaurant r = new Restaurant();
            r.Id = (int)HttpContext.Session.GetInt32("restaurantId"); 
            bool success = SearchedDish.DeleteDish(_menuDAL);
            if (success == true)
            {
                TempData["Suppressing"] = "La suppression du plat à été effectuée";
                return RedirectToAction("ConsultAll", "Restaurant", new { restaurantId = r.Id });
            }
            else
            {
                TempData["Suppressing"] = "La suppression du plat à échoué";
                return RedirectToAction("ConsultAll", "Restaurant", new { restaurantId = r.Id });
            }
        }

        public IActionResult DeleteMenuById(int MenuId)
        {
            Menu SearchedMenu = Menu.GetMenuById(MenuId, _menuDAL);
            bool success = SearchedMenu.DeleteMenu(_menuDAL);
            int restoId= (int)HttpContext.Session.GetInt32("restaurantId");
            return RedirectToAction("ConsultAll", "Restaurant", new { restaurantId = restoId });
        }


        public IActionResult ModifyDishById(int Dishid)
        {
            Dish dishToModify = Dish.GetDishById(Dishid, _menuDAL);
            DishViewModel vm = new DishViewModel();
            vm.Dish = dishToModify;
            TempData["ModifyDishId"] = vm.Dish.Id;
            return View("ModifyDish", vm);
        }

        public IActionResult ModifyMenuById(int MenuId)
        {
            string id = "";
            Menu SearchedMenu = Menu.GetMenuById(MenuId, _menuDAL);
            MenuViewModel vm = new MenuViewModel();
            vm.Menu = SearchedMenu;
            //on stocke l'id du menu en session car il disparait 
            HttpContext.Session.SetInt32("MenuId",vm.Menu.Id );
            HttpContext.Session.SetString("DishesId","");
            string sessionsDishid = "";
            foreach (var dish in vm.Menu.DishList)
            {
                if (sessionsDishid == "")
                {
                    id = dish.Id.ToString();
                    sessionsDishid += id;
                }
                else
                {
                    id = dish.Id.ToString();
                    sessionsDishid +=";"+ id;
                }
            }
            Restaurant r = new Restaurant();
            r.Id = (int)HttpContext.Session.GetInt32("restaurantId");
            vm.Dlist = r.GetDishes(_menuDAL);
            HttpContext.Session.SetString("DishesId", sessionsDishid);
            return View("ModifyMenu",vm);
        }


        //POST METHODS

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddDish(DishViewModel vm)
        {
            vm.RestaurantId=(int)HttpContext.Session.GetInt32("restaurantId");
            if (ModelState.IsValid)
            {
                ViewData["success"] = "true";
                Dish d = vm.Dish;
                Restaurant restaurant = new Restaurant();
                restaurant.Id = vm.RestaurantId;
                bool success = restaurant.AddDish(d, _menuDAL);
                if (success == true)
                {
                    return RedirectToAction("ConsultAll", "Restaurant", new { restaurantId = vm.RestaurantId });
                }
                else
                {
                    TempData["errorAddingDish"] = "true";
                    return View("Views/Menu/AddDish.cshtml", vm);
                }
                
            }
            return View("Views/Menu/AddDish.cshtml", vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddMenu(MenuViewModel vm)
        {
            if (ModelState.IsValid)
            {
                Menu menu = vm.Menu;
                string sessionIds = HttpContext.Session.GetString("DishesId");
                string[] idSplited = sessionIds.Split(";");
                foreach (var item in idSplited)
                {
                    int id = Int32.Parse(item);
                    Dish AddedDish = Dish.GetDishById(id, _menuDAL);
                    menu.DishList.Add(AddedDish);
                }
                Restaurant r = new Restaurant();
                r.Id = (int)HttpContext.Session.GetInt32("restaurantId");
                bool success = r.AddMenu(menu,_menuDAL);
                if (success == true)
                {
                    ViewData["MenuAdding"] = "true";
                    HttpContext.Session.SetString("DishesId", "");
                    return RedirectToAction("ConsultAll", "Restaurant", new { restaurantId = r.Id });
                }
                else
                {
                    ViewData["MenuAdding"] = "false";
                    return RedirectToAction("ConsultAll", "Restaurant", new { restaurantId = r.Id });
                }
               
            }
            return View("AddMenu", vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ModifyMenu(MenuViewModel vm)
        {
            if (ModelState.IsValid)
            {
                Menu menu = vm.Menu;
                menu.Id=(int)HttpContext.Session.GetInt32("MenuId");
                string sessionIds = HttpContext.Session.GetString("DishesId");
                string[] idSplited = sessionIds.Split(";");
                foreach (var item in idSplited)
                {
                    int id = Int32.Parse(item);
                    Dish AddedDish = Dish.GetDishById(id, _menuDAL);
                    menu.DishList.Add(AddedDish);
                }
                //
                int RestaurantId= (int)HttpContext.Session.GetInt32("restaurantId"); 
                bool success = menu.ModifyMenu(_menuDAL);
                if (success == true)
                {
                    ViewData["MenuModifying"] = "true";
                    HttpContext.Session.SetString("DishesId", "");
                    HttpContext.Session.SetInt32("MenuId", 0);
                    return RedirectToAction("ConsultAll", "Restaurant", new { restaurantId = RestaurantId});
                }
                else
                {
                    ViewData["MenuModifying"] = "false";
                    return RedirectToAction("ConsultAll", "Restaurant", new { restaurantId = RestaurantId});
                }

            }
            return View("ModifyMenu", vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddDishToMenu(int DishId, Menu menu, string operation)
        {
            if (HttpContext.Session.GetString("DishesId") != null && HttpContext.Session.GetString("DishesId") != "")
            {

                string sessionIds = HttpContext.Session.GetString("DishesId");
                sessionIds += ";" + DishId.ToString();
                HttpContext.Session.SetString("DishesId", sessionIds);
                sessionIds = HttpContext.Session.GetString("DishesId");
                string[] idSplited = sessionIds.Split(";");
                foreach (var item in idSplited)
                {
                    int id = Int32.Parse(item);
                    Dish AddedDish = Dish.GetDishById(id, _menuDAL);
                    menu.DishList.Add(AddedDish);
                }

            }
            else
            {
                Dish AddedDish = Dish.GetDishById(DishId, _menuDAL);
                menu.DishList.Add(AddedDish);
                HttpContext.Session.SetString("DishesId", DishId.ToString());
            }
            MenuViewModel vm = new MenuViewModel();
            vm.Menu = menu;
            Restaurant r = new Restaurant();
            r.Id = (int)HttpContext.Session.GetInt32("restaurantId");
            vm.Dlist = r.GetDishes(_menuDAL);
            if(operation== "modifying")
            {
                return View("ModifyMenu", vm);
            }
            else
            {
                return View("AddMenu", vm);
            }
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteDishFromMenu(int DishId,Menu menu, string operation)
        {
            if (HttpContext.Session.GetString("DishesId") != null && HttpContext.Session.GetString("DishesId") != "")
            {
                int flag = 0;
                menu.DishList = new List<Dish>();
                string sessionIds = HttpContext.Session.GetString("DishesId");
                sessionIds = HttpContext.Session.GetString("DishesId");
                string[] idSplited = sessionIds.Split(";");
                sessionIds = "";
                foreach (var item in idSplited)
                {
                    int id = Int32.Parse(item);
                    if (DishId != id)
                    {
                        if (sessionIds != "")
                        {
                            sessionIds += ";" + item;
                        }
                        if (sessionIds == "")
                        {
                            sessionIds += item;
                        }
                        
                    }
                    //GERER LES DOUBLONS (quand on veut supprimer un doublon)
                    if (DishId == id && flag == 1)
                    {
                        if (sessionIds != "")
                        {
                            sessionIds += ";" + item;
                        }
                        if (sessionIds == "")
                        {
                            sessionIds += item;
                        }
                        flag = 2;
                    }
                    //Permet de gerer le cas ou on voudrait supprimer un doublon d'un dish déjà ajouté
                    if (DishId == id && flag==0)
                    {
                        flag = 1;
                    }
                }
                if (sessionIds == "")
                {
                    menu.DishList= new List<Dish>();
                    HttpContext.Session.SetString("DishesId", "");

                }
                else
                {
                    HttpContext.Session.SetString("DishesId", sessionIds);
                    idSplited = sessionIds.Split(";");
                    foreach (var item in idSplited)
                    {
                        int id = Int32.Parse(item);
                        Dish AddedDish = Dish.GetDishById(id, _menuDAL);
                        menu.DishList.Add(AddedDish);
                    }
                }
            }
            MenuViewModel vm = new MenuViewModel();
            vm.Menu = menu;
            Restaurant r = new Restaurant();
            r.Id = (int)HttpContext.Session.GetInt32("restaurantId");
            vm.Dlist = r.GetDishes(_menuDAL);
            if (operation == "modifying")
            {
                return View("ModifyMenu", vm);
            }
            else
            {
                return View("AddMenu", vm);
            }
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdatingDish(DishViewModel vm)
        {
            int restoId=(int)HttpContext.Session.GetInt32("restaurantId");
            TempData["Updating"] = null;
            Dish DishToUpdate = vm.Dish;
            DishToUpdate.Id = (int)TempData["ModifyDishId"];
            if (ModelState.IsValid)
            {
                bool success = DishToUpdate.UpdateDish(_menuDAL);
                if (success == true)
                {
                    TempData["Updating"] = "success";
                    return RedirectToAction("ConsultAll", "Restaurant", new { restaurantId = restoId });
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

        
    }
}
