using ASP_PROJECT.DAL.IDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.Models.POCO
{
    public enum OrderStatus
    {
        Validate,
        OnPreparation,
        //Retiré car manque de temps
        //OnDelivery,
        Finished
    }

 
    public class Order
    {

        public int Id { get; set; }

        public Customer Customer { get; set; }

        public Restaurant Restaurant { get; set; }

        public OrderStatus Status { get; set; }

        //public bool Delivery { get; set; }

        [Required(ErrorMessage = "Champs obligatoire")]
        [Display(Name = "Adresse de livraison")]
        public string DeliveryAdress { get; set; }

        [Display(Name = "Note")]
        public string Note { get; set; }

        [Display(Name = "Prix total")]
        public double TotalPrice { get; set; }

        [Display(Name = "Date de commande")]
        public DateTime DateOrder { get; set; }


        public List<Menu> listMenuOrdered;
        public List<Dish> listDishOrdered;

        public Order()
        {
            Customer = new Customer();
            Restaurant = new Restaurant();
            listMenuOrdered = new List<Menu>();
            listDishOrdered = new List<Dish>();
        }
        public Order(Restaurant resto,Customer customer) :this()
        {
            Restaurant = resto;
            Customer = customer;
        }

        public string ConvertOrderStatus()
        {
            string value = "";
            switch (this.Status)
            {
                case OrderStatus.Validate:
                    value = "Validée";
                    break;

                case OrderStatus.OnPreparation:
                    value = "En préparation";
                    break;

                case OrderStatus.Finished:
                    value = "Terminée";
                    break;

            }
            return value;

        }


        public void CalculateTotalPrice()
        {
            double totalDishes=0;
            foreach (var dish in this.listDishOrdered)
            {
                totalDishes += dish.Price;
            }

            double totalMenus = 0;
            foreach (var menu in this.listMenuOrdered)
            {
                totalMenus += menu.Price;
            }

            this.TotalPrice = totalDishes + totalMenus;
        }

        public bool ValidateOrder(IOrderDAL orderDAL)
        {
            bool success = orderDAL.AddOrder(this);
            return success;
        }

        public static Order GetOrderById(IOrderDAL orderDAL,int orderId)
        {
            return orderDAL.GetOrderById(orderId);
        }

        public bool UpdateOrderStatus(IOrderDAL orderDAL)
        {
            return orderDAL.UpdateOrderStatus(this);
        }
    }   
}
