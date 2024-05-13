namespace WinApp_EjerI9
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
            System.Windows.Forms.Label LblAltura;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LblRespuesta = new System.Windows.Forms.Label();
            this.LblArea = new System.Windows.Forms.Label();
            this.TxtH = new System.Windows.Forms.TextBox();
            this.LblSubtitulo = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            LblAltura = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblRespuesta
            // 
            this.LblRespuesta.AutoSize = true;
            this.LblRespuesta.BackColor = System.Drawing.Color.MistyRose;
            this.LblRespuesta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRespuesta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblRespuesta.Location = new System.Drawing.Point(354, 327);
            this.LblRespuesta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRespuesta.Name = "LblRespuesta";
            this.LblRespuesta.Size = new System.Drawing.Size(0, 17);
            this.LblRespuesta.TabIndex = 98;
            this.LblRespuesta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblArea
            // 
            this.LblArea.AutoSize = true;
            this.LblArea.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblArea.Location = new System.Drawing.Point(97, 327);
            this.LblArea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblArea.Name = "LblArea";
            this.LblArea.Size = new System.Drawing.Size(243, 17);
            this.LblArea.TabIndex = 97;
            this.LblArea.Text = "La hora al siguiente segundo es:";
            // 
            // TxtH
            // 
            this.TxtH.Location = new System.Drawing.Point(240, 113);
            this.TxtH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtH.Name = "TxtH";
            this.TxtH.Size = new System.Drawing.Size(130, 20);
            this.TxtH.TabIndex = 96;
            this.TxtH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtH_KeyPress);
            // 
            // LblAltura
            // 
            LblAltura.AutoSize = true;
            LblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LblAltura.ForeColor = System.Drawing.Color.Black;
            LblAltura.Location = new System.Drawing.Point(175, 112);
            LblAltura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            LblAltura.Name = "LblAltura";
            LblAltura.Size = new System.Drawing.Size(50, 18);
            LblAltura.TabIndex = 95;
            LblAltura.Text = "Hora:";
            // 
            // LblSubtitulo
            // 
            this.LblSubtitulo.AutoSize = true;
            this.LblSubtitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubtitulo.ForeColor = System.Drawing.Color.Black;
            this.LblSubtitulo.Location = new System.Drawing.Point(88, 75);
            this.LblSubtitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSubtitulo.Name = "LblSubtitulo";
            this.LblSubtitulo.Size = new System.Drawing.Size(430, 17);
            this.LblSubtitulo.TabIndex = 91;
            this.LblSubtitulo.Text = "Ingrese los datos en el siguiente formatos:  (hora:min:seg)";
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.Red;
            this.LblTitulo.Location = new System.Drawing.Point(140, 37);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(345, 22);
            this.LblTitulo.TabIndex = 90;
            this.LblTitulo.Text = "Calcular la hora al siguiente segundo";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.LightCoral;
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.Black;
            this.BtnSalir.Location = new System.Drawing.Point(501, 345);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(85, 31);
            this.BtnSalir.TabIndex = 89;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(200, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 99;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(597, 387);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblRespuesta);
            this.Controls.Add(this.LblArea);
            this.Controls.Add(this.TxtH);
            this.Controls.Add(LblAltura);
            this.Controls.Add(this.LblSubtitulo);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.BtnSalir);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblRespuesta;
        private System.Windows.Forms.Label LblArea;
        private System.Windows.Forms.TextBox TxtH;
        private System.Windows.Forms.Label LblSubtitulo;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

