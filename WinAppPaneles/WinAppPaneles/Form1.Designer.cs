namespace WinAppPaneles
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
            this.Pnl1 = new System.Windows.Forms.Panel();
            this.Pnl2 = new System.Windows.Forms.Panel();
            this.Pnl3 = new System.Windows.Forms.Panel();
            this.PbxImage = new System.Windows.Forms.PictureBox();
            this.Pnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl1
            // 
            this.Pnl1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Pnl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl1.Location = new System.Drawing.Point(0, 0);
            this.Pnl1.Name = "Pnl1";
            this.Pnl1.Size = new System.Drawing.Size(800, 100);
            this.Pnl1.TabIndex = 0;
            // 
            // Pnl2
            // 
            this.Pnl2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Pnl2.Controls.Add(this.PbxImage);
            this.Pnl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pnl2.Location = new System.Drawing.Point(0, 100);
            this.Pnl2.Name = "Pnl2";
            this.Pnl2.Size = new System.Drawing.Size(200, 350);
            this.Pnl2.TabIndex = 1;
            // 
            // Pnl3
            // 
            this.Pnl3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Pnl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl3.Location = new System.Drawing.Point(200, 100);
            this.Pnl3.Name = "Pnl3";
            this.Pnl3.Size = new System.Drawing.Size(600, 350);
            this.Pnl3.TabIndex = 2;
            // 
            // PbxImage
            // 
            this.PbxImage.Image = ((System.Drawing.Image)(resources.GetObject("PbxImage.Image")));
            this.PbxImage.Location = new System.Drawing.Point(59, 48);
            this.PbxImage.Name = "PbxImage";
            this.PbxImage.Size = new System.Drawing.Size(92, 115);
            this.PbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxImage.TabIndex = 0;
            this.PbxImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pnl3);
            this.Controls.Add(this.Pnl2);
            this.Controls.Add(this.Pnl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Pnl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl1;
        private System.Windows.Forms.Panel Pnl2;
        private System.Windows.Forms.Panel Pnl3;
        private System.Windows.Forms.PictureBox PbxImage;
    }
}

