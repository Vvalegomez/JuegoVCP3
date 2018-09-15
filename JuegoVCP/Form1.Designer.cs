namespace JuegoVCP
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
            this.auto1 = new System.Windows.Forms.PictureBox();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pBox1 = new System.Windows.Forms.PictureBox();
            this.pBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.auto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // auto1
            // 
            this.auto1.BackColor = System.Drawing.Color.Transparent;
            this.auto1.Image = global::JuegoVCP.Properties.Resources.autito1;
            this.auto1.Location = new System.Drawing.Point(12, 348);
            this.auto1.Name = "auto1";
            this.auto1.Size = new System.Drawing.Size(46, 60);
            this.auto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.auto1.TabIndex = 0;
            this.auto1.TabStop = false;
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblPuntos.Location = new System.Drawing.Point(51, 9);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(24, 25);
            this.lblPuntos.TabIndex = 1;
            this.lblPuntos.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pBox1
            // 
            this.pBox1.BackColor = System.Drawing.Color.Transparent;
            this.pBox1.Image = global::JuegoVCP.Properties.Resources.cuadra;
            this.pBox1.Location = new System.Drawing.Point(12, 13);
            this.pBox1.Name = "pBox1";
            this.pBox1.Size = new System.Drawing.Size(35, 39);
            this.pBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox1.TabIndex = 2;
            this.pBox1.TabStop = false;
            // 
            // pBox2
            // 
            this.pBox2.BackColor = System.Drawing.Color.Transparent;
            this.pBox2.Image = global::JuegoVCP.Properties.Resources.punto;
            this.pBox2.Location = new System.Drawing.Point(81, 12);
            this.pBox2.Name = "pBox2";
            this.pBox2.Size = new System.Drawing.Size(41, 40);
            this.pBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox2.TabIndex = 3;
            this.pBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JuegoVCP.Properties.Resources.carretera1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(134, 420);
            this.Controls.Add(this.pBox2);
            this.Controls.Add(this.pBox1);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.auto1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.auto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox auto1;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pBox1;
        private System.Windows.Forms.PictureBox pBox2;
    }
}

