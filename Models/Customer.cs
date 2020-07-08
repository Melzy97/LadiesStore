using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LadiesStore.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public int Login_id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Customer(int id, int login_id, string first_name, string last_name,string mobile,string email,string address,DateTime date_of_birth)
        {
            ID = id;
            Login_id = login_id;
            First_name = first_name;
            Last_name = last_name;
            Mobile = mobile;
            Email = email;
            Address = address;
            DateOfBirth = date_of_birth;
        }
    }
}