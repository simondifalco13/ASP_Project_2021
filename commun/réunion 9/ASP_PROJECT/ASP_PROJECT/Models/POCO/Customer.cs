using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.Models.Project
{
    public class Customer : Account
    {
        [Display(Name = "Date de naissance")]
        [Required(ErrorMessage = "La date de naissance est requise.")]
        [DataType(DataType.Date)]
        public DateTime DoB { get; set; }

        public Customer() : base()
        {

        }
        public void GiveAnOpinion()
        {

        }
    }
}
