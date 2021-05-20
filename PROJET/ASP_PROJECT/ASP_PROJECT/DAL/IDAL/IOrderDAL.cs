﻿using ASP_PROJECT.Models.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.DAL.IDAL
{
    public interface IOrderDAL
    {
        List<Order> GetRestaurantOrders(Restaurant restaurant);

        public List<int> GetMenusIdInMenuDetails(Order order);

        public List<int> GetDishesIdInMenuDetails(Order order);

    }
}