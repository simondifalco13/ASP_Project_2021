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

        public Customer(List<Order> Orders) : this()
        {
            OrdersList = Orders;
        }
        public void GiveAnOpinion()
        {

        }

        //this et pas static : mettre une classe dans Account et faire hériter -> override
        public static bool Register(IAccountDAL DAL, Customer accountC) {
            accountC.Password = Hash.CreateHash(accountC.Password);
            bool success = DAL.SaveCustomer(accountC);
            return success;
        }

        //verifie si pas d'instance avant 
        public static Customer GetCustomerByMail(IAccountDAL accountDAL, string mail)
        {
            Customer SearchedCustomer = accountDAL.GetCustomerByMail(mail);
            return SearchedCustomer;
        }

        //verifie si pas d'instance avant 
        public static Customer GetCustomerById(IAccountDAL accountDAL, int customerId)
        {
            Customer SearchedCustomer = accountDAL.GetCustomerById(customerId);
            return SearchedCustomer;
        }

        //this: pas methode statique 
        public static bool ModifyCustomerInformations(IAccountDAL accountDAL, Customer customerToModify)
        {
            bool success = accountDAL.UpdateCustomerInformations(customerToModify);
            return success;
        }

        
    }
}
