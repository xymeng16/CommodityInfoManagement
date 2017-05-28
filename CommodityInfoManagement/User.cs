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
    class User
    {
        private string __username;
        private USER_ROLE __role;
        private DateTime __datetime;

        public string Username { get => __username; set => __username = value; }
        public USER_ROLE Role { get => __role; set => __role = value; }
        public DateTime Datetime { get => __datetime; set => __datetime = value; }
    }
}
