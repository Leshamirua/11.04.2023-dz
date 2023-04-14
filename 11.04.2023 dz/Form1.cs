using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11._04._2023_dz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            GAS gas = new GAS();
            gas.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CAFE cafe = new CAFE();
            cafe.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PROPERTIES properties = new PROPERTIES();
            this.Hide();
            properties.Show();
        }
    }
}
