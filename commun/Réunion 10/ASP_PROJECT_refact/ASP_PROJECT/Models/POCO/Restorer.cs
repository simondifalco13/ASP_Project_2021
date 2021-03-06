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

        //OK
        public  bool Register(IAccountDAL accountDAL)
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

        //OK
        public  bool ModifyRestorerInformations(IAccountDAL accountDAL)
        {
            bool success = accountDAL.UpdateRestorerInformations(this);
            return success;
        }

        //OK
        public List<Restaurant> GetRestorerRestaurants(IRestaurantDAL restaurantDAL)
        {
            List<Restaurant> restaurants = restaurantDAL.GetRestorerRestaurantsById(this);
            return restaurants;
        }

        //OK
        public  Restorer GetRestorerById(IAccountDAL accountDAL)
        {
            Restorer restorer = new Restorer();
            return restorer = accountDAL.GetRestorerById(this);
        }

        //OK
        public  bool SignRestaurant(Restaurant resto,IRestaurantDAL restaurantDAL)
        {
            try
            {
                //passer restorer en this
                bool success = restaurantDAL.SignRestaurant(this, resto);
                return success;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //OK
        public void GetRestaurant(Restaurant r, IRestaurantDAL restaurantDAL)
        {
            r = restaurantDAL.GetRestaurantById(r);
        }
    }
}
