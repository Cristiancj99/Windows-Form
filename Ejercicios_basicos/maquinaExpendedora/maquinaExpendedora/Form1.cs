using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maquinaExpendedora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "1.50";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "1.50";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "2.00";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = "1.00";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = "1.50";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text = "2.50";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double importe = double.Parse(textBox2.Text);
            double introducido = double.Parse(textBox1.Text);

            if (introducido - importe < 0) {
                textBox3.Text = "Lo siento, saldo insuficiente";
            }
            else if (introducido - importe > 0)
            {
                double total = (int)(introducido - importe);
                textBox3.Text = "Muchas gracias, su cambio es: " + total;
            }

            else if(introducido - importe == 0)
            {
                textBox3.Text = "Muchas gracias.";
            }
        }
    }
}
