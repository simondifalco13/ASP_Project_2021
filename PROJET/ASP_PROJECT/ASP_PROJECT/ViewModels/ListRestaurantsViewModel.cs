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

        public ListRestaurantsViewModel(){
            Restos = new List<SelectListItem>();
            Resto = new Restaurant();
        }
        public ListRestaurantsViewModel(List<Restaurant> restos) : this() {
            ListRestoDb = restos;
            foreach (var rest in restos) {
                Restos.Add(new SelectListItem() { Value = rest.Id.ToString(), Text = rest.Name });
            }
        }
    }
}