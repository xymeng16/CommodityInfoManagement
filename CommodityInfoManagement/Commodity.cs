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
        private string name;
        private string __category;
        private string __owner;
        private Image __img;
        private string __length;
        private string __width;
        private string __height;
        private string __weight;
        private string __color;
        private string __shape;
        private string __description;
        private string __unit_price;
        private string __amount;
        public string Name { get => name; set => name = value; }
        public string Category { get => __category; set => __category = value; }
        public string Owner { get => __owner; set => __owner = value; }
        public Image Img { get => __img; set => __img = value; }
        public string Color { get => __color; set => __color = value; }
        public string Shape { get => __shape; set => __shape = value; }
        public string Description { get => __description; set => __description = value; }
        public string Length { get => __length; set => __length = value; }
        public string Width { get => __width; set => __width = value; }
        public string Height { get => __height; set => __height = value; }
        public string Weight { get => __weight; set => __weight = value; }
        public string Unit_price { get => __unit_price; set => __unit_price = value; }
        public string Amount { get => __amount; set => __amount = value; }

        public Commodity(string name, string category, string owner, Image img, string unit_price, string amount)
        {
            Name = name;
            Category = category;
            Owner = owner;
            Img = img;
            Unit_price = unit_price;
            Amount = amount;
        }

        public void BindToProductCard(Product_Card pc)
        {
            pc.SetCommAmount(Amount);
            pc.SetCommCategory(Category);
            pc.SetCommImage(Img);
            pc.SetCommName(Name);
            pc.SetCommPrice(Unit_price);
        }
    }
}
