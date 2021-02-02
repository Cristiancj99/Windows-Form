namespace EjercicioAccesibilidad
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.smallPizza = new System.Windows.Forms.RadioButton();
            this.LarguePizza = new System.Windows.Forms.RadioButton();
            this.toppings = new System.Windows.Forms.CheckedListBox();
            this.cancel = new System.Windows.Forms.Button();
            this.order = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toppingsLabel = new System.Windows.Forms.Label();
            this.sizeOptions = new System.Windows.Forms.GroupBox();
            this.coustomerName = new System.Windows.Forms.TextBox();
            this.coustomerLabel = new System.Windows.Forms.Label();
            this.companyLabel = new System.Windows.Forms.Label();
            this.theMainMenu = new System.Windows.Forms.MenuStrip();
            this.fileCommands = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sizeOptions.SuspendLayout();
            this.theMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // smallPizza
            // 
            this.smallPizza.AccessibleDescription = "Small pizza";
            this.smallPizza.AccessibleName = "Small pizza";
            this.smallPizza.AutoSize = true;
            this.smallPizza.Checked = true;
            this.smallPizza.Location = new System.Drawing.Point(9, 41);
            this.smallPizza.Margin = new System.Windows.Forms.Padding(4);
            this.smallPizza.Name = "smallPizza";
            this.smallPizza.Size = new System.Drawing.Size(140, 24);
            this.smallPizza.TabIndex = 0;
            this.smallPizza.TabStop = true;
            this.smallPizza.Text = "&Pequeña 6.00€";
            this.smallPizza.UseVisualStyleBackColor = true;
            // 
            // LarguePizza
            // 
            this.LarguePizza.AccessibleDescription = "Largue pizza";
            this.LarguePizza.AccessibleName = "Largue pizza";
            this.LarguePizza.AutoSize = true;
            this.LarguePizza.Location = new System.Drawing.Point(8, 75);
            this.LarguePizza.Margin = new System.Windows.Forms.Padding(4);
            this.LarguePizza.Name = "LarguePizza";
            this.LarguePizza.Size = new System.Drawing.Size(139, 24);
            this.LarguePizza.TabIndex = 5;
            this.LarguePizza.Text = "&Grande 10.00€";
            this.LarguePizza.UseVisualStyleBackColor = true;
            // 
            // toppings
            // 
            this.toppings.AccessibleDescription = "Avaliable toppings";
            this.toppings.AccessibleName = "Avaliable toppings";
            this.toppings.FormattingEnabled = true;
            this.toppings.Items.AddRange(new object[] {
            "Pepperoni",
            "Salchicha",
            "Champiñones"});
            this.toppings.Location = new System.Drawing.Point(559, 237);
            this.toppings.Margin = new System.Windows.Forms.Padding(4);
            this.toppings.Name = "toppings";
            this.toppings.Size = new System.Drawing.Size(150, 109);
            this.toppings.TabIndex = 6;
            // 
            // cancel
            // 
            this.cancel.AccessibleDescription = "cancel the order";
            this.cancel.AccessibleName = "Cancel order";
            this.cancel.Location = new System.Drawing.Point(578, 394);
            this.cancel.Margin = new System.Windows.Forms.Padding(4);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(94, 29);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "&Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // order
            // 
            this.order.AccessibleDescription = "Cancel the order";
            this.order.AccessibleName = "Total Order";
            this.order.Location = new System.Drawing.Point(226, 394);
            this.order.Margin = new System.Windows.Forms.Padding(4);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(94, 29);
            this.order.TabIndex = 7;
            this.order.Text = "&Pedir";
            this.order.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleDescription = "A slice of pizza";
            this.pictureBox1.AccessibleName = "Company logo";
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(184, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 121);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // toppingsLabel
            // 
            this.toppingsLabel.AccessibleDescription = "Toppings label";
            this.toppingsLabel.AccessibleName = "Toppings label";
            this.toppingsLabel.AutoSize = true;
            this.toppingsLabel.Location = new System.Drawing.Point(502, 209);
            this.toppingsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.toppingsLabel.Name = "toppingsLabel";
            this.toppingsLabel.Size = new System.Drawing.Size(230, 20);
            this.toppingsLabel.TabIndex = 5;
            this.toppingsLabel.Text = "Ingredientes (0,75€ cada uno)";
            // 
            // sizeOptions
            // 
            this.sizeOptions.AccessibleDescription = "Pizza Size Options";
            this.sizeOptions.AccessibleName = "Pizza Size Options";
            this.sizeOptions.Controls.Add(this.smallPizza);
            this.sizeOptions.Controls.Add(this.LarguePizza);
            this.sizeOptions.Location = new System.Drawing.Point(165, 221);
            this.sizeOptions.Margin = new System.Windows.Forms.Padding(4);
            this.sizeOptions.Name = "sizeOptions";
            this.sizeOptions.Padding = new System.Windows.Forms.Padding(4);
            this.sizeOptions.Size = new System.Drawing.Size(250, 125);
            this.sizeOptions.TabIndex = 3;
            this.sizeOptions.TabStop = false;
            this.sizeOptions.Text = "Tamaño de pizza";
            this.sizeOptions.Enter += new System.EventHandler(this.sizeOptions_Enter);
            // 
            // coustomerName
            // 
            this.coustomerName.AccessibleDescription = "Coustomer name";
            this.coustomerName.AccessibleName = "Coustomer name";
            this.coustomerName.Location = new System.Drawing.Point(486, 164);
            this.coustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.coustomerName.Name = "coustomerName";
            this.coustomerName.Size = new System.Drawing.Size(200, 26);
            this.coustomerName.TabIndex = 9;
            // 
            // coustomerLabel
            // 
            this.coustomerLabel.AccessibleDescription = "Coustomer label name";
            this.coustomerLabel.AccessibleName = "Coustomer label name";
            this.coustomerLabel.AutoSize = true;
            this.coustomerLabel.Location = new System.Drawing.Point(402, 164);
            this.coustomerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.coustomerLabel.Name = "coustomerLabel";
            this.coustomerLabel.Size = new System.Drawing.Size(68, 20);
            this.coustomerLabel.TabIndex = 2;
            this.coustomerLabel.Text = "&Nombre";
            // 
            // companyLabel
            // 
            this.companyLabel.AccessibleDescription = "Company name";
            this.companyLabel.AccessibleName = "Company name";
            this.companyLabel.AutoSize = true;
            this.companyLabel.BackColor = System.Drawing.Color.Blue;
            this.companyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.companyLabel.ForeColor = System.Drawing.Color.Yellow;
            this.companyLabel.Location = new System.Drawing.Point(360, 88);
            this.companyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(170, 36);
            this.companyLabel.TabIndex = 1;
            this.companyLabel.Text = "Good Pizza";
            // 
            // theMainMenu
            // 
            this.theMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.theMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileCommands});
            this.theMainMenu.Location = new System.Drawing.Point(0, 0);
            this.theMainMenu.Name = "theMainMenu";
            this.theMainMenu.Size = new System.Drawing.Size(868, 30);
            this.theMainMenu.TabIndex = 10;
            this.theMainMenu.Text = "menuStrip1";
            // 
            // fileCommands
            // 
            this.fileCommands.Name = "fileCommands";
            this.fileCommands.Size = new System.Drawing.Size(46, 24);
            this.fileCommands.Text = "&File";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AccessibleDescription = "Order form";
            this.AccessibleName = "Order form";
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 454);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.coustomerLabel);
            this.Controls.Add(this.coustomerName);
            this.Controls.Add(this.sizeOptions);
            this.Controls.Add(this.toppingsLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.order);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.toppings);
            this.Controls.Add(this.theMainMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.theMainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Pizza order form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sizeOptions.ResumeLayout(false);
            this.sizeOptions.PerformLayout();
            this.theMainMenu.ResumeLayout(false);
            this.theMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton smallPizza;
        private System.Windows.Forms.RadioButton LarguePizza;
        private System.Windows.Forms.CheckedListBox toppings;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button order;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label toppingsLabel;
        private System.Windows.Forms.GroupBox sizeOptions;
        private System.Windows.Forms.TextBox coustomerName;
        private System.Windows.Forms.Label coustomerLabel;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.MenuStrip theMainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileCommands;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

