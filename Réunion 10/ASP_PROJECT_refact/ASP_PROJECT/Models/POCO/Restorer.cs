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

        public override bool Register(IAccountDAL accountDAL)
        {
            this.Password = Hash.CreateHash(this.Password);
            bool success = accountDAL.SaveRestorer(this);
            return success;
        }


        public static Restorer GetRestorerByMail(IAccountDAL accountDAL,string mail)
        {
            Restorer SearchedRestorer = accountDAL.GetRestorerByMail(mail);
            return SearchedRestorer;
        }

        public  bool ModifyRestorerInformations(IAccountDAL accountDAL)
        {
            bool success = accountDAL.UpdateRestorerInformations(this);
            return success;
        }

        public List<Restaurant> GetRestorerRestaurants(IRestaurantDAL restaurantDAL)
        {
            List<Restaurant> restaurants = restaurantDAL.GetRestorerRestaurantsById(this);
            return restaurants;
        }

        public static  Restorer GetRestorerById(IAccountDAL accountDAL,int id)
        {
            Restorer restorer = new Restorer();
            return restorer = accountDAL.GetRestorerById(id);
        }


        public  bool SignRestaurant(Restaurant resto,IRestaurantDAL restaurantDAL)
        {
            try
            {
                bool success = restaurantDAL.SignRestaurant(this, resto);
                return success;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        
    }
}
