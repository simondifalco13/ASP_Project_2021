using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.Models.POCO
{ 
    public class Opinion
    {
        public Restaurant Restaurant { get; set; }
        public Customer Customer { get; set; }
        [Display(Name = "Commentaire")]
        [StringLength(500)]
        public string OpinionDescription { get; set; }

        [Display(Name = "Note")]
        [Required(ErrorMessage = "Une note est obligatoire")]
        public int Rating { get; set; }

        public Opinion()
        {
            Restaurant = new Restaurant();
            Customer = new Customer();
        }

        public Opinion(Restaurant resto,Customer customer):this()
        {
            Restaurant = resto;
            Customer = customer;
        }
        public void ModerateOpinion()
        {

        }
    }
}
