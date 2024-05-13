namespace WinApp_Ejer2
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtYA = new System.Windows.Forms.TextBox();
            this.TxtYB = new System.Windows.Forms.TextBox();
            this.LblRespuesta = new System.Windows.Forms.Label();
            this.LblDistancia = new System.Windows.Forms.Label();
            this.TxtXA = new System.Windows.Forms.TextBox();
            this.LblAltura = new System.Windows.Forms.Label();
            this.PbxFoto = new System.Windows.Forms.PictureBox();
            this.LblLado = new System.Windows.Forms.Label();
            this.TxtXB = new System.Windows.Forms.TextBox();
            this.LblSubtitulo = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(521, 232);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 56;
            this.label4.Text = "y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(521, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 55;
            this.label3.Text = "x:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(521, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "x:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(521, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 53;
            this.label5.Text = "y:";
            // 
            // TxtYA
            // 
            this.TxtYA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TxtYA.Location = new System.Drawing.Point(553, 164);
            this.TxtYA.Margin = new System.Windows.Forms.Padding(2);
            this.TxtYA.Name = "TxtYA";
            this.TxtYA.Size = new System.Drawing.Size(76, 20);
            this.TxtYA.TabIndex = 52;
            this.TxtYA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtYA_KeyPress);
            // 
            // TxtYB
            // 
            this.TxtYB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TxtYB.Location = new System.Drawing.Point(553, 232);
            this.TxtYB.Margin = new System.Windows.Forms.Padding(2);
            this.TxtYB.Name = "TxtYB";
            this.TxtYB.Size = new System.Drawing.Size(76, 20);
            this.TxtYB.TabIndex = 51;
            this.TxtYB.TextChanged += new System.EventHandler(this.TxtYB_TextChanged);
            this.TxtYB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtYB_KeyPress);
            // 
            // LblRespuesta
            // 
            this.LblRespuesta.AutoSize = true;
            this.LblRespuesta.BackColor = System.Drawing.Color.MistyRose;
            this.LblRespuesta.Location = new System.Drawing.Point(356, 288);
            this.LblRespuesta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRespuesta.Name = "LblRespuesta";
            this.LblRespuesta.Size = new System.Drawing.Size(0, 13);
            this.LblRespuesta.TabIndex = 50;
            this.LblRespuesta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblDistancia
            // 
            this.LblDistancia.AutoSize = true;
            this.LblDistancia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.LblDistancia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDistancia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblDistancia.Location = new System.Drawing.Point(84, 287);
            this.LblDistancia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDistancia.Name = "LblDistancia";
            this.LblDistancia.Size = new System.Drawing.Size(273, 17);
            this.LblDistancia.TabIndex = 49;
            this.LblDistancia.Text = "La distancia entre los dos puntos es:";
            // 
            // TxtXA
            // 
            this.TxtXA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TxtXA.Location = new System.Drawing.Point(553, 139);
            this.TxtXA.Margin = new System.Windows.Forms.Padding(2);
            this.TxtXA.Name = "TxtXA";
            this.TxtXA.Size = new System.Drawing.Size(76, 20);
            this.TxtXA.TabIndex = 48;
            this.TxtXA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtXA_KeyPress);
            // 
            // LblAltura
            // 
            this.LblAltura.AutoSize = true;
            this.LblAltura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.LblAltura.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAltura.ForeColor = System.Drawing.Color.Black;
            this.LblAltura.Location = new System.Drawing.Point(407, 139);
            this.LblAltura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblAltura.Name = "LblAltura";
            this.LblAltura.Size = new System.Drawing.Size(70, 17);
            this.LblAltura.TabIndex = 47;
            this.LblAltura.Text = "Punto A:";
            // 
            // PbxFoto
            // 
            this.PbxFoto.Image = ((System.Drawing.Image)(resources.GetObject("PbxFoto.Image")));
            this.PbxFoto.Location = new System.Drawing.Point(125, 125);
            this.PbxFoto.Margin = new System.Windows.Forms.Padding(2);
            this.PbxFoto.Name = "PbxFoto";
            this.PbxFoto.Size = new System.Drawing.Size(186, 140);
            this.PbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxFoto.TabIndex = 46;
            this.PbxFoto.TabStop = false;
            // 
            // LblLado
            // 
            this.LblLado.AutoSize = true;
            this.LblLado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.LblLado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblLado.Location = new System.Drawing.Point(406, 206);
            this.LblLado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblLado.Name = "LblLado";
            this.LblLado.Size = new System.Drawing.Size(70, 17);
            this.LblLado.TabIndex = 45;
            this.LblLado.Text = "Punto B:";
            // 
            // TxtXB
            // 
            this.TxtXB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TxtXB.Location = new System.Drawing.Point(553, 207);
            this.TxtXB.Margin = new System.Windows.Forms.Padding(2);
            this.TxtXB.Name = "TxtXB";
            this.TxtXB.Size = new System.Drawing.Size(76, 20);
            this.TxtXB.TabIndex = 44;
            this.TxtXB.TextChanged += new System.EventHandler(this.TxtXB_TextChanged);
            this.TxtXB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtXB_KeyPress);
            // 
            // LblSubtitulo
            // 
            this.LblSubtitulo.AutoSize = true;
            this.LblSubtitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.LblSubtitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblSubtitulo.Location = new System.Drawing.Point(84, 89);
            this.LblSubtitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSubtitulo.Name = "LblSubtitulo";
            this.LblSubtitulo.Size = new System.Drawing.Size(301, 17);
            this.LblSubtitulo.TabIndex = 43;
            this.LblSubtitulo.Text = "Ingrese las coordenadas de cada punto:";
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.Red;
            this.LblTitulo.Location = new System.Drawing.Point(206, 44);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(270, 18);
            this.LblTitulo.TabIndex = 42;
            this.LblTitulo.Text = "Calcular Distancia de dos puntos";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LblTitulo.Click += new System.EventHandler(this.LblTitulo_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.Black;
            this.BtnSalir.Location = new System.Drawing.Point(553, 326);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(104, 35);
            this.BtnSalir.TabIndex = 41;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(11, 348);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 57;
            this.label1.Text = "@7364";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(689, 372);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtYA);
            this.Controls.Add(this.TxtYB);
            this.Controls.Add(this.LblRespuesta);
            this.Controls.Add(this.LblDistancia);
            this.Controls.Add(this.TxtXA);
            this.Controls.Add(this.LblAltura);
            this.Controls.Add(this.PbxFoto);
            this.Controls.Add(this.LblLado);
            this.Controls.Add(this.TxtXB);
            this.Controls.Add(this.LblSubtitulo);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.BtnSalir);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PbxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtYA;
        private System.Windows.Forms.TextBox TxtYB;
        private System.Windows.Forms.Label LblRespuesta;
        private System.Windows.Forms.Label LblDistancia;
        private System.Windows.Forms.TextBox TxtXA;
        private System.Windows.Forms.Label LblAltura;
        private System.Windows.Forms.PictureBox PbxFoto;
        private System.Windows.Forms.Label LblLado;
        private System.Windows.Forms.TextBox TxtXB;
        private System.Windows.Forms.Label LblSubtitulo;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label1;
    }
}

