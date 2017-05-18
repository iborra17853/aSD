namespace NavajaSuiza
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BotonApl1 = new System.Windows.Forms.Button();
            this.BotonApl4 = new System.Windows.Forms.Button();
            this.BotonApl3 = new System.Windows.Forms.Button();
            this.BotonApl2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(238, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BotonApl1
            // 
            this.BotonApl1.Location = new System.Drawing.Point(36, 50);
            this.BotonApl1.Name = "BotonApl1";
            this.BotonApl1.Size = new System.Drawing.Size(122, 69);
            this.BotonApl1.TabIndex = 1;
            this.BotonApl1.Text = "Aplicación 1";
            this.BotonApl1.UseVisualStyleBackColor = true;
            this.BotonApl1.Click += new System.EventHandler(this.BotonAplicacion1);
            // 
            // BotonApl4
            // 
            this.BotonApl4.Location = new System.Drawing.Point(486, 283);
            this.BotonApl4.Name = "BotonApl4";
            this.BotonApl4.Size = new System.Drawing.Size(122, 69);
            this.BotonApl4.TabIndex = 2;
            this.BotonApl4.Text = "Aplicación 4";
            this.BotonApl4.UseVisualStyleBackColor = true;
            this.BotonApl4.Click += new System.EventHandler(this.BotonAplicacion4);
            // 
            // BotonApl3
            // 
            this.BotonApl3.Location = new System.Drawing.Point(36, 283);
            this.BotonApl3.Name = "BotonApl3";
            this.BotonApl3.Size = new System.Drawing.Size(122, 69);
            this.BotonApl3.TabIndex = 3;
            this.BotonApl3.Text = "Aplicación 3";
            this.BotonApl3.UseVisualStyleBackColor = true;
            this.BotonApl3.Click += new System.EventHandler(this.BotonAplicacion3);
            // 
            // BotonApl2
            // 
            this.BotonApl2.Location = new System.Drawing.Point(495, 50);
            this.BotonApl2.Name = "BotonApl2";
            this.BotonApl2.Size = new System.Drawing.Size(122, 69);
            this.BotonApl2.TabIndex = 4;
            this.BotonApl2.Text = "Aplicación 2";
            this.BotonApl2.UseVisualStyleBackColor = true;
            this.BotonApl2.Click += new System.EventHandler(this.BotonAplicacion2);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 375);
            this.Controls.Add(this.BotonApl2);
            this.Controls.Add(this.BotonApl3);
            this.Controls.Add(this.BotonApl4);
            this.Controls.Add(this.BotonApl1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmMain";
            this.Text = "Navaja Suiza";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BotonApl1;
        private System.Windows.Forms.Button BotonApl4;
        private System.Windows.Forms.Button BotonApl3;
        private System.Windows.Forms.Button BotonApl2;
    }
}

