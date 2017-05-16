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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Utility.TestDBConnection();
            comboBox1.Items.Add("ALL");
            comboBox1.Items.Add("GOODS A");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
