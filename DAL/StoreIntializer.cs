using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using LadiesStore.Models;

namespace LadiesStore.DAL
{
    public class StoreInitializer:DropCreateDatabaseAlways<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            var shoppings = new List<Shopping>
            {

            };
        }
    }
}