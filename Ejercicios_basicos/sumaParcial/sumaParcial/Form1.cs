using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sumaParcial
{
    public partial class Form1 : Form
    {

        bool activado;
        int numero;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
 


        }



        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sumatoria = 0;
            numero = (int)numericUpDown1.Value;
            List<string> lista = new List<string>();


            for (int i = 0; i < numero; i++)
            {
                sumatoria += i;
                if (checkBox1.Checked == true)
                {
                    lista.Add("Sumando " + i + " La suma parcial es: " + sumatoria);


                }
               
            }
            lista.Add("El resultado final es: " + sumatoria);
            listBox1.DataSource = null;
            listBox1.DataSource = lista;
        }
    }
}
