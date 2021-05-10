using ASP_PROJECT.DAL.IDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.Models.Project
{
    public enum TypeDish
    {
        Input,
        Dish,
        Dessert,
        Drink,
        Accompaniment
    }
    public class Dish : Meal
    {
        [Required(ErrorMessage = "Champs obligatoire")]
        [Display(Name = "Type de plat")]
        public TypeDish Type { get; set; }

        public Dish() : base()
        {

        }

        public Dish(TypeDish t):base()
        {
            Type = t;
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

        public static bool AddDish(Dish d,Restaurant r,IMenuDAL menuDAL)
        {
            bool success;
            success=menuDAL.AddDish(d, r);
            return success;
        }

        public static List<Dish> GetDishes(Restaurant r,IMenuDAL menuDAL)
        {
            List<Dish> list;
            list = menuDAL.GetDishes(r);
            return list;
        }
    }
}
