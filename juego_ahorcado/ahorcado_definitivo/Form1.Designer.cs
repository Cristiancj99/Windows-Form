
namespace ahorcado
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.flFichasDeJuego = new System.Windows.Forms.FlowLayoutPanel();
            this.flPalabra = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.listaErrores = new System.Windows.Forms.ListBox();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.pictureAhorcado = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.texto_usuario = new System.Windows.Forms.TextBox();
            this.texto_contraseña = new System.Windows.Forms.TextBox();
            this.boton_iniciar_sesion = new System.Windows.Forms.Button();
            this.boton_cancelar_sesion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.texto_palabra_introducir = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.boton_insertar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAhorcado)).BeginInit();
            this.SuspendLayout();
            // 
            // flFichasDeJuego
            // 
            this.flFichasDeJuego.Location = new System.Drawing.Point(1182, 519);
            this.flFichasDeJuego.Name = "flFichasDeJuego";
            this.flFichasDeJuego.Size = new System.Drawing.Size(544, 211);
            this.flFichasDeJuego.TabIndex = 0;
            // 
            // flPalabra
            // 
            this.flPalabra.Location = new System.Drawing.Point(1062, 779);
            this.flPalabra.Name = "flPalabra";
            this.flPalabra.Size = new System.Drawing.Size(713, 112);
            this.flPalabra.TabIndex = 1;
            this.flPalabra.Paint += new System.Windows.Forms.PaintEventHandler(this.flPalabra_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1190, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "letras erroneas: ";
            // 
            // listaErrores
            // 
            this.listaErrores.FormattingEnabled = true;
            this.listaErrores.ItemHeight = 16;
            this.listaErrores.Location = new System.Drawing.Point(1394, 270);
            this.listaErrores.Name = "listaErrores";
            this.listaErrores.Size = new System.Drawing.Size(233, 148);
            this.listaErrores.TabIndex = 2;
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.Location = new System.Drawing.Point(495, 923);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(153, 35);
            this.btnIniciarPartida.TabIndex = 3;
            this.btnIniciarPartida.Text = "Inciar Partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = true;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // pictureAhorcado
            // 
            this.pictureAhorcado.Image = global::ahorcado_definitivo.Properties.Resources.ahorcado1;
            this.pictureAhorcado.Location = new System.Drawing.Point(29, 270);
            this.pictureAhorcado.Name = "pictureAhorcado";
            this.pictureAhorcado.Size = new System.Drawing.Size(181, 530);
            this.pictureAhorcado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureAhorcado.TabIndex = 0;
            this.pictureAhorcado.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(531, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "insertar palabra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(801, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuario";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(801, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "contraseña";
            // 
            // texto_usuario
            // 
            this.texto_usuario.Location = new System.Drawing.Point(960, 44);
            this.texto_usuario.Name = "texto_usuario";
            this.texto_usuario.Size = new System.Drawing.Size(146, 22);
            this.texto_usuario.TabIndex = 7;
            // 
            // texto_contraseña
            // 
            this.texto_contraseña.Location = new System.Drawing.Point(960, 105);
            this.texto_contraseña.Name = "texto_contraseña";
            this.texto_contraseña.Size = new System.Drawing.Size(146, 22);
            this.texto_contraseña.TabIndex = 8;
            // 
            // boton_iniciar_sesion
            // 
            this.boton_iniciar_sesion.Location = new System.Drawing.Point(987, 177);
            this.boton_iniciar_sesion.Name = "boton_iniciar_sesion";
            this.boton_iniciar_sesion.Size = new System.Drawing.Size(119, 35);
            this.boton_iniciar_sesion.TabIndex = 9;
            this.boton_iniciar_sesion.Text = "Iniciar Sesion";
            this.boton_iniciar_sesion.UseVisualStyleBackColor = true;
            this.boton_iniciar_sesion.Click += new System.EventHandler(this.boton_iniciar_sesion_Click);
            // 
            // boton_cancelar_sesion
            // 
            this.boton_cancelar_sesion.Location = new System.Drawing.Point(804, 177);
            this.boton_cancelar_sesion.Name = "boton_cancelar_sesion";
            this.boton_cancelar_sesion.Size = new System.Drawing.Size(114, 35);
            this.boton_cancelar_sesion.TabIndex = 10;
            this.boton_cancelar_sesion.Text = "cancelar";
            this.boton_cancelar_sesion.UseVisualStyleBackColor = true;
            this.boton_cancelar_sesion.Click += new System.EventHandler(this.boton_cancelar_sesion_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(935, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Palabra a introducir:";
            // 
            // texto_palabra_introducir
            // 
            this.texto_palabra_introducir.Location = new System.Drawing.Point(1098, 70);
            this.texto_palabra_introducir.Name = "texto_palabra_introducir";
            this.texto_palabra_introducir.Size = new System.Drawing.Size(132, 22);
            this.texto_palabra_introducir.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(847, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Usuario o contrasrña incorrectos";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // boton_insertar
            // 
            this.boton_insertar.Location = new System.Drawing.Point(1282, 69);
            this.boton_insertar.Name = "boton_insertar";
            this.boton_insertar.Size = new System.Drawing.Size(143, 43);
            this.boton_insertar.TabIndex = 14;
            this.boton_insertar.Text = "insertar";
            this.boton_insertar.UseVisualStyleBackColor = true;
            this.boton_insertar.Click += new System.EventHandler(this.boton_insertar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1885, 1042);
            this.Controls.Add(this.boton_insertar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.texto_palabra_introducir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boton_cancelar_sesion);
            this.Controls.Add(this.boton_iniciar_sesion);
            this.Controls.Add(this.texto_contraseña);
            this.Controls.Add(this.texto_usuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.listaErrores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureAhorcado);
            this.Controls.Add(this.flPalabra);
            this.Controls.Add(this.flFichasDeJuego);
            this.Name = "Form1";
            this.Text = "ahorcado";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureAhorcado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flFichasDeJuego;
        private System.Windows.Forms.FlowLayoutPanel flPalabra;
        private System.Windows.Forms.PictureBox pictureAhorcado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listaErrores;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox texto_usuario;
        private System.Windows.Forms.TextBox texto_contraseña;
        private System.Windows.Forms.Button boton_iniciar_sesion;
        private System.Windows.Forms.Button boton_cancelar_sesion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox texto_palabra_introducir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button boton_insertar;
    }
}

