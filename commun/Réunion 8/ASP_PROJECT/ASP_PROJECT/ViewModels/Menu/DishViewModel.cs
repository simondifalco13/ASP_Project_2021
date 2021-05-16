using ASP_PROJECT.Models.Project;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.ViewModels.Simon
{
 
    public class DishViewModel
    {
        public Dish Dish { get; set; }
        public DishViewModel()
        {
            Dish = new Dish();
            
        }

        public List<SelectListItem> TypeDish { get; set; } = new List<SelectListItem>
        {
            new SelectListItem(){Value="Input",Text="Entrée"},
            new SelectListItem(){Value="Dish",Text="Plat"},
            new SelectListItem(){Value="Dessert",Text="Dessert"},
            new SelectListItem(){Value="Drink",Text="Boisson"},
            new SelectListItem(){Value="Accompaniment",Text="Accompagnement"}
        };

        public List<SelectListItem> TypeService { get; set; } = new List<SelectListItem>
        {
            new SelectListItem(){Value="Lunch",Text="Diner"},
            new SelectListItem(){Value="Evening",Text="Soir"}
        };
    }
}
