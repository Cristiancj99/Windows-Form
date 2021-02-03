
namespace PuntoInformacion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelActivo = new System.Windows.Forms.Panel();
            this.btnSugerencias = new System.Windows.Forms.Button();
            this.btnHorarios = new System.Windows.Forms.Button();
            this.btnEquipoDirectivo = new System.Windows.Forms.Button();
            this.btnPuntosInteres = new System.Windows.Forms.Button();
            this.btnCentro = new System.Windows.Forms.Button();
            this.btnHorarioEscolar = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelEjecutado = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.btnAdmin);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panelActivo);
            this.panel1.Controls.Add(this.btnSugerencias);
            this.panel1.Controls.Add(this.btnHorarios);
            this.panel1.Controls.Add(this.btnEquipoDirectivo);
            this.panel1.Controls.Add(this.btnPuntosInteres);
            this.panel1.Controls.Add(this.btnCentro);
            this.panel1.Controls.Add(this.btnHorarioEscolar);
            this.panel1.Controls.Add(this.btnInicio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 737);
            this.panel1.TabIndex = 0;
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(100, 657);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(165, 80);
            this.btnAdmin.TabIndex = 13;
            this.btnAdmin.Text = "Modo admin";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::PuntoInformacion.Properties.Resources.Help_icon_icons_com_55891;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 663);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 74);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panelActivo
            // 
            this.panelActivo.BackColor = System.Drawing.Color.White;
            this.panelActivo.Location = new System.Drawing.Point(0, 0);
            this.panelActivo.Name = "panelActivo";
            this.panelActivo.Size = new System.Drawing.Size(10, 90);
            this.panelActivo.TabIndex = 2;
            // 
            // btnSugerencias
            // 
            this.btnSugerencias.FlatAppearance.BorderSize = 0;
            this.btnSugerencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSugerencias.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSugerencias.ForeColor = System.Drawing.Color.White;
            this.btnSugerencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSugerencias.Location = new System.Drawing.Point(12, 562);
            this.btnSugerencias.Name = "btnSugerencias";
            this.btnSugerencias.Size = new System.Drawing.Size(256, 80);
            this.btnSugerencias.TabIndex = 7;
            this.btnSugerencias.Text = "Sugerencias";
            this.btnSugerencias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSugerencias.UseVisualStyleBackColor = true;
            this.btnSugerencias.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnHorarios
            // 
            this.btnHorarios.FlatAppearance.BorderSize = 0;
            this.btnHorarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHorarios.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHorarios.ForeColor = System.Drawing.Color.White;
            this.btnHorarios.Location = new System.Drawing.Point(12, 480);
            this.btnHorarios.Name = "btnHorarios";
            this.btnHorarios.Size = new System.Drawing.Size(256, 76);
            this.btnHorarios.TabIndex = 6;
            this.btnHorarios.Text = "Horarios";
            this.btnHorarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHorarios.UseVisualStyleBackColor = true;
            this.btnHorarios.Click += new System.EventHandler(this.btnHorarios_Click);
            // 
            // btnEquipoDirectivo
            // 
            this.btnEquipoDirectivo.FlatAppearance.BorderSize = 0;
            this.btnEquipoDirectivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquipoDirectivo.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipoDirectivo.ForeColor = System.Drawing.Color.White;
            this.btnEquipoDirectivo.Location = new System.Drawing.Point(12, 96);
            this.btnEquipoDirectivo.Name = "btnEquipoDirectivo";
            this.btnEquipoDirectivo.Size = new System.Drawing.Size(256, 90);
            this.btnEquipoDirectivo.TabIndex = 3;
            this.btnEquipoDirectivo.Text = "Equipo Directivo";
            this.btnEquipoDirectivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEquipoDirectivo.UseVisualStyleBackColor = true;
            this.btnEquipoDirectivo.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnPuntosInteres
            // 
            this.btnPuntosInteres.FlatAppearance.BorderSize = 0;
            this.btnPuntosInteres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPuntosInteres.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPuntosInteres.ForeColor = System.Drawing.Color.White;
            this.btnPuntosInteres.Location = new System.Drawing.Point(12, 192);
            this.btnPuntosInteres.Name = "btnPuntosInteres";
            this.btnPuntosInteres.Size = new System.Drawing.Size(259, 90);
            this.btnPuntosInteres.TabIndex = 2;
            this.btnPuntosInteres.Text = "Puntos de interés";
            this.btnPuntosInteres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPuntosInteres.UseVisualStyleBackColor = true;
            this.btnPuntosInteres.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnCentro
            // 
            this.btnCentro.FlatAppearance.BorderSize = 0;
            this.btnCentro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCentro.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCentro.ForeColor = System.Drawing.Color.White;
            this.btnCentro.Location = new System.Drawing.Point(12, 384);
            this.btnCentro.Name = "btnCentro";
            this.btnCentro.Size = new System.Drawing.Size(259, 90);
            this.btnCentro.TabIndex = 4;
            this.btnCentro.Text = "Centro";
            this.btnCentro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCentro.UseVisualStyleBackColor = true;
            this.btnCentro.Click += new System.EventHandler(this.btnCentro_Click);
            // 
            // btnHorarioEscolar
            // 
            this.btnHorarioEscolar.FlatAppearance.BorderSize = 0;
            this.btnHorarioEscolar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHorarioEscolar.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHorarioEscolar.ForeColor = System.Drawing.Color.White;
            this.btnHorarioEscolar.Location = new System.Drawing.Point(12, 288);
            this.btnHorarioEscolar.Name = "btnHorarioEscolar";
            this.btnHorarioEscolar.Size = new System.Drawing.Size(256, 90);
            this.btnHorarioEscolar.TabIndex = 1;
            this.btnHorarioEscolar.Text = "Horario Escolar";
            this.btnHorarioEscolar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHorarioEscolar.UseVisualStyleBackColor = true;
            this.btnHorarioEscolar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Location = new System.Drawing.Point(12, 0);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(256, 90);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // panelEjecutado
            // 
            this.panelEjecutado.Location = new System.Drawing.Point(265, 0);
            this.panelEjecutado.Name = "panelEjecutado";
            this.panelEjecutado.Size = new System.Drawing.Size(1148, 737);
            this.panelEjecutado.TabIndex = 1;
            this.panelEjecutado.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEjecutado_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 737);
            this.Controls.Add(this.panelEjecutado);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSugerencias;
        private System.Windows.Forms.Button btnHorarios;
        private System.Windows.Forms.Button btnEquipoDirectivo;
        private System.Windows.Forms.Button btnPuntosInteres;
        private System.Windows.Forms.Button btnCentro;
        private System.Windows.Forms.Button btnHorarioEscolar;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel panelActivo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelEjecutado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdmin;
    }
}

