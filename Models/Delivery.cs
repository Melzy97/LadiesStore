using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LadiesStore.Models
{
    public class Delivery
    {
        public int Product_ld { get; set; }
        public int Customer_ld { get; set; }
        public DateTime CurrentDate { get; set; }
        public DateTime DeliveryDate{ get; set; }
        public string DeliveryType { get; set; }
        public Delivery(int product_Id,int customer_ld, DateTime currentDate, DateTime delivery_date,string deliveryType)
        {
            Product_ld = product_Id;
            Customer_ld = customer_ld;
            CurrentDate = currentDate;
            DeliveryDate = delivery_date;
            DeliveryType = deliveryType;

        }
        
    }
}