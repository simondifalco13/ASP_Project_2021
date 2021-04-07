using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP2020_2021_.Models.A_trier_avec_Simon {
    enum orderStatus {
        Validate,
        OnPreparation,
        OnDelivery,
        Finished
    }
    public class Order {
        orderStatus status;
        public bool Delivery { get; set; }
        public string DeliveryAdress { get; set; }
        public string Note { get; set; }
        public double TotalPrice { get; set; }
        public DateTime DateOrder { get; set; }

        // J'ai des doutes? 
        public List<Menu> listMenuOrdered;
        public List<Dish> listDishOrdered;

        public Order() {

        }
        public void DisplayOrder() {

        }
        public void ValidateOrder() {

        }
        public void CancelOrder() {

        }
        public void UpdateOrderStatus() {

        }
        public void AddItemToCart() {

        }
        public void DisplayCart() {

        }
        public void CalculatePrice() {

        }
    }
}
