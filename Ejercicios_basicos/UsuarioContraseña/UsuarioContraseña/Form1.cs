using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsuarioContraseña
{
    public partial class Form1 : Form
    {
        String usuario = "usuario";
        String contrasenia = "contraseña";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != usuario || textBox2.Text != contrasenia)
            {
                if(textBox1.Text != usuario)
                {
                    MessageBox.Show("usuario incorrecto");
                    textBox1.Clear();
                    return;
                        
                }

                if(textBox2.Text != contrasenia)
                {
                    MessageBox.Show("Contraseña incorrecto");
                    textBox2.Clear();
                    return;
                }


            }
            else
            {
                MessageBox.Show("Usuario Aceptado.");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
