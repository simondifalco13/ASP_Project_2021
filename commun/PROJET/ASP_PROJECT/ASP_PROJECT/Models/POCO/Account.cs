using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.Models.POCO
{ 
    public abstract class Account{

        [Required(ErrorMessage = "Champs obligatoire")]
        [StringLength(25, MinimumLength = 3)]
        [Display(Name = "Nom")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Champs obligatoire")]
        [StringLength(25, MinimumLength = 3)]
        [Display(Name = "Prénom")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Champs obligatoire")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
   
        [Required(ErrorMessage = "Champs obligatoire")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [StringLength(32, ErrorMessage = "Le {0} doit avoir au moins {2} de long", MinimumLength = 10)]
        // Regexp à tester
        [RegularExpression("^((?=.*?[A-Z]))", ErrorMessage = "Le mot de passe doit contenir au moins 8 caractères et posséder au minimum une majuscule")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Champs obligatoire")]
        [StringLength(20, MinimumLength = 3)]
        [Display(Name = "Pays")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Champs obligatoire")]
        [StringLength(50, MinimumLength = 10)]
        [Display(Name = "Adresse")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Champs obligatoire")]
        [StringLength(35, MinimumLength = 5)]
        [Display(Name = "Ville")]
        public string City { get; set; }

        [Required(ErrorMessage = "Champs obligatoire")]
        [Display(Name = "Téléphone")]
        [DataType(DataType.PhoneNumber)]
        public string Tel { get; set; }

        
        [Display(Name = "Genre")]
        public char Gender { get; set; }

        [Required(ErrorMessage = "Champs obligatoire")]
        [StringLength(6, MinimumLength = 3)]
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
