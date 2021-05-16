using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.Models.POCO
{
    public class Customer : Account
    {
        public DateTime DoB { get; set; }

        public Customer() : base()
        {

        }
        public void GiveAnOpinion()
        {

        }
    }
}
