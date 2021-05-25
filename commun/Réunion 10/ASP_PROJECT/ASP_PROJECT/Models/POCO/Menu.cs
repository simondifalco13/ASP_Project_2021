using ASP_PROJECT.DAL.IDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.Models.POCO
{
    public class Menu : Meal 
    {
        [Display(Name = "Liste des plats")]
        public List<Dish> DishList { get; set; }
        public int Id { get; set; }
        public Menu() : base() {
            DishList = new List<Dish>();
        }

        public Menu(List<Dish> dishes) : this()
        {
            DishList = dishes;
        }
        
       //restaurants : this pas en statique
        public static List<Menu> GetMenus(IMenuDAL menuDAL,Restaurant r) {

            return menuDAL.GetMenus(r);
        }

        
        public static Menu GetMenuById(int MenuId, IMenuDAL menuDAL)
        {
            return menuDAL.GetMenuById(MenuId);
        }

        //restaurant pas en statique avec this
        public static bool DeleteMenu(Menu menu, IMenuDAL menuDAL)
        {
            return menuDAL.SuppressMenu(menu);
        }

        //restaurant : pas en statique et restaurant en this
        public static bool AddMenu(Menu menu,Restaurant restaurant, IMenuDAL menuDAL)
        {
            return menuDAL.AddMenu( menu, restaurant);
        }

        //restaurant , this 
        public bool ModifyMenu(Menu menu,IMenuDAL menuDAL)
        {
            return menuDAL.UpdateMenu(menu);
        }
    }
}
