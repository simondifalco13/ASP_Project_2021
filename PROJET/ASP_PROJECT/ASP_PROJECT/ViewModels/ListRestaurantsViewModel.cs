using ASP_PROJECT.Models.POCO;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.ViewModels {
    public class ListRestaurantsViewModel {

        public List<SelectListItem> Restos { get; set; }
        public List<Restaurant> ListRestoDb { get; set; }
        public Restaurant Resto { get; set; }
        

        public ListRestaurantsViewModel()
        {
            Restos = new List<SelectListItem>();
            Resto = new Restaurant();
            SelectedListMenus = new List<Menu>();
            SelectedListDish = new List<Dish>();
        }
        public ListRestaurantsViewModel(List<Restaurant> restos) : this()
        {
            ListRestoDb = restos;
            foreach (var rest in restos)
            {
                Restos.Add(new SelectListItem() { Value = rest.Id.ToString(), Text = rest.Name });
            }
        }
        public ListRestaurantsViewModel(Restaurant resto):this(){
            foreach (var meal in resto.mealList) {
                if(meal is Menu) {
                    SelectedListMenus.Add(meal as Menu);
                } else {
                    SelectedListDish.Add(meal as Dish);
                }
            }
            Resto = resto;
        }

        // Si je rajoute une propriété qui ajoute une liste de dish et de menus.
        // J'arri
        public List<Menu> SelectedListMenus { get; set; }
        public List<Dish> SelectedListDish { get; set; }
    }
}