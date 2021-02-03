using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoInformacion
{
    public partial class admin : UserControl
    {
        private bool administrador = false;
        public admin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1234")
            {
                administrador = true;
                

                
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta");
            }
        }

        public bool getAdmin()
        {
            return administrador;
        }

        public void setAdmin(bool admin)
        {
            administrador = admin;
        }
        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void mensajeAdmin(object sender, EventArgs e)
        {
            if (administrador)
            {
                MessageBox.Show("Ya eres admin");
            }
        }
    }
}
