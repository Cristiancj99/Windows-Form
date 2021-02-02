using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace ahorcado
{
    public partial class Form1 : Form
    {
        char[] PalabrasAdividanas;
        int oportunidades;
        char[] PalabraSeleccionada;
        char[] alfabeto;
        string[] Palabras;
        

        public void comenzarJuego()
        {
            listaErrores.Items.Clear();
            flFichasDeJuego.Controls.Clear();
            flFichasDeJuego.Enabled = true;
            pictureAhorcado.Image = null;
            oportunidades = 0;
            Palabras = new string[] { "mouse", "screen", "software", "keyboard" };
            introducirPalabras();
            alfabeto = "ABCDEFGHIJKNMÑOPKRSTUVWXYZ".ToCharArray();

            Random random = new Random();
           obtenerPalabras();

            int numeroPalabraSeleccionada = random.Next(0, Palabras.Length);

            PalabraSeleccionada = Palabras[numeroPalabraSeleccionada].ToUpper().ToCharArray();

            PalabrasAdividanas = PalabraSeleccionada;

            foreach (char letraAlfabeto in alfabeto)
            {
                Button button = new Button();
                button.Tag = "";
                button.Text = letraAlfabeto.ToString();
                button.Width = 40;
                button.Height = 30;
                button.ForeColor = Color.White;
                button.Font = new Font(button.Font.Name, 10, FontStyle.Bold);
                button.BackColor = Color.Black;
                button.Name = letraAlfabeto.ToString();
                button.Click += comparar;
                flFichasDeJuego.Controls.Add(button);

            }

            flPalabra.Controls.Clear();
            for (int indice = 0; indice < PalabraSeleccionada.Length; indice++)
            {
                Button button = new Button();
                button.Tag = PalabraSeleccionada[indice].ToString();
                button.Width = 46;
                button.Height = 80;
                button.ForeColor = Color.Purple;
                button.Text = "-";
                button.Font = new Font(button.Font.Name, 32, FontStyle.Bold);
                button.BackgroundImageLayout = ImageLayout.Center;
                button.BackColor = Color.White;
                button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button.Name = "adivinado" + indice.ToString();

                flPalabra.Controls.Add(button);
            }

        }
        void introducirPalabras()
        {

            TextWriter escritura = new StreamWriter(@"C:\Users\crist\Desktop\palabras.txt");
            for (int i = 0; i < Palabras.Length; i++)
            {
                escritura.WriteLine(Palabras[i]);
            }

            escritura.Close();
        }

        void obtenerPalabras()
        {
            ArrayList palabras = new ArrayList();
            String line;
            TextReader lectura = new StreamReader(@"C:\Users\crist\Desktop\palabras.txt");
            while((line = lectura.ReadLine()) != null)
            {
                palabras.Add(line);
            }
            Palabras = (string[])palabras.ToArray(typeof(string));
            //palabras = lectura.Read();
            lectura.Close();
        }
        void comparar(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            bool encontrado = false;
            boton.BackColor = Color.White;
            boton.ForeColor = Color.Black;
            boton.Enabled = false;

            for (int indice = 0; indice < PalabrasAdividanas.Length; indice++)
            {
                if (PalabrasAdividanas[indice] == char.Parse(boton.Text))
                {
                    Button button = this.Controls.Find("Adivinado" + indice, true).FirstOrDefault() as Button;
                    button.Text = PalabrasAdividanas[indice].ToString();
                    PalabrasAdividanas[indice] = '-';
                    encontrado = true;
                }

            }

            if (!encontrado)
            {
                listaErrores.Items.Add(boton.Text);
                oportunidades = oportunidades + 1;
                boton.Enabled = false;
                pictureAhorcado.Image = (Bitmap)ahorcado_definitivo.Properties.Resources.ResourceManager.GetObject("ahorcado" + oportunidades);

                bool victoria = true;

                for (int i = 0; i <PalabrasAdividanas.Length; i++)
                {
                    if(PalabrasAdividanas[i] != '-')
                    {
                        victoria = false;
                    }
                }

                if (victoria)
                {
                    MessageBox.Show("Has ganado!!!!!!!!!");
                    flFichasDeJuego.Enabled = false;
                }
                if(oportunidades == 6)
                {
                    for(int indice = 0; indice < PalabraSeleccionada.Length; indice++)
                    {
                        Button botton = this.Controls.Find("Adivinado" + indice, true).FirstOrDefault() as Button;
                        botton.Text = botton.Tag.ToString();
                      

                    }
                    MessageBox.Show("Has perdido!!!!!");
                    flFichasDeJuego.Enabled = false;
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
            label2.Visible = false;
            label3.Visible = false;
            texto_contraseña.Visible = false;
            texto_usuario.Visible = false;
            boton_cancelar_sesion.Visible = false;
            boton_iniciar_sesion.Visible = false;
            texto_palabra_introducir.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            boton_insertar.Visible = false;

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            comenzarJuego();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            comenzarJuego();
        }

        private void flPalabra_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = true;
            texto_contraseña.Visible = true;
            texto_usuario.Visible = true;
            boton_cancelar_sesion.Visible = true;
            boton_iniciar_sesion.Visible = true;
        }

        private void boton_iniciar_sesion_Click(object sender, EventArgs e)
        {
            if((texto_usuario.Text=="admin") && (texto_contraseña.Text == "1234"))
            {
                texto_palabra_introducir.Visible = true;
                label4.Visible = true;
                boton_insertar.Visible = true;
                label2.Visible = false;
                label3.Visible = false;
                texto_contraseña.Visible = false;
                texto_usuario.Visible = false;
                boton_cancelar_sesion.Visible = false;
                boton_iniciar_sesion.Visible = false;
                label5.Visible = false;
            }

            else
            {
                label5.Visible = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
           
        }

        private void boton_cancelar_sesion_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            label2.Visible = false;
            label3.Visible = false;
            texto_contraseña.Visible = false;
            texto_usuario.Visible = false;
            boton_cancelar_sesion.Visible = false;
            boton_iniciar_sesion.Visible = false;
            label5.Visible = false;
            boton_insertar.Visible = false;
        }

        private void boton_insertar_Click(object sender, EventArgs e)
        {
            TextWriter escritura = new StreamWriter(@"C:\Users\crist\Desktop\palabras.txt");
            string[] auxiliar = new string[Palabras.Length];
            auxiliar = this.Palabras;
            auxiliar[Palabras.Length-1] = texto_palabra_introducir.Text;
            
            for (int indice = 0; indice < auxiliar.Length; indice++)
            {
                escritura.WriteLine(auxiliar[indice]);
            }


            escritura.Close();
        }
    }
}

