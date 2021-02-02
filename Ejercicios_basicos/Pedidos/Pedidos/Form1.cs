using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pedidos
{
    public partial class Form1 : Form
    {
        double total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           if( checkBox1.Checked == true)
            {
                total+=0.74;
            }
            if (checkBox2.Checked == true)
            {
                total += 1.25;

            }
            if (checkBox3.Checked == true)
            {
                total += 3.21;

            }
            if (radioButton1.Checked == true)
            {
                total += 4.32;
            }
            if (radioButton2.Checked == true)
            {
                total += 5.00;
            }
            if (radioButton3.Checked == true)
            {
                total += 8.00;
            }
            textBox1.Text=total + "€";
            total = 0;
        }
    }
}
