using ASP_PROJECT.Models.Project;
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
    }
}
