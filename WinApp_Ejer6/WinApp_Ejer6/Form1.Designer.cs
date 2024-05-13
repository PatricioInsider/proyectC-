namespace WinApp_Ejer6
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
            this.label5 = new System.Windows.Forms.Label();
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
            this.LblRes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(341, 217);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 87;
            this.label5.Text = "Medida C:";
            // 
            // TxtC
            // 
            this.TxtC.Location = new System.Drawing.Point(436, 218);
            this.TxtC.Margin = new System.Windows.Forms.Padding(2);
            this.TxtC.Name = "TxtC";
            this.TxtC.Size = new System.Drawing.Size(85, 20);
            this.TxtC.TabIndex = 86;
            this.TxtC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtC_KeyPress_1);
            // 
            // LblRespuesta
            // 
            this.LblRespuesta.AutoSize = true;
            this.LblRespuesta.BackColor = System.Drawing.Color.MistyRose;
            this.LblRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRespuesta.Location = new System.Drawing.Point(347, 309);
            this.LblRespuesta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRespuesta.Name = "LblRespuesta";
            this.LblRespuesta.Size = new System.Drawing.Size(0, 17);
            this.LblRespuesta.TabIndex = 85;
            this.LblRespuesta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblArea
            // 
            this.LblArea.AutoSize = true;
            this.LblArea.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblArea.Location = new System.Drawing.Point(218, 309);
            this.LblArea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblArea.Name = "LblArea";
            this.LblArea.Size = new System.Drawing.Size(116, 17);
            this.LblArea.TabIndex = 84;
            this.LblArea.Text = "es un triángulo";
            // 
            // TxtA
            // 
            this.TxtA.Location = new System.Drawing.Point(436, 145);
            this.TxtA.Margin = new System.Windows.Forms.Padding(2);
            this.TxtA.Name = "TxtA";
            this.TxtA.Size = new System.Drawing.Size(85, 20);
            this.TxtA.TabIndex = 83;
            this.TxtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtA_KeyPress);
            // 
            // LblAltura
            // 
            this.LblAltura.AutoSize = true;
            this.LblAltura.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAltura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblAltura.Location = new System.Drawing.Point(341, 144);
            this.LblAltura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblAltura.Name = "LblAltura";
            this.LblAltura.Size = new System.Drawing.Size(80, 17);
            this.LblAltura.TabIndex = 82;
            this.LblAltura.Text = "Medida A:";
            // 
            // PbxFoto
            // 
            this.PbxFoto.Image = ((System.Drawing.Image)(resources.GetObject("PbxFoto.Image")));
            this.PbxFoto.Location = new System.Drawing.Point(61, 122);
            this.PbxFoto.Margin = new System.Windows.Forms.Padding(2);
            this.PbxFoto.Name = "PbxFoto";
            this.PbxFoto.Size = new System.Drawing.Size(213, 163);
            this.PbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxFoto.TabIndex = 81;
            this.PbxFoto.TabStop = false;
            // 
            // LblLado
            // 
            this.LblLado.AutoSize = true;
            this.LblLado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblLado.Location = new System.Drawing.Point(341, 179);
            this.LblLado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblLado.Name = "LblLado";
            this.LblLado.Size = new System.Drawing.Size(80, 17);
            this.LblLado.TabIndex = 80;
            this.LblLado.Text = "Medida B:";
            // 
            // TxtB
            // 
            this.TxtB.Location = new System.Drawing.Point(436, 179);
            this.TxtB.Margin = new System.Windows.Forms.Padding(2);
            this.TxtB.Name = "TxtB";
            this.TxtB.Size = new System.Drawing.Size(85, 20);
            this.TxtB.TabIndex = 79;
            this.TxtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtB_KeyPress_1);
            // 
            // LblSubtitulo
            // 
            this.LblSubtitulo.AutoSize = true;
            this.LblSubtitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblSubtitulo.Location = new System.Drawing.Point(28, 85);
            this.LblSubtitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSubtitulo.Name = "LblSubtitulo";
            this.LblSubtitulo.Size = new System.Drawing.Size(159, 17);
            this.LblSubtitulo.TabIndex = 78;
            this.LblSubtitulo.Text = "Ingrese las medidas:";
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LblTitulo.Font = new System.Drawing.Font("Sitka Small", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.Red;
            this.LblTitulo.Location = new System.Drawing.Point(154, 6);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(225, 28);
            this.LblTitulo.TabIndex = 77;
            this.LblTitulo.Text = "TIPO DE TRIÁNGULO";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.LightCoral;
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.Black;
            this.BtnSalir.Location = new System.Drawing.Point(500, 333);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(113, 31);
            this.BtnSalir.TabIndex = 76;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click_1);
            // 
            // LblRes
            // 
            this.LblRes.AutoSize = true;
            this.LblRes.BackColor = System.Drawing.Color.MistyRose;
            this.LblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRes.Location = new System.Drawing.Point(185, 309);
            this.LblRes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRes.Name = "LblRes";
            this.LblRes.Size = new System.Drawing.Size(0, 17);
            this.LblRes.TabIndex = 88;
            this.LblRes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(624, 375);
            this.Controls.Add(this.LblRes);
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

        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.Label LblRes;
    }
}

