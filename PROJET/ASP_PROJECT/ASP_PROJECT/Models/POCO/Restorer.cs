using ASP_PROJECT.DAL.IDAL;
using ASP_PROJECT.Models.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.Models.POCO
{
    public class Restorer : Account
    {

        public List<Restaurant> restaurantList;

        public Restorer() : base()
        {
            restaurantList = new List<Restaurant>();
        }

        public static bool Register(IAccountDAL accountDAL,Restorer r)
        {
            r.Password = Hash.CreateHash(r.Password);
            bool success = accountDAL.SaveRestorer(r);
            return success;
        }

        public static Restorer GetRestorerByMail(IAccountDAL accountDAL,string mail)
        {
            Restorer SearchedRestorer = accountDAL.GetRestorerByMail(mail);
            return SearchedRestorer;
        }

        public static bool ModifyRestorerInformations(IAccountDAL accountDAL,Restorer restorerToModify)
        {
            bool success = accountDAL.UpdateRestorerInformations(restorerToModify);
            return success;
        }

        public List<Restaurant> GetRestorerRestaurants(IRestaurantDAL restaurantDAL)
        {
            List<Restaurant> restaurants = restaurantDAL.GetRestorerRestaurantsById(this);
            return restaurants;
        }

        public static Restorer GetRestorerById(IAccountDAL accountDAL,Restorer restorer)
        {
            return restorer = accountDAL.GetRestorerById(restorer);
        }
    }
}
