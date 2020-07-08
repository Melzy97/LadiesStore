using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Web;

namespace LadiesStore.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int Customer_id { get; set; }
        public Customer Customers { get; set; }
        public int Cart_id { get; set; }
        public string Description { get; set; }
        public DateTime Payment_date { get; set; }
        public double Amount{ get; set; }
        public Payment(Customer customers, int id, int customer_id, int cart_id, string description, DateTime payment_date, double amount)
        {
            Id = id;
            Customer_id = customer_id;
            Cart_id = cart_id;
            Customers = customers;
            Description = description;
            Payment_date = payment_date;
            Amount = amount;
        }    
    }
}