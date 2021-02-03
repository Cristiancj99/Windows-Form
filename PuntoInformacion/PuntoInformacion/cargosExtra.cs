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
    public partial class cargosExtra : UserControl
    {
        public cargosExtra()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EquipoDirectivo extra = new EquipoDirectivo();
            if (extra.Contains(extra) == false)
            {
                this.Controls.Add(extra);
                extra.Dock = DockStyle.Fill;
                extra.BringToFront();
            }
            else
            {
                extra.BringToFront();
            }
        }
    }
}
