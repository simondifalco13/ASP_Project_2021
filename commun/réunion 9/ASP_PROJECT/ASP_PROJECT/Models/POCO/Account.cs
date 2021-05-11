using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.Models.Project
{
    public abstract class Account
    {
        [Display(Name = "Nom")]
        [Required(ErrorMessage = "Le nom est requis.")]
        [StringLength(25,MinimumLength =3)]
        public string Lastname { get; set; }

        [Display(Name = "Prénom")]
        [Required(ErrorMessage = "Le prénom est requis.")]
        [StringLength(25, MinimumLength = 3)]
        public string Firstname { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "L'adresse mail est requise.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Mot de passe")]
        [Required(ErrorMessage = "Le mot de passe est requis.")]
        [DataType(DataType.Password)]
        [StringLength(15, ErrorMessage = "Le {0} doit avoir au moins {2} de long", MinimumLength = 8)]
        [RegularExpression("", ErrorMessage = "à voir")]

        public string Password { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }

        [Display(Name = "Numéro de téléphone")]
        [Required(ErrorMessage = "Le numéro de téléhpone est obligatoire")]
        [DataType(DataType.PhoneNumber)]
        public string Tel { get; set; }
        public char Gender { get; set; }
        public int Pc { get; set; }

        public Account(){

        }

        public void CreateAccount(){

        }
        public void Authentication(){

        }
        public void ConsultInformation(){

        }
        public void ModifyInformation(){

        }
    }
}
