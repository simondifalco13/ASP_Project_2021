using ASP_PROJECT.DAL.IDAL;
using System;
using System.Collections.Generic;
using ASP_PROJECT.Models.Other;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.Models.POCO
{
    public class Customer : Account
    {
        [Display(Name = "Date de naissance")]
        [Required(ErrorMessage = "La date de naissance est obligatoire")]
        [DataType(DataType.Date)]
        public DateTime DoB { get; set; }

        public List<Order> OrdersList;

        public Customer() : base(){
            OrdersList=new List<Order>();
        }
        public void GiveAnOpinion()
        {

        }
        public static bool Register(IAccountDAL DAL, Customer accountC) {
            // Pour permettre de prévenir l'utilisateur.
            accountC.Password = Hash.CreateHash(accountC.Password);
            bool success = DAL.SaveCustomer(accountC);
            return success;
        }

        public static Customer GetCustomerByMail(IAccountDAL accountDAL, string mail)
        {
            Customer SearchedRestorer = accountDAL.GetCustomerByMail(mail);
            return SearchedRestorer;
        }

        public static bool ModifyCustomerInformations(IAccountDAL accountDAL, Customer customerToModify)
        {
            bool success = accountDAL.UpdateCustomerInformations(customerToModify);
            return success;
        }
    }
}
