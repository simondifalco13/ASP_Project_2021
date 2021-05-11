using ASP_PROJECT.Models.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.ViewModels.Simon
{
    public class ListDishViewModel
    {
        public List<Dish> ListDishesDb;

        public ListDishViewModel(List<Dish> l)
        {
            ListDishesDb = l;
        }

    }
}
