namespace NavajaSuiza.Aplicación_4
{
    partial class FrmAplicacion4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ResultadoApl3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResultadoApl3
            // 
            this.ResultadoApl3.Location = new System.Drawing.Point(132, 96);
            this.ResultadoApl3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ResultadoApl3.Name = "ResultadoApl3";
            this.ResultadoApl3.Size = new System.Drawing.Size(101, 64);
            this.ResultadoApl3.TabIndex = 0;
            this.ResultadoApl3.Text = "Serie y suma de múltiplos de 3";
            this.ResultadoApl3.UseVisualStyleBackColor = true;
            this.ResultadoApl3.Click += new System.EventHandler(this.RealizarApl3);
            // 
            // FrmAplicacion4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 253);
            this.Controls.Add(this.ResultadoApl3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmAplicacion4";
            this.Text = "Ejercicio 26";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ResultadoApl3;
    }
}

