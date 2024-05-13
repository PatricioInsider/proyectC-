namespace WinApp_EjerI4
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
            this.TxtC = new System.Windows.Forms.TextBox();
            this.LblRespuesta = new System.Windows.Forms.Label();
            this.LblArea = new System.Windows.Forms.Label();
            this.TxtA = new System.Windows.Forms.TextBox();
            this.LblAltura = new System.Windows.Forms.Label();
            this.PbxFoto = new System.Windows.Forms.PictureBox();
            this.LblLado = new System.Windows.Forms.Label();
            this.TxtB = new System.Windows.Forms.TextBox();
            this.LblSubtitulo = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtC
            // 
            this.TxtC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxtC.Location = new System.Drawing.Point(146, 222);
            this.TxtC.Margin = new System.Windows.Forms.Padding(2);
            this.TxtC.Name = "TxtC";
            this.TxtC.Size = new System.Drawing.Size(85, 20);
            this.TxtC.TabIndex = 69;
            this.TxtC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtC_KeyPress);
            // 
            // LblRespuesta
            // 
            this.LblRespuesta.AutoSize = true;
            this.LblRespuesta.BackColor = System.Drawing.Color.RosyBrown;
            this.LblRespuesta.Location = new System.Drawing.Point(265, 299);
            this.LblRespuesta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRespuesta.Name = "LblRespuesta";
            this.LblRespuesta.Size = new System.Drawing.Size(0, 13);
            this.LblRespuesta.TabIndex = 68;
            this.LblRespuesta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblArea
            // 
            this.LblArea.AutoSize = true;
            this.LblArea.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblArea.Location = new System.Drawing.Point(60, 299);
            this.LblArea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblArea.Name = "LblArea";
            this.LblArea.Size = new System.Drawing.Size(171, 17);
            this.LblArea.TabIndex = 66;
            this.LblArea.Text = "El área del terreno es:";
            // 
            // TxtA
            // 
            this.TxtA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxtA.Location = new System.Drawing.Point(146, 149);
            this.TxtA.Margin = new System.Windows.Forms.Padding(2);
            this.TxtA.Name = "TxtA";
            this.TxtA.Size = new System.Drawing.Size(85, 20);
            this.TxtA.TabIndex = 65;
            this.TxtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtA_KeyPress);
            // 
            // LblAltura
            // 
            this.LblAltura.AutoSize = true;
            this.LblAltura.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAltura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblAltura.Location = new System.Drawing.Point(65, 148);
            this.LblAltura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblAltura.Name = "LblAltura";
            this.LblAltura.Size = new System.Drawing.Size(24, 17);
            this.LblAltura.TabIndex = 64;
            this.LblAltura.Text = "A:";
            // 
            // PbxFoto
            // 
            this.PbxFoto.Image = ((System.Drawing.Image)(resources.GetObject("PbxFoto.Image")));
            this.PbxFoto.Location = new System.Drawing.Point(322, 135);
            this.PbxFoto.Margin = new System.Windows.Forms.Padding(2);
            this.PbxFoto.Name = "PbxFoto";
            this.PbxFoto.Size = new System.Drawing.Size(281, 149);
            this.PbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxFoto.TabIndex = 63;
            this.PbxFoto.TabStop = false;
            // 
            // LblLado
            // 
            this.LblLado.AutoSize = true;
            this.LblLado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblLado.Location = new System.Drawing.Point(65, 183);
            this.LblLado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblLado.Name = "LblLado";
            this.LblLado.Size = new System.Drawing.Size(24, 17);
            this.LblLado.TabIndex = 62;
            this.LblLado.Text = "B:";
            // 
            // TxtB
            // 
            this.TxtB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxtB.Location = new System.Drawing.Point(146, 183);
            this.TxtB.Margin = new System.Windows.Forms.Padding(2);
            this.TxtB.Name = "TxtB";
            this.TxtB.Size = new System.Drawing.Size(85, 20);
            this.TxtB.TabIndex = 61;
            this.TxtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtB_KeyPress);
            // 
            // LblSubtitulo
            // 
            this.LblSubtitulo.AutoSize = true;
            this.LblSubtitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblSubtitulo.Location = new System.Drawing.Point(55, 89);
            this.LblSubtitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSubtitulo.Name = "LblSubtitulo";
            this.LblSubtitulo.Size = new System.Drawing.Size(172, 18);
            this.LblSubtitulo.TabIndex = 60;
            this.LblSubtitulo.Text = "Ingrese las medidas:";
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.Red;
            this.LblTitulo.Location = new System.Drawing.Point(133, 46);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(317, 18);
            this.LblTitulo.TabIndex = 59;
            this.LblTitulo.Text = "CÁLCULO DEL ÁREA DE UN TERRENO";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.Black;
            this.BtnSalir.Location = new System.Drawing.Point(470, 318);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(113, 31);
            this.BtnSalir.TabIndex = 58;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(65, 220);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 17);
            this.label5.TabIndex = 75;
            this.label5.Text = "C:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(614, 360);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtC);
            this.Controls.Add(this.LblRespuesta);
            this.Controls.Add(this.LblArea);
            this.Controls.Add(this.TxtA);
            this.Controls.Add(this.LblAltura);
            this.Controls.Add(this.PbxFoto);
            this.Controls.Add(this.LblLado);
            this.Controls.Add(this.TxtB);
            this.Controls.Add(this.LblSubtitulo);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.BtnSalir);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PbxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtC;
        private System.Windows.Forms.Label LblRespuesta;
        private System.Windows.Forms.Label LblArea;
        private System.Windows.Forms.TextBox TxtA;
        private System.Windows.Forms.Label LblAltura;
        private System.Windows.Forms.PictureBox PbxFoto;
        private System.Windows.Forms.Label LblLado;
        private System.Windows.Forms.TextBox TxtB;
        private System.Windows.Forms.Label LblSubtitulo;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label5;
    }
}

