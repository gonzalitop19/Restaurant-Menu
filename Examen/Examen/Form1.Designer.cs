namespace Examen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Papas = new System.Windows.Forms.CheckBox();
            this.Nieve = new System.Windows.Forms.CheckBox();
            this.Fin = new System.Windows.Forms.Button();
            this.nuevopedido = new System.Windows.Forms.Button();
            this.TotalBox1 = new System.Windows.Forms.TextBox();
            this.Soda = new System.Windows.Forms.CheckBox();
            this.TotalBoxx = new System.Windows.Forms.GroupBox();
            this.Salir = new System.Windows.Forms.Button();
            this.doublewestBox1 = new System.Windows.Forms.CheckBox();
            this.FamousBox2 = new System.Windows.Forms.CheckBox();
            this.WesternBox3 = new System.Windows.Forms.CheckBox();
            this.SuperBox4 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.TotalBoxx.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(791, 415);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SaddleBrown;
            this.groupBox1.Controls.Add(this.FamousBox2);
            this.groupBox1.Controls.Add(this.SuperBox4);
            this.groupBox1.Controls.Add(this.doublewestBox1);
            this.groupBox1.Controls.Add(this.WesternBox3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 246);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Combo:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SaddleBrown;
            this.groupBox2.Controls.Add(this.Soda);
            this.groupBox2.Controls.Add(this.Nieve);
            this.groupBox2.Controls.Add(this.Papas);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox2.Location = new System.Drawing.Point(386, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Extras:";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Papas
            // 
            this.Papas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Papas.AutoSize = true;
            this.Papas.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Papas.Location = new System.Drawing.Point(0, 22);
            this.Papas.Name = "Papas";
            this.Papas.Size = new System.Drawing.Size(169, 30);
            this.Papas.TabIndex = 0;
            this.Papas.Text = "Papas Extras";
            this.Papas.UseVisualStyleBackColor = true;
            this.Papas.CheckedChanged += new System.EventHandler(this.Papas_CheckedChanged);
            // 
            // Nieve
            // 
            this.Nieve.AutoSize = true;
            this.Nieve.Location = new System.Drawing.Point(0, 49);
            this.Nieve.Name = "Nieve";
            this.Nieve.Size = new System.Drawing.Size(91, 30);
            this.Nieve.TabIndex = 1;
            this.Nieve.Text = "Nieve";
            this.Nieve.UseVisualStyleBackColor = true;
            this.Nieve.CheckedChanged += new System.EventHandler(this.Nieve_CheckedChanged);
            // 
            // Fin
            // 
            this.Fin.BackColor = System.Drawing.Color.SaddleBrown;
            this.Fin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Fin.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fin.Location = new System.Drawing.Point(532, 214);
            this.Fin.Name = "Fin";
            this.Fin.Size = new System.Drawing.Size(218, 35);
            this.Fin.TabIndex = 0;
            this.Fin.Text = "Finalizar Pedido";
            this.Fin.UseVisualStyleBackColor = false;
            this.Fin.Click += new System.EventHandler(this.Fin_Click);
            // 
            // nuevopedido
            // 
            this.nuevopedido.BackColor = System.Drawing.Color.SaddleBrown;
            this.nuevopedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nuevopedido.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevopedido.Location = new System.Drawing.Point(532, 255);
            this.nuevopedido.Name = "nuevopedido";
            this.nuevopedido.Size = new System.Drawing.Size(113, 34);
            this.nuevopedido.TabIndex = 1;
            this.nuevopedido.Text = "Nuevo Pedido";
            this.nuevopedido.UseVisualStyleBackColor = false;
            this.nuevopedido.Click += new System.EventHandler(this.nuevopedido_Click);
            // 
            // TotalBox1
            // 
            this.TotalBox1.Location = new System.Drawing.Point(6, 70);
            this.TotalBox1.Name = "TotalBox1";
            this.TotalBox1.Size = new System.Drawing.Size(171, 37);
            this.TotalBox1.TabIndex = 2;
            this.TotalBox1.TextChanged += new System.EventHandler(this.TotalBox1_TextChanged);
            // 
            // Soda
            // 
            this.Soda.AutoSize = true;
            this.Soda.Location = new System.Drawing.Point(0, 74);
            this.Soda.Name = "Soda";
            this.Soda.Size = new System.Drawing.Size(146, 30);
            this.Soda.TabIndex = 2;
            this.Soda.Text = "Soda Extra";
            this.Soda.UseVisualStyleBackColor = true;
            this.Soda.CheckedChanged += new System.EventHandler(this.Soda_CheckedChanged);
            // 
            // TotalBoxx
            // 
            this.TotalBoxx.BackColor = System.Drawing.Color.SaddleBrown;
            this.TotalBoxx.Controls.Add(this.TotalBox1);
            this.TotalBoxx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TotalBoxx.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBoxx.Location = new System.Drawing.Point(25, 284);
            this.TotalBoxx.Name = "TotalBoxx";
            this.TotalBoxx.Size = new System.Drawing.Size(210, 127);
            this.TotalBoxx.TabIndex = 5;
            this.TotalBoxx.TabStop = false;
            this.TotalBoxx.Text = "Total:";
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.SaddleBrown;
            this.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Salir.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.Location = new System.Drawing.Point(532, 295);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 31);
            this.Salir.TabIndex = 2;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // doublewestBox1
            // 
            this.doublewestBox1.AutoSize = true;
            this.doublewestBox1.Location = new System.Drawing.Point(0, 82);
            this.doublewestBox1.Name = "doublewestBox1";
            this.doublewestBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.doublewestBox1.Size = new System.Drawing.Size(268, 30);
            this.doublewestBox1.TabIndex = 6;
            this.doublewestBox1.Text = "Double Western Becon";
            this.doublewestBox1.UseVisualStyleBackColor = true;
            this.doublewestBox1.CheckedChanged += new System.EventHandler(this.doublewestBox1_CheckedChanged);
            // 
            // FamousBox2
            // 
            this.FamousBox2.AutoSize = true;
            this.FamousBox2.Location = new System.Drawing.Point(-1, 170);
            this.FamousBox2.Name = "FamousBox2";
            this.FamousBox2.Size = new System.Drawing.Size(164, 30);
            this.FamousBox2.TabIndex = 7;
            this.FamousBox2.Text = "Famous Star";
            this.FamousBox2.UseVisualStyleBackColor = true;
            this.FamousBox2.CheckedChanged += new System.EventHandler(this.FamousBox2_CheckedChanged);
            // 
            // WesternBox3
            // 
            this.WesternBox3.AutoSize = true;
            this.WesternBox3.Location = new System.Drawing.Point(0, 41);
            this.WesternBox3.Name = "WesternBox3";
            this.WesternBox3.Size = new System.Drawing.Size(190, 30);
            this.WesternBox3.TabIndex = 8;
            this.WesternBox3.Text = "Western Becon";
            this.WesternBox3.UseVisualStyleBackColor = true;
            this.WesternBox3.CheckedChanged += new System.EventHandler(this.WesternBox3_CheckedChanged);
            // 
            // SuperBox4
            // 
            this.SuperBox4.AutoSize = true;
            this.SuperBox4.Location = new System.Drawing.Point(-1, 124);
            this.SuperBox4.Name = "SuperBox4";
            this.SuperBox4.Size = new System.Drawing.Size(143, 30);
            this.SuperBox4.TabIndex = 10;
            this.SuperBox4.Text = "Super Star";
            this.SuperBox4.UseVisualStyleBackColor = true;
            this.SuperBox4.CheckedChanged += new System.EventHandler(this.SuperBox4_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.TotalBoxx);
            this.Controls.Add(this.nuevopedido);
            this.Controls.Add(this.Fin);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.TotalBoxx.ResumeLayout(false);
            this.TotalBoxx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox Soda;
        private System.Windows.Forms.CheckBox Nieve;
        private System.Windows.Forms.CheckBox Papas;
        private System.Windows.Forms.TextBox TotalBox1;
        private System.Windows.Forms.Button nuevopedido;
        private System.Windows.Forms.Button Fin;
        private System.Windows.Forms.GroupBox TotalBoxx;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.CheckBox SuperBox4;
        private System.Windows.Forms.CheckBox WesternBox3;
        private System.Windows.Forms.CheckBox doublewestBox1;
        private System.Windows.Forms.CheckBox FamousBox2;
    }
}

