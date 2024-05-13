namespace WinAppIA
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
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.label1 = new System.Windows.Forms.Label();
            this.TbxTextoFinal = new System.Windows.Forms.TextBox();
            this.PbxArchivo = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BfnCheck = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuAbrirArchivo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbxArchivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(193, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Reconocimiento de Texto en Imagenes";
            // 
            // TbxTextoFinal
            // 
            this.TbxTextoFinal.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxTextoFinal.Location = new System.Drawing.Point(506, 191);
            this.TbxTextoFinal.Multiline = true;
            this.TbxTextoFinal.Name = "TbxTextoFinal";
            this.TbxTextoFinal.Size = new System.Drawing.Size(220, 211);
            this.TbxTextoFinal.TabIndex = 6;
            this.TbxTextoFinal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PbxArchivo
            // 
            this.PbxArchivo.Location = new System.Drawing.Point(180, 191);
            this.PbxArchivo.Name = "PbxArchivo";
            this.PbxArchivo.Size = new System.Drawing.Size(271, 211);
            this.PbxArchivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxArchivo.TabIndex = 7;
            this.PbxArchivo.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(87, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(649, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(596, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "@Patricio Quishpe 7364";
            // 
            // BfnCheck
            // 
            this.BfnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.BfnCheck.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.BfnCheck.Checked = true;
            this.BfnCheck.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.BfnCheck.ForeColor = System.Drawing.Color.White;
            this.BfnCheck.Location = new System.Drawing.Point(79, 248);
            this.BfnCheck.Name = "BfnCheck";
            this.BfnCheck.Size = new System.Drawing.Size(20, 20);
            this.BfnCheck.TabIndex = 12;
            // 
            // bunifuAbrirArchivo
            // 
            this.bunifuAbrirArchivo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuAbrirArchivo.BackColor = System.Drawing.Color.LimeGreen;
            this.bunifuAbrirArchivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuAbrirArchivo.BorderRadius = 0;
            this.bunifuAbrirArchivo.ButtonText = "Abrir Archivo";
            this.bunifuAbrirArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuAbrirArchivo.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuAbrirArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuAbrirArchivo.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuAbrirArchivo.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuAbrirArchivo.Iconimage")));
            this.bunifuAbrirArchivo.Iconimage_right = null;
            this.bunifuAbrirArchivo.Iconimage_right_Selected = null;
            this.bunifuAbrirArchivo.Iconimage_Selected = null;
            this.bunifuAbrirArchivo.IconMarginLeft = 0;
            this.bunifuAbrirArchivo.IconMarginRight = 0;
            this.bunifuAbrirArchivo.IconRightVisible = true;
            this.bunifuAbrirArchivo.IconRightZoom = 0D;
            this.bunifuAbrirArchivo.IconVisible = true;
            this.bunifuAbrirArchivo.IconZoom = 90D;
            this.bunifuAbrirArchivo.IsTab = false;
            this.bunifuAbrirArchivo.Location = new System.Drawing.Point(13, 292);
            this.bunifuAbrirArchivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuAbrirArchivo.Name = "bunifuAbrirArchivo";
            this.bunifuAbrirArchivo.Normalcolor = System.Drawing.Color.LimeGreen;
            this.bunifuAbrirArchivo.OnHovercolor = System.Drawing.Color.Lime;
            this.bunifuAbrirArchivo.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuAbrirArchivo.selected = false;
            this.bunifuAbrirArchivo.Size = new System.Drawing.Size(141, 38);
            this.bunifuAbrirArchivo.TabIndex = 13;
            this.bunifuAbrirArchivo.Text = "Abrir Archivo";
            this.bunifuAbrirArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuAbrirArchivo.Textcolor = System.Drawing.Color.White;
            this.bunifuAbrirArchivo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuAbrirArchivo.Click += new System.EventHandler(this.bunifuAbrirArchivo_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.Location = new System.Drawing.Point(48, 348);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(81, 27);
            this.BtnCerrar.TabIndex = 14;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.bunifuAbrirArchivo);
            this.Controls.Add(this.BfnCheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PbxArchivo);
            this.Controls.Add(this.TbxTextoFinal);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbxArchivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbxTextoFinal;
        private System.Windows.Forms.PictureBox PbxArchivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuCheckbox BfnCheck;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuAbrirArchivo;
        private System.Windows.Forms.Button BtnCerrar;
    }
}

