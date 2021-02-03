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
    public partial class Principal : UserControl
    {
        public Boolean admin;
        public Principal()
        {
            InitializeComponent();
            btnAdmin.setText("acceder");
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://twitter.com/cescristorey?lang=es");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.instagram.com/cescristorey/?hl=es");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                System.Diagnostics.Process.Start("https://www.cescristorey.com");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            admin = true;
        }
        public bool getAdmin()
        {
            return admin;
        }

        private void btnAzul1_Load(object sender, EventArgs e)
        {

        }
    }

}
