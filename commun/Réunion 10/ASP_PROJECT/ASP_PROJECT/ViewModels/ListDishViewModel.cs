using ASP_PROJECT.Models.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.ViewModels
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
