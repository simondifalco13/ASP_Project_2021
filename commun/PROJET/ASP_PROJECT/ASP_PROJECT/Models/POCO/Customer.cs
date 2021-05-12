﻿using ASP_PROJECT.DAL.IDAL;
using System;
using System.Collections.Generic;
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

        public Customer() : base(){

        }
        public void GiveAnOpinion()
        {

        }
        public static bool Register(IAccountDAL DAL, Customer accountC) {
            // Pour permettre de prévenir l'utilisateur.
            bool success = DAL.SaveCustomer(accountC);
            return success;
        }
    }
}
