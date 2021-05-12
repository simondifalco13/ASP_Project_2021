﻿using ASP_PROJECT.DAL.IDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.Models.POCO
{
    public enum RestaurantType
    {
        Asian,
        Mexican,
        Snack,
        African,
        Thaï,
        Greek,
        Sushi,
        Spanish,
        Pizza,
        Italian
    }
    public class Restaurant
    {
        public int Id { get; set; }
        public RestaurantType Type { get; set; }

        [Display(Name="Nom du restaurant")]
        [Required(ErrorMessage = "Champs obligatoire")]
        [StringLength(20, MinimumLength = 3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Champs obligatoire")]
        [StringLength(50, MinimumLength = 10)]
        [Display(Name = "Adresse du restaurant")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Champs obligatoire")]
        [StringLength(35, MinimumLength = 5)]
        [Display(Name = "Ville du restaurant")]
        public string City { get; set; }

        [Required(ErrorMessage = "Champs obligatoire")]
        [StringLength(20, MinimumLength = 3)]
        [Display(Name = "Pays du restaurant")]
        public string Country { get; set; }

        [StringLength(500)]
        [Display(Name="Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Champs obligatoire")]
        [Display(Name = "Téléphone du restaurant")]
        [DataType(DataType.PhoneNumber)]
        public string Tel { get; set; }

        [Required(ErrorMessage = "Champs obligatoire")]
        [StringLength(6, MinimumLength = 3)]
        [Display(Name = "Code Postal")]
        public string Pc { get; set; }

        [Required(ErrorMessage = "Champs obligatoire")]
        [StringLength(20, MinimumLength = 10)]
        [Display(Name = "TVA")]
        public string NumTVA { get; set; }


        public List<string> DeliveryCities;
        public DateTime[][] OpeningHours;

        public List<Opinion> opinionList;
        public List<Meal> mealList;

        public Restaurant()
        {

        }

        public Restaurant(string name,string adress,string country,string description,string tel,string pc,string ntva,string type)
        {
            Name = name;
            Address = adress;
            Country = country;
            Description = description;
            Tel = tel;
            Pc = pc;
            NumTVA = ntva;
            RestaurantType t;
            Enum.TryParse(type, out t);
            Type = t;
        }

        public void OrderByRestaurant()
        {

        }
        public void SignRestaurant()
        {

        }
        public void DisplayOpinion()
        {

        }

        public void GetRestaurant(Restaurant r,IRestaurantDAL restaurantDAL)
        {
            r = restaurantDAL.GetRestaurantById(r.Id);
        }
    }
}
