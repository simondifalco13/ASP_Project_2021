using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.Models.POCO
{ 
    public abstract class Account
    {
        [Required(ErrorMessage = "Champs obligatoire")]
        [Display(Name = "Nom")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Champs obligatoire")]
        [Display(Name = "Prénom ")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Champs obligatoire")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        //mettre regex pour le password
        [Required(ErrorMessage = "Champs obligatoire")]
        [Display(Name = "password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Champs obligatoire")]
        [Display(Name = "Pays")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Champs obligatoire")]
        [Display(Name = "Adresse")]
        public string Adress { get; set; }

        [Required(ErrorMessage = "Champs obligatoire")]
        [Display(Name = "Ville")]
        public string City { get; set; }

        [Required(ErrorMessage = "Champs obligatoire")]
        [Display(Name = "Téléphone")]
        public string Tel { get; set; }

        [Display(Name = "Genre")]
        public char Gender { get; set; }

        [Required(ErrorMessage = "Champs obligatoire")]
        [Display(Name = "Code Postal")]
        public string Pc { get; set; }

        public Account()
        {

        }

        public void CreateAccount()
        {

        }
        public void Authentication()
        {

        }
        public void ConsultInformation()
        {

        }
        public void ModifyInformation()
        {

        }

    }
}
