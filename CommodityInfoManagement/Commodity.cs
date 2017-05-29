using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace CommodityInfoManagement
{
    public class Commodity
    {
        private int __id;
        private string name;
        private string __catrgory;
        private User __owner;
        //private Image 

        public int Id { get => __id; set => __id = value; }
        public string Name { get => name; set => name = value; }
        public string Catrgory { get => __catrgory; set => __catrgory = value; }
        public User Owner { get => __owner; set => __owner = value; }
    }
}
