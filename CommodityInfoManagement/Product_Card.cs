using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommodityInfoManagement
{
    public partial class Product_Card : Form
    {
        public Product_Card()
        {
            InitializeComponent();
            comboBox2.Items.Add("A");
            comboBox2.Items.Add("B");
        }
    }
}
