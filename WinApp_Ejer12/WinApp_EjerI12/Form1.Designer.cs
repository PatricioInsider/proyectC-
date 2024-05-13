namespace WinApp_EjerI12
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
            this.LblRes = new System.Windows.Forms.Label();
            this.LblArea = new System.Windows.Forms.Label();
            this.TxtDv = new System.Windows.Forms.TextBox();
            this.LblAltura = new System.Windows.Forms.Label();
            this.PbxFoto = new System.Windows.Forms.PictureBox();
            this.LblSubtitulo = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.TxtDsr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblCoc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // LblRes
            // 
            this.LblRes.AutoSize = true;
            this.LblRes.BackColor = System.Drawing.Color.MistyRose;
            this.LblRes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRes.ForeColor = System.Drawing.Color.Black;
            this.LblRes.Location = new System.Drawing.Point(519, 301);
            this.LblRes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRes.Name = "LblRes";
            this.LblRes.Size = new System.Drawing.Size(0, 17);
            this.LblRes.TabIndex = 106;
            this.LblRes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblArea
            // 
            this.LblArea.AutoSize = true;
            this.LblArea.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblArea.ForeColor = System.Drawing.Color.Black;
            this.LblArea.Location = new System.Drawing.Point(319, 260);
            this.LblArea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblArea.Name = "LblArea";
            this.LblArea.Size = new System.Drawing.Size(209, 17);
            this.LblArea.TabIndex = 105;
            this.LblArea.Text = "El cociente de la divisón es:";
            // 
            // TxtDv
            // 
            this.TxtDv.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDv.Location = new System.Drawing.Point(480, 149);
            this.TxtDv.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDv.Name = "TxtDv";
            this.TxtDv.Size = new System.Drawing.Size(85, 25);
            this.TxtDv.TabIndex = 104;
            this.TxtDv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDv_KeyPress);
            // 
            // LblAltura
            // 
            this.LblAltura.AutoSize = true;
            this.LblAltura.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAltura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblAltura.Location = new System.Drawing.Point(374, 157);
            this.LblAltura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblAltura.Name = "LblAltura";
            this.LblAltura.Size = new System.Drawing.Size(85, 17);
            this.LblAltura.TabIndex = 103;
            this.LblAltura.Text = "Dividendo:";
            // 
            // PbxFoto
            // 
            this.PbxFoto.Image = ((System.Drawing.Image)(resources.GetObject("PbxFoto.Image")));
            this.PbxFoto.Location = new System.Drawing.Point(33, 128);
            this.PbxFoto.Margin = new System.Windows.Forms.Padding(2);
            this.PbxFoto.Name = "PbxFoto";
            this.PbxFoto.Size = new System.Drawing.Size(256, 189);
            this.PbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxFoto.TabIndex = 102;
            this.PbxFoto.TabStop = false;
            // 
            // LblSubtitulo
            // 
            this.LblSubtitulo.AutoSize = true;
            this.LblSubtitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubtitulo.ForeColor = System.Drawing.Color.Black;
            this.LblSubtitulo.Location = new System.Drawing.Point(95, 92);
            this.LblSubtitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSubtitulo.Name = "LblSubtitulo";
            this.LblSubtitulo.Size = new System.Drawing.Size(433, 17);
            this.LblSubtitulo.TabIndex = 101;
            this.LblSubtitulo.Text = "Calcular el resto y cociente por medio de restas sucesivas";
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LblTitulo.Font = new System.Drawing.Font("Sitka Small", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.Red;
            this.LblTitulo.Location = new System.Drawing.Point(163, 41);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(268, 28);
            this.LblTitulo.TabIndex = 100;
            this.LblTitulo.Text = "Calcular Resto y Cociente";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.LightCoral;
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.Black;
            this.BtnSalir.Location = new System.Drawing.Point(511, 336);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(94, 31);
            this.BtnSalir.TabIndex = 99;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // TxtDsr
            // 
            this.TxtDsr.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDsr.Location = new System.Drawing.Point(480, 185);
            this.TxtDsr.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDsr.Name = "TxtDsr";
            this.TxtDsr.Size = new System.Drawing.Size(85, 25);
            this.TxtDsr.TabIndex = 108;
            this.TxtDsr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDsr_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(374, 194);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 107;
            this.label1.Text = "Divisor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(322, 300);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 17);
            this.label2.TabIndex = 109;
            this.label2.Text = "El resto de la divisón es:";
            // 
            // LblCoc
            // 
            this.LblCoc.AutoSize = true;
            this.LblCoc.BackColor = System.Drawing.Color.MistyRose;
            this.LblCoc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCoc.ForeColor = System.Drawing.Color.Black;
            this.LblCoc.Location = new System.Drawing.Point(511, 263);
            this.LblCoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCoc.Name = "LblCoc";
            this.LblCoc.Size = new System.Drawing.Size(0, 17);
            this.LblCoc.TabIndex = 110;
            this.LblCoc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(616, 378);
            this.Controls.Add(this.LblCoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtDsr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblRes);
            this.Controls.Add(this.LblArea);
            this.Controls.Add(this.TxtDv);
            this.Controls.Add(this.LblAltura);
            this.Controls.Add(this.PbxFoto);
            this.Controls.Add(this.LblSubtitulo);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.BtnSalir);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblRes;
        private System.Windows.Forms.Label LblArea;
        private System.Windows.Forms.TextBox TxtDv;
        private System.Windows.Forms.Label LblAltura;
        private System.Windows.Forms.PictureBox PbxFoto;
        private System.Windows.Forms.Label LblSubtitulo;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.TextBox TxtDsr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblCoc;
    }
}

