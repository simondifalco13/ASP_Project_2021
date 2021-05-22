using ASP_PROJECT.Models.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.ViewModels
{
    public class SignRestaurantViewModel
    {
        public int restorerId { get; set; }
        public Restaurant Resto { get; set; }
        //Days:  Opening Time and Close time
        public string MondayOt { get; set; }
        public string MondayCt{get;set;}
        public string TuesdayOt { get;set;}
        public string TuesdayCt { get;set;}
        public string WednesdayOt { get;set;}
        public string WednesdayCt { get;set;}
        public string ThursdayOt { get;set;}
        public string ThursdayCt { get;set;}
        public string FridayOt { get;set;}
        public string FridayCt { get;set;}
        public string SaturdayOt { get;set;}
        public string SaturdayCt { get;set;}
        public string SundayOt { get;set;}
        public string SundayCt { get;set;}
        //public string DeliveryCity { get; set; }

        //public List<String> cities { get; set; }

        public SignRestaurantViewModel()
        {
            Resto = new Restaurant();
            //cities= new List<string>();
        }   
    }
}   
