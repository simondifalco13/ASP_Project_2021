﻿using ASP_PROJECT.DAL.IDAL;
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

        }

        public static bool Register(IAccountDAL accountDAL,Restorer r)
        {
            r.Password = Hash.CreateHash(r.Password);
            bool success = accountDAL.SaveRestorer(r);
            return success;
        }
    }
}