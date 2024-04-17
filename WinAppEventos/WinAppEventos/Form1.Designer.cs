namespace WinAppEventos
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
            this.BtnEventos = new System.Windows.Forms.Button();
            this.PbxFoto = new System.Windows.Forms.PictureBox();
            this.LblMessage = new System.Windows.Forms.Label();
            this.TxtValor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEventos
            // 
            this.BtnEventos.Location = new System.Drawing.Point(343, 241);
            this.BtnEventos.Name = "BtnEventos";
            this.BtnEventos.Size = new System.Drawing.Size(125, 66);
            this.BtnEventos.TabIndex = 0;
            this.BtnEventos.Text = "Eventos";
            this.BtnEventos.UseVisualStyleBackColor = true;
            this.BtnEventos.Click += new System.EventHandler(this.Eventos_Click);
            
            this.BtnEventos.MouseEnter += new System.EventHandler(this.Eventos_MouseEnter);
            this.BtnEventos.MouseHover += new System.EventHandler(this.BtnEventos_MouseHover);
            this.BtnEventos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Eventos_MouseMove);
            // 
            // PbxFoto
            // 
            this.PbxFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxFoto.Image = ((System.Drawing.Image)(resources.GetObject("PbxFoto.Image")));
            this.PbxFoto.Location = new System.Drawing.Point(160, 67);
            this.PbxFoto.Name = "PbxFoto";
            this.PbxFoto.Size = new System.Drawing.Size(155, 153);
            this.PbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxFoto.TabIndex = 1;
            this.PbxFoto.TabStop = false;
            // 
            // LblMessage
            // 
            this.LblMessage.AutoSize = true;
            this.LblMessage.Location = new System.Drawing.Point(537, 111);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(0, 13);
            this.LblMessage.TabIndex = 2;
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(478, 163);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(165, 20);
            this.TxtValor.TabIndex = 3;
            this.TxtValor.MouseEnter += new System.EventHandler(this.TxtValor_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtValor);
            this.Controls.Add(this.LblMessage);
            this.Controls.Add(this.PbxFoto);
            this.Controls.Add(this.BtnEventos);
            this.Name = "Form1";
            this.Text = "Eventos";
            this.Load += new System.EventHandler(this.BtnEventos_Load);
            this.MouseLeave += new System.EventHandler(this.BtnEventos_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.PbxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEventos;
        private System.Windows.Forms.PictureBox PbxFoto;
        private System.Windows.Forms.Label LblMessage;
        private System.Windows.Forms.TextBox TxtValor;
    }
}

