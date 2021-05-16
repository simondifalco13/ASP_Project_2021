using ASP_PROJECT.Models.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.DAL.IDAL
{
    public interface IAccountDAL
    {
        bool SaveRestorer(Restorer r);

        bool SaveCustomer(Customer accountC);

        //bool Login(string email, string password);
    }
}
