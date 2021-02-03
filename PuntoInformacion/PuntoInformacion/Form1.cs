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
    public partial class Form1 : Form
    {
        public bool admin;
        Principal principal;
        admin ad = new admin();
        Database bd;

        public Form1()
        {
             bd = new Database();

            InitializeComponent();
            principal = new Principal();
            panelEjecutado.Controls.Add(principal);
            principal.Dock = DockStyle.Fill;
            principal.BringToFront();
            admin = false;
            panelActivo.Height = btnInicio.Height;
            panelActivo.Top = btnInicio.Top;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ad.getAdmin())
            {
                btnAdmin.Text = "salid del admin";
                btnAdmin.BackColor = Color.Red;
            }
            panelActivo.Height = btnEquipoDirectivo.Height;
            panelActivo.Top = btnEquipoDirectivo.Top;
            EquipoDirectivo equipoDirectivo = new EquipoDirectivo();
            if(panelEjecutado.Contains(equipoDirectivo) == false)
            {
                panelEjecutado.Controls.Add(equipoDirectivo);
                equipoDirectivo.Dock = DockStyle.Fill;
                equipoDirectivo.BringToFront();
            }
            else
            {
                equipoDirectivo.BringToFront();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ad.getAdmin())
            {
                btnAdmin.Text = "salid del admin";
                btnAdmin.BackColor = Color.Red;
            }
            panelActivo.Height = btnPuntosInteres.Height;
            panelActivo.Top = btnPuntosInteres.Top;
            puntosInteres puntoInteres = new puntosInteres( ad.getAdmin());
            if (panelEjecutado.Contains(puntoInteres) == false)
            {
                panelEjecutado.Controls.Add(puntoInteres);
                puntoInteres.Dock = DockStyle.Fill;
                puntoInteres.BringToFront();
            }
            else
            {
                puntoInteres.BringToFront();
            }

        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (ad.getAdmin())
            {
                btnAdmin.Text = "salid del admin";
                btnAdmin.BackColor = Color.Red;
            }
            panelActivo.Height = btnHorarioEscolar.Height;
            panelActivo.Top = btnHorarioEscolar.Top;
            horarioEscolar horarioEscolar = new horarioEscolar();
            if (panelEjecutado.Contains(horarioEscolar) == false)
            {
                panelEjecutado.Controls.Add(horarioEscolar);
                horarioEscolar.Dock = DockStyle.Fill;
                horarioEscolar.BringToFront();
            }
            else
            {
                horarioEscolar.BringToFront();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (ad.getAdmin())
            {
                btnAdmin.Text = "salid del admin";
                btnAdmin.BackColor = Color.Red;
            }
            panelActivo.Height = btnSugerencias.Height;
            panelActivo.Top = btnSugerencias.Top;
            controlSugerencias sugerencia = new controlSugerencias();
            if (panelEjecutado.Contains(sugerencia) == false)
            {
                panelEjecutado.Controls.Add(sugerencia);
                sugerencia.Dock = DockStyle.Fill;
                sugerencia.BringToFront();
            }
            else
            {
                sugerencia.BringToFront();
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (ad.getAdmin())
            {
                btnAdmin.Text = "salid del admin";
                btnAdmin.BackColor = Color.Red;
            }
            panelActivo.Height = btnInicio.Height;
            panelActivo.Top = btnInicio.Top;
            Principal inicio = new Principal();
            if (panelEjecutado.Contains(inicio) == false)
            {
                panelEjecutado.Controls.Add(inicio);
                inicio.Dock = DockStyle.Fill;
                inicio.BringToFront();
            }
            else
            {
                inicio.BringToFront();
            }
        }

        private void btnCentro_Click(object sender, EventArgs e)
        {
            if (ad.getAdmin())
            {
                btnAdmin.Text = "salid del admin";
                btnAdmin.BackColor = Color.Red;
            }
            proximamente proximo = new proximamente();
            panelActivo.Height = btnCentro.Height;
            panelActivo.Top = btnCentro.Top;
            if (panelEjecutado.Contains(proximo) == false)
            {
                panelEjecutado.Controls.Add(proximo);
                proximo.Dock = DockStyle.Fill;
                proximo.BringToFront();
            }
            else
            {
                proximo.BringToFront();
            }

        }

        private void btnHorarios_Click(object sender, EventArgs e)
        {
            if (ad.getAdmin())
            {
                btnAdmin.Text = "salid del admin";
                btnAdmin.BackColor = Color.Red;
            }
            proximamente proximo = new proximamente();
            panelActivo.Height = btnHorarios.Height;
            panelActivo.Top = btnHorarios.Top;
            if (panelEjecutado.Contains(proximo) == false)
            {
                panelEjecutado.Controls.Add(proximo);
                proximo.Dock = DockStyle.Fill;
                proximo.BringToFront();
            }
            else
            {
                proximo.BringToFront();
            }
        }

        private void panelEjecutado_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (!ad.getAdmin())
            {
                panelActivo.Visible = false;
                if (panelEjecutado.Contains(ad) == false)
                {
                    panelEjecutado.Controls.Add(ad);
                    ad.Dock = DockStyle.Fill;
                    ad.BringToFront();

                }
                else
                {
                    ad.BringToFront();
                }
            }
            else
            {
                btnAdmin.Text = "modo Admin";
                btnAdmin.BackColor = Color.Transparent;
                ad.setAdmin(false);
                accederInicio();
            }
        }

        public void accederInicio()
        {
            if (ad.getAdmin())
            {
                btnAdmin.Text = "salid del admin";
                btnAdmin.BackColor = Color.Red;
            }
            panelActivo.Height = btnInicio.Height;
            panelActivo.Top = btnInicio.Top;
            Principal inicio = new Principal();
            if (panelEjecutado.Contains(inicio) == false)
            {
                panelEjecutado.Controls.Add(inicio);
                inicio.Dock = DockStyle.Fill;
                inicio.BringToFront();
            }
            else
            {
                inicio.BringToFront();
            }

        }
    }
}
