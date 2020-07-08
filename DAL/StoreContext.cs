using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using LadiesStore.Models;

namespace LadiesStore.DAL
{
    public class StoreContext:DbContext
    {
        public StoreContext() : base("LadiesStore") { }
        public DbSet<Admin>Admins { get; set; }
        public DbSet<Cart>ShoppingCart { get; set; }
        public DbSet <Login>Logins { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Payment> Payments { get; set; }

    }
}