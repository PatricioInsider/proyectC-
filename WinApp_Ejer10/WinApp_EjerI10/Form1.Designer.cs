namespace WinApp_EjerI10
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
            this.LblTitulo = new System.Windows.Forms.Label();
            this.Ptb1 = new System.Windows.Forms.PictureBox();
            this.Ptb2 = new System.Windows.Forms.PictureBox();
            this.BtnPiedra = new System.Windows.Forms.Button();
            this.BtnPapel = new System.Windows.Forms.Button();
            this.BtnTijera = new System.Windows.Forms.Button();
            this.BtnJugar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb2)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LblTitulo.Font = new System.Drawing.Font("Sitka Small", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.Red;
            this.LblTitulo.Location = new System.Drawing.Point(143, 9);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(298, 25);
            this.LblTitulo.TabIndex = 91;
            this.LblTitulo.Text = "JUEGO PIEDRA PAPEL O TIJERA";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Ptb1
            // 
            this.Ptb1.Location = new System.Drawing.Point(83, 161);
            this.Ptb1.Margin = new System.Windows.Forms.Padding(2);
            this.Ptb1.Name = "Ptb1";
            this.Ptb1.Size = new System.Drawing.Size(177, 141);
            this.Ptb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ptb1.TabIndex = 92;
            this.Ptb1.TabStop = false;
            // 
            // Ptb2
            // 
            this.Ptb2.Location = new System.Drawing.Point(349, 161);
            this.Ptb2.Margin = new System.Windows.Forms.Padding(2);
            this.Ptb2.Name = "Ptb2";
            this.Ptb2.Size = new System.Drawing.Size(177, 142);
            this.Ptb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ptb2.TabIndex = 93;
            this.Ptb2.TabStop = false;
            // 
            // BtnPiedra
            // 
            this.BtnPiedra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPiedra.Location = new System.Drawing.Point(66, 307);
            this.BtnPiedra.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPiedra.Name = "BtnPiedra";
            this.BtnPiedra.Size = new System.Drawing.Size(71, 32);
            this.BtnPiedra.TabIndex = 94;
            this.BtnPiedra.Text = "Piedra";
            this.BtnPiedra.UseVisualStyleBackColor = true;
            this.BtnPiedra.Click += new System.EventHandler(this.BtnPiedra_Click);
            // 
            // BtnPapel
            // 
            this.BtnPapel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPapel.Location = new System.Drawing.Point(148, 307);
            this.BtnPapel.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPapel.Name = "BtnPapel";
            this.BtnPapel.Size = new System.Drawing.Size(71, 32);
            this.BtnPapel.TabIndex = 95;
            this.BtnPapel.Text = "Papel";
            this.BtnPapel.UseVisualStyleBackColor = true;
            this.BtnPapel.Click += new System.EventHandler(this.BtnPapel_Click);
            // 
            // BtnTijera
            // 
            this.BtnTijera.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTijera.Location = new System.Drawing.Point(233, 307);
            this.BtnTijera.Margin = new System.Windows.Forms.Padding(2);
            this.BtnTijera.Name = "BtnTijera";
            this.BtnTijera.Size = new System.Drawing.Size(71, 32);
            this.BtnTijera.TabIndex = 96;
            this.BtnTijera.Text = "Tijera";
            this.BtnTijera.UseVisualStyleBackColor = true;
            this.BtnTijera.Click += new System.EventHandler(this.BtnTijera_Click);
            // 
            // BtnJugar
            // 
            this.BtnJugar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnJugar.Location = new System.Drawing.Point(418, 307);
            this.BtnJugar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnJugar.Name = "BtnJugar";
            this.BtnJugar.Size = new System.Drawing.Size(71, 32);
            this.BtnJugar.TabIndex = 97;
            this.BtnJugar.Text = "Jugar";
            this.BtnJugar.UseVisualStyleBackColor = true;
            this.BtnJugar.Click += new System.EventHandler(this.BtnJugar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 80);
            this.label1.TabIndex = 98;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 99;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(424, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 15);
            this.label3.TabIndex = 100;
            this.label3.Text = "PC";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(527, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 101;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(614, 376);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnJugar);
            this.Controls.Add(this.BtnTijera);
            this.Controls.Add(this.BtnPapel);
            this.Controls.Add(this.BtnPiedra);
            this.Controls.Add(this.Ptb2);
            this.Controls.Add(this.Ptb1);
            this.Controls.Add(this.LblTitulo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ptb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.PictureBox Ptb1;
        private System.Windows.Forms.PictureBox Ptb2;
        private System.Windows.Forms.Button BtnPiedra;
        private System.Windows.Forms.Button BtnPapel;
        private System.Windows.Forms.Button BtnTijera;
        private System.Windows.Forms.Button BtnJugar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

