using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.Models.Project
{
    public class Menu : Meal
    {
        [Display(Name ="Liste des plats")]
        public List<Dish> DishList;
        public Menu() : base()
        {

        }
        public override void Add()
        {

        }
        public override void Remove()
        {

        }
        public override void Modify()
        {

        }
    }
}
