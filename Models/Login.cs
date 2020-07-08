using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LadiesStore.Models
{
    public class Login
    {
        public int ID { get; set; }
        public string User_name { get; set; }
        public string Password{ get; set; }
        public Login(int id, string user_name, string password)
        {
            ID = id;
            User_name = user_name;
            Password = password;
        }
    }
}