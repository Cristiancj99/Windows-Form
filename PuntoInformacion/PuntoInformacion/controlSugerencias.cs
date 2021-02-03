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
    public partial class controlSugerencias : UserControl
    {
        public controlSugerencias()
        {
            InitializeComponent();
            label2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {



 
        
        }

        private void controlSugerencias_Load(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void enviarMensaje(object sender, EventArgs e)
        {
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
            msg.To.Add("sugerencias@cescristorey.com");
            msg.Subject = txtAsunto.Text;
            msg.SubjectEncoding = System.Text.Encoding.UTF8; // cpdificacion para evitar problemas a la hora de enviarlo
            msg.Body = txtMessage.Text;
            msg.BodyEncoding = System.Text.Encoding.UTF8; // cpdificacion para evitar problemas a la hora de enviarlo
            msg.IsBodyHtml = true;
            msg.From = new System.Net.Mail.MailAddress("sugerenciascescristorey@gmail.com");

            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();

            cliente.Credentials = new System.Net.NetworkCredential("sugerenciascescristorey@gmail.com", "josegras");

            cliente.Port = 587;

            cliente.EnableSsl = true;
            cliente.Host = "smtp.gmail.com";

            try
            {
                cliente.Send(msg);
                MessageBox.Show("mensaje enviado");
            }

            catch (Exception)
            {
                MessageBox.Show("ERROR");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((txtMessage.Text != "") && (txtAsunto.Text != ""))
            {


                System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
                msg.To.Add("sugerencias@cescristorey.com");
                msg.Subject = txtAsunto.Text;
                msg.SubjectEncoding = System.Text.Encoding.UTF8; // cpdificacion para evitar problemas a la hora de enviarlo
                msg.Body = txtMessage.Text;
                msg.BodyEncoding = System.Text.Encoding.UTF8; // cpdificacion para evitar problemas a la hora de enviarlo
                msg.IsBodyHtml = true;
                msg.From = new System.Net.Mail.MailAddress("sugerenciascescristorey@gmail.com");

                System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();

                cliente.Credentials = new System.Net.NetworkCredential("sugerenciascescristorey@gmail.com", "josegras");

                cliente.Port = 587;

                cliente.EnableSsl = true;
                cliente.Host = "smtp.gmail.com";

                try
                {
                    cliente.Send(msg);
                    MessageBox.Show("mensaje enviado");
                }


                catch (Exception)
                {
                    MessageBox.Show("ERROR");
                }
            }
            else
            {
                label2.Visible = true;
                label2.Text = "Faltan campos por rellenar";
            }
        }
    }


    
    
}
