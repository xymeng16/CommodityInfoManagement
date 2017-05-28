using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommodityInfoManagement
{
    public enum USER_ROLE
    {
        CUSTOMER,
        SHOPKEEPER,
        ADMIN,
        SUPERUSER
    };
    public class User
    {
        private string __username;
        private string __role;
        private DateTime __datetime;

        public string Username { get => __username; set => __username = value; }
        public string Role { get => __role; set => __role = value; }
        public DateTime Datetime { get => __datetime; set => __datetime = value; }

        public User(string username, string role, DateTime datetime)
        {
            Username = username;
            Role = role;
            Datetime = datetime;
        }
    }
}
