namespace Triangulo
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
            this.LBtitulo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.circuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuadradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circuloToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.romboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.áreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perímetroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TBeston = new System.Windows.Forms.TextBox();
            this.BTsalir = new System.Windows.Forms.Button();
            this.BTmenu = new System.Windows.Forms.Button();
            this.Res = new System.Windows.Forms.Label();
            this.LT = new System.Windows.Forms.Label();
            this.LBaltura = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LB3 = new System.Windows.Forms.Label();
            this.LBdefinicion = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.PBespoch = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBespoch)).BeginInit();
            this.SuspendLayout();
            // 
            // LBtitulo
            // 
            this.LBtitulo.AutoSize = true;
            this.LBtitulo.Font = new System.Drawing.Font("Comic Kings", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBtitulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LBtitulo.Location = new System.Drawing.Point(70, 87);
            this.LBtitulo.Name = "LBtitulo";
            this.LBtitulo.Size = new System.Drawing.Size(692, 34);
            this.LBtitulo.TabIndex = 0;
            this.LBtitulo.Text = "Calcular el area de un triangulo";
            this.LBtitulo.Click += new System.EventHandler(this.LBtitulo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.circuloToolStripMenuItem,
            this.cuadradoToolStripMenuItem,
            this.circuloToolStripMenuItem1,
            this.romboToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1234, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // circuloToolStripMenuItem
            // 
            this.circuloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.áreaToolStripMenuItem,
            this.perímetroToolStripMenuItem});
            this.circuloToolStripMenuItem.Name = "circuloToolStripMenuItem";
            this.circuloToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.circuloToolStripMenuItem.Text = "Triángulo";
            // 
            // cuadradoToolStripMenuItem
            // 
            this.cuadradoToolStripMenuItem.Name = "cuadradoToolStripMenuItem";
            this.cuadradoToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cuadradoToolStripMenuItem.Text = "Cuadrado";
            // 
            // circuloToolStripMenuItem1
            // 
            this.circuloToolStripMenuItem1.Name = "circuloToolStripMenuItem1";
            this.circuloToolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.circuloToolStripMenuItem1.Text = "Circulo";
            // 
            // romboToolStripMenuItem
            // 
            this.romboToolStripMenuItem.Name = "romboToolStripMenuItem";
            this.romboToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.romboToolStripMenuItem.Text = "Rombo";
            // 
            // áreaToolStripMenuItem
            // 
            this.áreaToolStripMenuItem.Name = "áreaToolStripMenuItem";
            this.áreaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.áreaToolStripMenuItem.Text = "Área";
            // 
            // perímetroToolStripMenuItem
            // 
            this.perímetroToolStripMenuItem.Name = "perímetroToolStripMenuItem";
            this.perímetroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.perímetroToolStripMenuItem.Text = "Perímetro";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(184, 184);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(461, 252);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // TBeston
            // 
            this.TBeston.Location = new System.Drawing.Point(837, 326);
            this.TBeston.Name = "TBeston";
            this.TBeston.Size = new System.Drawing.Size(100, 20);
            this.TBeston.TabIndex = 3;
            // 
            // BTsalir
            // 
            this.BTsalir.Location = new System.Drawing.Point(1121, 564);
            this.BTsalir.Name = "BTsalir";
            this.BTsalir.Size = new System.Drawing.Size(70, 29);
            this.BTsalir.TabIndex = 4;
            this.BTsalir.Text = "Salir";
            this.BTsalir.UseVisualStyleBackColor = true;
            this.BTsalir.Click += new System.EventHandler(this.BTsalir_Click);
            // 
            // BTmenu
            // 
            this.BTmenu.Location = new System.Drawing.Point(1074, 184);
            this.BTmenu.Name = "BTmenu";
            this.BTmenu.Size = new System.Drawing.Size(127, 23);
            this.BTmenu.TabIndex = 5;
            this.BTmenu.Text = "Menú Principal";
            this.BTmenu.UseVisualStyleBackColor = true;
            this.BTmenu.Click += new System.EventHandler(this.BTmenu_Click);
            // 
            // Res
            // 
            this.Res.AutoSize = true;
            this.Res.Location = new System.Drawing.Point(759, 388);
            this.Res.Name = "Res";
            this.Res.Size = new System.Drawing.Size(58, 13);
            this.Res.TabIndex = 6;
            this.Res.Text = "Resultado:";
            this.Res.Click += new System.EventHandler(this.Res_Click);
            // 
            // LT
            // 
            this.LT.AutoSize = true;
            this.LT.Location = new System.Drawing.Point(762, 280);
            this.LT.Name = "LT";
            this.LT.Size = new System.Drawing.Size(34, 13);
            this.LT.TabIndex = 7;
            this.LT.Text = "Base:";
            this.LT.Click += new System.EventHandler(this.LT_Click);
            // 
            // LBaltura
            // 
            this.LBaltura.AutoSize = true;
            this.LBaltura.Location = new System.Drawing.Point(759, 329);
            this.LBaltura.Name = "LBaltura";
            this.LBaltura.Size = new System.Drawing.Size(37, 13);
            this.LBaltura.TabIndex = 8;
            this.LBaltura.Text = "Altura:";
            this.LBaltura.Click += new System.EventHandler(this.LBaltura_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(837, 277);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(745, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ingresa los siguientes datos del Triángulo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LB3
            // 
            this.LB3.AutoSize = true;
            this.LB3.Location = new System.Drawing.Point(73, 517);
            this.LB3.Name = "LB3";
            this.LB3.Size = new System.Drawing.Size(931, 26);
            this.LB3.TabIndex = 11;
            this.LB3.Text = resources.GetString("LB3.Text");
            this.LB3.Click += new System.EventHandler(this.LB3_Click);
            // 
            // LBdefinicion
            // 
            this.LBdefinicion.AutoSize = true;
            this.LBdefinicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBdefinicion.Location = new System.Drawing.Point(97, 479);
            this.LBdefinicion.Name = "LBdefinicion";
            this.LBdefinicion.Size = new System.Drawing.Size(176, 13);
            this.LBdefinicion.TabIndex = 12;
            this.LBdefinicion.Text = "Qué es el área de una figura?";
            this.LBdefinicion.Click += new System.EventHandler(this.LBdefinicion_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(837, 381);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 14;
            // 
            // PBespoch
            // 
            this.PBespoch.Image = ((System.Drawing.Image)(resources.GetObject("PBespoch.Image")));
            this.PBespoch.Location = new System.Drawing.Point(796, 27);
            this.PBespoch.Name = "PBespoch";
            this.PBespoch.Size = new System.Drawing.Size(426, 143);
            this.PBespoch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PBespoch.TabIndex = 15;
            this.PBespoch.TabStop = false;
            this.PBespoch.Click += new System.EventHandler(this.PBespoch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Teoría aplicada:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1234, 625);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PBespoch);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.LBdefinicion);
            this.Controls.Add(this.LB3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LBaltura);
            this.Controls.Add(this.LT);
            this.Controls.Add(this.Res);
            this.Controls.Add(this.BTmenu);
            this.Controls.Add(this.BTsalir);
            this.Controls.Add(this.TBeston);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LBtitulo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBespoch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBtitulo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem circuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem áreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perímetroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuadradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circuloToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem romboToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TBeston;
        private System.Windows.Forms.Button BTsalir;
        private System.Windows.Forms.Button BTmenu;
        private System.Windows.Forms.Label Res;
        private System.Windows.Forms.Label LT;
        private System.Windows.Forms.Label LBaltura;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB3;
        private System.Windows.Forms.Label LBdefinicion;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox PBespoch;
        private System.Windows.Forms.Label label2;
    }
}

