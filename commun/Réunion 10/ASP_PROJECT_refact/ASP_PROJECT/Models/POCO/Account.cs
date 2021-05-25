using ASP_PROJECT.DAL.IDAL;
using ASP_PROJECT.Models.Other;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.Models.POCO
{ 
    public abstract class Account{

        public int Id { get; set; }

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
        [Display(Name = "Mot de passe")]
        [DataType(DataType.Password)]
        [StringLength(32, ErrorMessage = "Le {0} doit avoir au moins {2} caractères de long")]
        // Regexp à tester : (simon) changement de la regex car elle n'allait pas 
        //[RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*?)[a-zA-Z]{8,}$", ErrorMessage = "Le mot de passe doit contenir au moins 8 caractères et posséder au minimum une majuscule")]
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
        
        //OK
        public  Account Login(IAccountDAL accountDAL){

            try
            {
                Account RecuperatedAccount = accountDAL.Login(this);
                return RecuperatedAccount;
            }
            catch(Exception e)
            {
                string message = e.Message;
                throw new Exception(message);
            }
        }
       

        //OK
        public bool VerifyExistingRestorer(IAccountDAL accountDAL)
        {
            Restorer restorer = (Restorer)this;
            bool existing = accountDAL.VerifyExistingRestorer(restorer);
            return existing;
        }
        //OK
        public bool VerifyExistingCustomer(IAccountDAL accountDAL)
        {
            Customer customer = (Customer)this;
            bool existing = accountDAL.VerifyExistingCustomer(customer);
            return existing;
        }
    }
}
