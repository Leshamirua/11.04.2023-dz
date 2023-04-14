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
    public partial class GAS : Form
    {
        private double cost { get; set; }
        public GAS()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();
            MessageBox.Show(selectedState);
            switch (selectedState)
            {
                case "A-92":
                    textBox2 = "45.22";
                    break;
                case "A-95":
                    cost = 46.44;
                    break;
                case "A-95 EURO":
                    cost = 48.60;
                    break;
                case "A-100":
                    cost = 59.90;
                    break;
            }
             
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
