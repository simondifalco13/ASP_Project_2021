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
        //Signature de la méthode
        bool SaveCustomer(Customer accountC);
    }
}
