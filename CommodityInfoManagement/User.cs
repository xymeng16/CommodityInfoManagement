using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommodityInfoManagement
{
    public class User
    {
        private string __username;
        private string __role;
        private DateTime __datetime;
        public static NameValueCollection RoleStr = new NameValueCollection();
        
        public string Username { get => __username; set => __username = value; }
        public string Role { get => __role; set => __role = value; }
        public DateTime Datetime { get => __datetime; set => __datetime = value; }

        public User(string username, string role, DateTime datetime)
        {
            Username = username;
            Role = role;
            Datetime = datetime;
            RoleStr.Add("消费者", "CUSTOMER");
            RoleStr.Add("卖家", "SHOPKEEPER");
            RoleStr.Add("管理员", "ADMIN");
            RoleStr.Add("超级管理员", "SUPER_USER");
            RoleStr.Add("CUSTOMER", "消费者");
            RoleStr.Add("SHOPKEEPER", "卖家");
            RoleStr.Add("ADMIN", "管理员");
            RoleStr.Add("SUPER_USER", "超级管理员");
        }
    }
}
