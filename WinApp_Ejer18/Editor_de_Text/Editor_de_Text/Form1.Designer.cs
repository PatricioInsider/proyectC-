namespace Editor_de_Text
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNegrita = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCursiva = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonIzquierda = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCentro = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDerecha = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRecuperar = new System.Windows.Forms.ToolStripButton();
            this.richTextBoxTexto = new System.Windows.Forms.RichTextBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNegrita,
            this.toolStripSeparator1,
            this.toolStripButtonCursiva,
            this.toolStripSeparator2,
            this.toolStripButtonIzquierda,
            this.toolStripSeparator3,
            this.toolStripButtonCentro,
            this.toolStripSeparator4,
            this.toolStripButtonDerecha,
            this.toolStripSeparator5,
            this.toolStripButtonColor,
            this.toolStripSeparator6,
            this.toolStripButtonGuardar,
            this.toolStripSeparator7,
            this.toolStripButtonRecuperar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNegrita
            // 
            this.toolStripButtonNegrita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNegrita.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNegrita.Image")));
            this.toolStripButtonNegrita.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNegrita.Name = "toolStripButtonNegrita";
            this.toolStripButtonNegrita.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonNegrita.Text = "Negrita";
            this.toolStripButtonNegrita.Click += new System.EventHandler(this.toolStripButtonNegrita_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonCursiva
            // 
            this.toolStripButtonCursiva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCursiva.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCursiva.Image")));
            this.toolStripButtonCursiva.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCursiva.Name = "toolStripButtonCursiva";
            this.toolStripButtonCursiva.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonCursiva.Text = "Cursiva";
            this.toolStripButtonCursiva.Click += new System.EventHandler(this.toolStripButtonCursiva_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonIzquierda
            // 
            this.toolStripButtonIzquierda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonIzquierda.Image = global::Editor_de_Text.Properties.Resources.alinear_a_la_izquierda;
            this.toolStripButtonIzquierda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonIzquierda.Name = "toolStripButtonIzquierda";
            this.toolStripButtonIzquierda.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonIzquierda.Text = "Izquierda";
            this.toolStripButtonIzquierda.Click += new System.EventHandler(this.toolStripButtonIzquierda_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonCentro
            // 
            this.toolStripButtonCentro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCentro.Image = global::Editor_de_Text.Properties.Resources.alinear_al_centro1;
            this.toolStripButtonCentro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCentro.Name = "toolStripButtonCentro";
            this.toolStripButtonCentro.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonCentro.Text = "Centro";
            this.toolStripButtonCentro.Click += new System.EventHandler(this.toolStripButtonCentro_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonDerecha
            // 
            this.toolStripButtonDerecha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDerecha.Image = global::Editor_de_Text.Properties.Resources.alineacion_derecha;
            this.toolStripButtonDerecha.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDerecha.Name = "toolStripButtonDerecha";
            this.toolStripButtonDerecha.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonDerecha.Text = "Derecha";
            this.toolStripButtonDerecha.Click += new System.EventHandler(this.toolStripButtonDerecha_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonColor
            // 
            this.toolStripButtonColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonColor.Image = global::Editor_de_Text.Properties.Resources.circulo_de_color;
            this.toolStripButtonColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonColor.Name = "toolStripButtonColor";
            this.toolStripButtonColor.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonColor.Text = "Color";
            this.toolStripButtonColor.Click += new System.EventHandler(this.toolStripButtonColor_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonGuardar
            // 
            this.toolStripButtonGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGuardar.Image = global::Editor_de_Text.Properties.Resources.disquete;
            this.toolStripButtonGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGuardar.Name = "toolStripButtonGuardar";
            this.toolStripButtonGuardar.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonGuardar.Text = "Guardar";
            this.toolStripButtonGuardar.Click += new System.EventHandler(this.toolStripButtonGuardar_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonRecuperar
            // 
            this.toolStripButtonRecuperar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRecuperar.Image = global::Editor_de_Text.Properties.Resources.enviar_archivo;
            this.toolStripButtonRecuperar.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.toolStripButtonRecuperar.Name = "toolStripButtonRecuperar";
            this.toolStripButtonRecuperar.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonRecuperar.Text = "Recuperar";
            this.toolStripButtonRecuperar.Click += new System.EventHandler(this.toolStripButtonRecuperar_Click);
            // 
            // richTextBoxTexto
            // 
            this.richTextBoxTexto.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxTexto.Location = new System.Drawing.Point(0, 25);
            this.richTextBoxTexto.Name = "richTextBoxTexto";
            this.richTextBoxTexto.Size = new System.Drawing.Size(800, 424);
            this.richTextBoxTexto.TabIndex = 1;
            this.richTextBoxTexto.Text = "";
            this.richTextBoxTexto.TextChanged += new System.EventHandler(this.richTextBoxTexto_TextChanged);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Archivos de texto|*.txt|Todos los archivos|*.*";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Archivos de texto|*.txt|Todos los archivos|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxTexto);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Editor de Texto";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonNegrita;
        private System.Windows.Forms.ToolStripButton toolStripButtonCursiva;
        private System.Windows.Forms.ToolStripButton toolStripButtonIzquierda;
        private System.Windows.Forms.ToolStripButton toolStripButtonCentro;
        private System.Windows.Forms.ToolStripButton toolStripButtonDerecha;
        private System.Windows.Forms.ToolStripButton toolStripButtonColor;
        private System.Windows.Forms.ToolStripButton toolStripButtonGuardar;
        private System.Windows.Forms.ToolStripButton toolStripButtonRecuperar;
        private System.Windows.Forms.RichTextBox richTextBoxTexto;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;

        #endregion

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    }
}

