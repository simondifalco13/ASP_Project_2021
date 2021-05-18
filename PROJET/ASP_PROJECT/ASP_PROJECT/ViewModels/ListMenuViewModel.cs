using ASP_PROJECT.Models.POCO;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.ViewModels
{
    public class ListMenuViewModel
    {
        public List<Menu> ListMenuDb { get; set; }
        public List<SelectListItem> Menus { get; set; }
        public string SelectedId;
        public Menu Menu { get; set; }
        public ListMenuViewModel()
        {
            Menus = new List<SelectListItem>();
            Menu = new Menu();
        }
        public ListMenuViewModel(List<Menu> l) : this()
        {
            ListMenuDb = l;
            foreach (var menu in ListMenuDb)
            {
                Menus.Add(new SelectListItem() { Value = menu.Id.ToString(), Text = menu.Name });
            }
        }
    }
}
