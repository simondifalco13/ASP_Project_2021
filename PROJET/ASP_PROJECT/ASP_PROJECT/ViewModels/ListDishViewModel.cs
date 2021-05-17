using ASP_PROJECT.Models.POCO;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.ViewModels
{
    public class ListDishViewModel
    {
        public List<Dish> ListDishesDb { get; set; }
        public List<SelectListItem> Dishes { get; set; }
        public string SelectedId;
        public Dish Dish { get; set; }
        public ListDishViewModel()
        {
            Dishes = new List<SelectListItem>();
            Dish = new Dish();
        }
        public ListDishViewModel(List<Dish> l) : this()
        {
            ListDishesDb = l;
            foreach (var dish in ListDishesDb)
            {
                Dishes.Add(new SelectListItem() { Value = dish.Id.ToString(), Text = dish.Name });
            }
        }
    }
}
