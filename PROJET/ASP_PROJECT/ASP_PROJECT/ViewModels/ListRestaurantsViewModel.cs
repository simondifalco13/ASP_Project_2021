﻿using ASP_PROJECT.Models.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.ViewModels {
    public class ListRestaurantsViewModel {

        public Restaurant Resto { get; set; }

        public ListRestaurantsViewModel(){
            Resto = new Restaurant();    
        }
    }
}