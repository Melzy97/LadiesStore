using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LadiesStore.Models
{
    public class Cart
    {
        public int ID { get; set; }
        public int Product_Id { get; set; }
        public Product Products { get; set; }
        public int Number_Of_Product { get; set; }
        public Cart(Product product,int ld,int product_ld,int number_of_product)
        {
            Products = product;
            ID = ld;
            Product_Id = product_ld;
            Number_Of_Product = number_of_product;

        }
        
    }
}