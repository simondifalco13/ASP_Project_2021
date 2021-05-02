using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP2020_2021_.Models.A_trier_avec_Simon {
    enum typeService {
        Lunch,
        Evening
    }
    public abstract class Meal {
        typeService type;
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Meal() {

        }
        virtual public void Add() {

        }
        virtual public void Remove() {

        }
        virtual public void Modify() {

        }
    }
}
