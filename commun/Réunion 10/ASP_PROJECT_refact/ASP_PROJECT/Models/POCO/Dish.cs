using ASP_PROJECT.DAL.IDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.Models.POCO
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

        public int Id { get; set; }

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
       
       

        public  string ConvertDishType()
        {
            string value="";
            switch (this.Type)
            {
                case TypeDish.Input:
                    value="Entrée";
                    break;

                case TypeDish.Dish:
                    value = "Plat";
                    break;

                case TypeDish.Dessert:
                    value = "Dessert";
                    break;

                case TypeDish.Drink:
                    value = "Boisson";
                    break;

                case TypeDish.Accompaniment:
                    value = "Accompagnement";
                    break;


            }
            return value;

        }

        public bool DeleteDish(IMenuDAL menuDAL)
        {
            bool success = false;
            success = menuDAL.SuppressDish(this);
            return success;
        }


        public static Dish GetDishById(int id,IMenuDAL menuDAL)
        {
            Dish SearchedDish = menuDAL.GetDishById(id);
            return SearchedDish;
        }

        public  bool UpdateDish(IMenuDAL menuDAL)
        {
            bool success = menuDAL.UpdatingDish(this);
            return success;
        }
    }
}
