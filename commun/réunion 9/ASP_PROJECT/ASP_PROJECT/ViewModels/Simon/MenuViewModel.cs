using ASP_PROJECT.Models.Project;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.ViewModels.Simon
{
    public class MenuViewModel
    {
        public List<Dish> Dlist;
        public Menu Menu { get; set; }
        public Dish SelectedDish { get; set; }
        public MenuViewModel()
        {
            Menu = new Menu();
            Dlist = new List<Dish>();
            MenuDishList = new List<Dish>();
        }

        public MenuViewModel(List<Dish> l) :this()
        {
            Dlist = l;
            //foreach (var d in l)
            //{
            //    DishesList.Add(new SelectListItem() { Value = d.Name, Text = d.Name });
            //}
        }

       
        public List<SelectListItem> TypeService { get; set; } = new List<SelectListItem>
        {
            new SelectListItem(){Value="Lunch",Text="Diner"},
            new SelectListItem(){Value="Evening",Text="Soir"}
        };

        public List<SelectListItem> DishesList { get; set; } = new List<SelectListItem>();

        public List<Dish> MenuDishList;
    }
}
