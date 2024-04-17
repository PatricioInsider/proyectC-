namespace WinAppMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alFondoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alTextoYAlFondoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.llamarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aUnProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aUnFormularioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PbxImage = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.odontologoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discriminanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.llamarToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAbrir,
            this.MnuCerrar,
            this.MnuSalir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // MnuAbrir
            // 
            this.MnuAbrir.Name = "MnuAbrir";
            this.MnuAbrir.Size = new System.Drawing.Size(180, 22);
            this.MnuAbrir.Text = "Abrir";
            this.MnuAbrir.Click += new System.EventHandler(this.MnuAbrir_Click);
            // 
            // MnuCerrar
            // 
            this.MnuCerrar.Name = "MnuCerrar";
            this.MnuCerrar.Size = new System.Drawing.Size(180, 22);
            this.MnuCerrar.Text = "Cerrar";
            this.MnuCerrar.Click += new System.EventHandler(this.MnuCerrar_Click);
            // 
            // MnuSalir
            // 
            this.MnuSalir.Name = "MnuSalir";
            this.MnuSalir.Size = new System.Drawing.Size(180, 22);
            this.MnuSalir.Text = "Salir";
            this.MnuSalir.Click += new System.EventHandler(this.MnuSalir_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alTextoToolStripMenuItem,
            this.alFondoToolStripMenuItem,
            this.alTextoYAlFondoToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // alTextoToolStripMenuItem
            // 
            this.alTextoToolStripMenuItem.Name = "alTextoToolStripMenuItem";
            this.alTextoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alTextoToolStripMenuItem.Text = "Al texto";
            this.alTextoToolStripMenuItem.Click += new System.EventHandler(this.alTextoToolStripMenuItem_Click);
            // 
            // alFondoToolStripMenuItem
            // 
            this.alFondoToolStripMenuItem.Name = "alFondoToolStripMenuItem";
            this.alFondoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alFondoToolStripMenuItem.Text = "Al fondo";
            this.alFondoToolStripMenuItem.Click += new System.EventHandler(this.alFondoToolStripMenuItem_Click);
            // 
            // alTextoYAlFondoToolStripMenuItem
            // 
            this.alTextoYAlFondoToolStripMenuItem.Name = "alTextoYAlFondoToolStripMenuItem";
            this.alTextoYAlFondoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alTextoYAlFondoToolStripMenuItem.Text = "Al texto y al fondo";
            this.alTextoYAlFondoToolStripMenuItem.Click += new System.EventHandler(this.alTextoYAlFondoToolStripMenuItem_Click);
            // 
            // llamarToolStripMenuItem
            // 
            this.llamarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aUnProyectoToolStripMenuItem,
            this.aUnFormularioToolStripMenuItem});
            this.llamarToolStripMenuItem.Name = "llamarToolStripMenuItem";
            this.llamarToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.llamarToolStripMenuItem.Text = "Llamar";
            // 
            // aUnProyectoToolStripMenuItem
            // 
            this.aUnProyectoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odontologoToolStripMenuItem,
            this.discriminanteToolStripMenuItem});
            this.aUnProyectoToolStripMenuItem.Name = "aUnProyectoToolStripMenuItem";
            this.aUnProyectoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aUnProyectoToolStripMenuItem.Text = "A un proyecto";
            this.aUnProyectoToolStripMenuItem.Click += new System.EventHandler(this.aUnProyectoToolStripMenuItem_Click);
            // 
            // aUnFormularioToolStripMenuItem
            // 
            this.aUnFormularioToolStripMenuItem.Name = "aUnFormularioToolStripMenuItem";
            this.aUnFormularioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aUnFormularioToolStripMenuItem.Text = "A un formulario";
            this.aUnFormularioToolStripMenuItem.Click += new System.EventHandler(this.aUnFormularioToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "?";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de ..";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // PbxImage
            // 
            this.PbxImage.Location = new System.Drawing.Point(437, 111);
            this.PbxImage.Name = "PbxImage";
            this.PbxImage.Size = new System.Drawing.Size(312, 197);
            this.PbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxImage.TabIndex = 1;
            this.PbxImage.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(65, 151);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(253, 20);
            this.LblTitulo.TabIndex = 2;
            this.LblTitulo.Text = "El Domingo son las elecciones";
            this.LblTitulo.Click += new System.EventHandler(this.LblTitulo_Click);
            // 
            // odontologoToolStripMenuItem
            // 
            this.odontologoToolStripMenuItem.Name = "odontologoToolStripMenuItem";
            this.odontologoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.odontologoToolStripMenuItem.Text = "Odontologo";
            this.odontologoToolStripMenuItem.Click += new System.EventHandler(this.odontologoToolStripMenuItem_Click);
            // 
            // discriminanteToolStripMenuItem
            // 
            this.discriminanteToolStripMenuItem.Name = "discriminanteToolStripMenuItem";
            this.discriminanteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.discriminanteToolStripMenuItem.Text = "Discriminante";
            this.discriminanteToolStripMenuItem.Click += new System.EventHandler(this.discriminanteToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.PbxImage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuAbrir;
        private System.Windows.Forms.ToolStripMenuItem MnuCerrar;
        private System.Windows.Forms.ToolStripMenuItem MnuSalir;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alTextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alFondoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alTextoYAlFondoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem llamarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aUnProyectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aUnFormularioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.PictureBox PbxImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem odontologoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discriminanteToolStripMenuItem;
    }
}

