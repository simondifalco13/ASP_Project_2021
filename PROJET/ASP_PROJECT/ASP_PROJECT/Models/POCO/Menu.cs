using ASP_PROJECT.DAL.IDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.Models.POCO
{
    public class Menu : Meal {
        [Display(Name = "Liste des plats")]
        public List<Dish> DishList;
        public int Id { get; set; }
        public Menu() : base() {
            DishList = new List<Dish>();
        }

        public override void Add()
        {

        }
        public override void Remove()
        {

        }
        public override void Modify()
        {

        }
        public static List<Menu> GetMenus(IMenuDAL menuDAL,Restaurant r) {

            return menuDAL.GetMenus(r.Id);
        }

        public static Menu GetMenuById(int MenuId, IMenuDAL menuDAL)
        {
            return menuDAL.GetMenuById(MenuId);
        }

        public static bool DeleteMenu(Menu menu, IMenuDAL menuDAL)
        {
            return menuDAL.SuppressMenu(menu);
        }
    }
}
