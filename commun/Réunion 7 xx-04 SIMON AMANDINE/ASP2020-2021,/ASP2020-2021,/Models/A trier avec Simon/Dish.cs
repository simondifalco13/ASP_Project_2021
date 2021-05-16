using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP2020_2021_.Models.A_trier_avec_Simon {
    enum typeDish {
        Input,
        Dish,
        Dessert,
        Drink,
        Accompaniment
    }
    public class Dish:Meal {
        typeDish type;

        public Dish():base() {

        }
        public override void Add() {

        }
        public override void Remove() {
            
        }
        public override void Modify() {
  
        }
    }
}
