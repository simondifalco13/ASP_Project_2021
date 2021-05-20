using ASP_PROJECT.Models.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.DAL.IDAL
{
    public interface IMenuDAL
    {
        bool AddDish(Dish d, Restaurant r);

        List<Dish> GetDishes(Restaurant r);

        bool SuppressDish(Dish d);

        bool SuppressMenu(Menu menu);

        List<Menu> GetMenus(Restaurant resto);

        Dish GetDishById(int id);

        Menu GetMenuById(int MenuId);

        bool UpdatingDish(Dish dish);
    }
}
