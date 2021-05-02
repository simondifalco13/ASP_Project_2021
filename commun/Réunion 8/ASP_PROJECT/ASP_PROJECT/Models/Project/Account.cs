using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.Models.Project
{
    public abstract class Account
    {
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Country { get; set; }
        public string Adress { get; set; }
        public string Tel { get; set; }
        public char Gender { get; set; }
        public int Pc { get; set; }

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
