using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LadiesStore.Models
{
    public class Admin
    {
        public int ID { get; set; }
        public int Login_id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public Admin(int id,int login_id,string first_name,string last_name )
        {
            ID = id;
            Login_id = login_id;
            First_name = first_name;
            Last_name = last_name;
        }
    }
}