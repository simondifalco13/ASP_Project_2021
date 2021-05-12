using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.Models.Project
{
    public enum TypeService
    {
        Lunch,
        Evening
    }
    public abstract class Meal
    {
        [Required(ErrorMessage = "Champs obligatoire")]
        [Display(Name = "Type de service")]
        public TypeService Service { get; set; }

        [Required(ErrorMessage="Champs obligatoire")]
        [Display(Name = "Nom")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Champs obligatoire")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Champs obligatoire")]
        [Display(Name = "Prix")]
        public double Price { get; set; }

        public Meal()
        {

        }
        virtual public void Add()
        {

        }
        virtual public void Remove()
        {

        }
        virtual public void Modify()
        {

        }

        public string ConvertTypeService()
        {
            string value = "";
            switch (this.Service)
            {
                case TypeService.Evening:
                    value = "Soir";
                    break;

                case TypeService.Lunch:
                    value = "Midi";
                    break;
            }
            return value;
        }
    }
}
