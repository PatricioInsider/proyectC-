namespace WinAppPanelesBunifu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuColorTransition1 = new Bunifu.Framework.UI.BunifuColorTransition(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2_Discriminante = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton_Click = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuColorTransition1
            // 
            this.bunifuColorTransition1.Color1 = System.Drawing.Color.White;
            this.bunifuColorTransition1.Color2 = System.Drawing.Color.White;
            this.bunifuColorTransition1.ProgessValue = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.bunifuFlatButton_Click);
            this.panel2.Controls.Add(this.bunifuFlatButton2_Discriminante);
            this.panel2.Controls.Add(this.bunifuFlatButton1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 350);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 350);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Salir";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(9, 267);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(185, 43);
            this.bunifuFlatButton1.TabIndex = 0;
            this.bunifuFlatButton1.Text = "Salir";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuFlatButton2_Discriminante
            // 
            this.bunifuFlatButton2_Discriminante.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2_Discriminante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2_Discriminante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2_Discriminante.BorderRadius = 0;
            this.bunifuFlatButton2_Discriminante.ButtonText = "Discriminante";
            this.bunifuFlatButton2_Discriminante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2_Discriminante.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2_Discriminante.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2_Discriminante.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2_Discriminante.Iconimage")));
            this.bunifuFlatButton2_Discriminante.Iconimage_right = null;
            this.bunifuFlatButton2_Discriminante.Iconimage_right_Selected = null;
            this.bunifuFlatButton2_Discriminante.Iconimage_Selected = null;
            this.bunifuFlatButton2_Discriminante.IconMarginLeft = 0;
            this.bunifuFlatButton2_Discriminante.IconMarginRight = 0;
            this.bunifuFlatButton2_Discriminante.IconRightVisible = true;
            this.bunifuFlatButton2_Discriminante.IconRightZoom = 0D;
            this.bunifuFlatButton2_Discriminante.IconVisible = true;
            this.bunifuFlatButton2_Discriminante.IconZoom = 90D;
            this.bunifuFlatButton2_Discriminante.IsTab = false;
            this.bunifuFlatButton2_Discriminante.Location = new System.Drawing.Point(9, 205);
            this.bunifuFlatButton2_Discriminante.Name = "bunifuFlatButton2_Discriminante";
            this.bunifuFlatButton2_Discriminante.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2_Discriminante.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2_Discriminante.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2_Discriminante.selected = false;
            this.bunifuFlatButton2_Discriminante.Size = new System.Drawing.Size(185, 43);
            this.bunifuFlatButton2_Discriminante.TabIndex = 1;
            this.bunifuFlatButton2_Discriminante.Text = "Discriminante";
            this.bunifuFlatButton2_Discriminante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2_Discriminante.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2_Discriminante.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2_Discriminante.Click += new System.EventHandler(this.bunifuFlatButton2_Discriminante_Click);
            // 
            // bunifuFlatButton_Click
            // 
            this.bunifuFlatButton_Click.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton_Click.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton_Click.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton_Click.BorderRadius = 0;
            this.bunifuFlatButton_Click.ButtonText = "Click";
            this.bunifuFlatButton_Click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton_Click.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton_Click.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton_Click.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton_Click.Iconimage")));
            this.bunifuFlatButton_Click.Iconimage_right = null;
            this.bunifuFlatButton_Click.Iconimage_right_Selected = null;
            this.bunifuFlatButton_Click.Iconimage_Selected = null;
            this.bunifuFlatButton_Click.IconMarginLeft = 0;
            this.bunifuFlatButton_Click.IconMarginRight = 0;
            this.bunifuFlatButton_Click.IconRightVisible = true;
            this.bunifuFlatButton_Click.IconRightZoom = 0D;
            this.bunifuFlatButton_Click.IconVisible = true;
            this.bunifuFlatButton_Click.IconZoom = 90D;
            this.bunifuFlatButton_Click.IsTab = false;
            this.bunifuFlatButton_Click.Location = new System.Drawing.Point(9, 137);
            this.bunifuFlatButton_Click.Name = "bunifuFlatButton_Click";
            this.bunifuFlatButton_Click.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton_Click.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton_Click.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton_Click.selected = false;
            this.bunifuFlatButton_Click.Size = new System.Drawing.Size(185, 43);
            this.bunifuFlatButton_Click.TabIndex = 2;
            this.bunifuFlatButton_Click.Text = "Click";
            this.bunifuFlatButton_Click.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton_Click.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton_Click.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton_Click.Click += new System.EventHandler(this.bunifuFlatButton_Click_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuColorTransition bunifuColorTransition1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton_Click;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2_Discriminante;
    }
}

