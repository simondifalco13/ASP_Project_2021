using ASP_PROJECT.Models.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.DAL.IDAL
{
    public interface IRestaurantDAL 
    {
        Restaurant GetRestaurantById(int id);
    }
}
