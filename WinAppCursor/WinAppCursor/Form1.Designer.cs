namespace WinAppCursor
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
            this.BtnAsteri = new System.Windows.Forms.Button();
            this.BtnExclamacion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CbxDesplegable = new System.Windows.Forms.ComboBox();
            this.BtnBeep = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnVentana = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAsteri
            // 
            this.BtnAsteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAsteri.Location = new System.Drawing.Point(199, 37);
            this.BtnAsteri.Name = "BtnAsteri";
            this.BtnAsteri.Size = new System.Drawing.Size(86, 34);
            this.BtnAsteri.TabIndex = 0;
            this.BtnAsteri.Text = "ASTERI";
            this.BtnAsteri.UseVisualStyleBackColor = true;
            this.BtnAsteri.Click += new System.EventHandler(this.BtnAsteri_Click);
            // 
            // BtnExclamacion
            // 
            this.BtnExclamacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExclamacion.Location = new System.Drawing.Point(331, 37);
            this.BtnExclamacion.Name = "BtnExclamacion";
            this.BtnExclamacion.Size = new System.Drawing.Size(138, 34);
            this.BtnExclamacion.TabIndex = 1;
            this.BtnExclamacion.Text = "EXCLAMACIÒN";
            this.BtnExclamacion.UseVisualStyleBackColor = true;
            this.BtnExclamacion.Click += new System.EventHandler(this.BtnExclamacion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cursores";
            // 
            // CbxDesplegable
            // 
            this.CbxDesplegable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxDesplegable.FormattingEnabled = true;
            this.CbxDesplegable.Items.AddRange(new object[] {
            "Arrow ",
            "Hand",
            "Help",
            "WaitCursor",
            "Default"});
            this.CbxDesplegable.Location = new System.Drawing.Point(338, 187);
            this.CbxDesplegable.Name = "CbxDesplegable";
            this.CbxDesplegable.Size = new System.Drawing.Size(121, 28);
            this.CbxDesplegable.TabIndex = 3;
            this.CbxDesplegable.SelectedIndexChanged += new System.EventHandler(this.CbxDesplegable_SelectedIndexChanged);
            // 
            // BtnBeep
            // 
            this.BtnBeep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBeep.Location = new System.Drawing.Point(51, 37);
            this.BtnBeep.Name = "BtnBeep";
            this.BtnBeep.Size = new System.Drawing.Size(88, 34);
            this.BtnBeep.TabIndex = 4;
            this.BtnBeep.Text = "BEEP";
            this.BtnBeep.UseVisualStyleBackColor = true;
            this.BtnBeep.Click += new System.EventHandler(this.BtnBeep_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnExclamacion);
            this.groupBox1.Controls.Add(this.BtnBeep);
            this.groupBox1.Controls.Add(this.BtnAsteri);
            this.groupBox1.Location = new System.Drawing.Point(180, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 105);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sonido";
            // 
            // BtnVentana
            // 
            this.BtnVentana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVentana.Location = new System.Drawing.Point(511, 347);
            this.BtnVentana.Name = "BtnVentana";
            this.BtnVentana.Size = new System.Drawing.Size(122, 34);
            this.BtnVentana.TabIndex = 2;
            this.BtnVentana.Text = "Ventana";
            this.BtnVentana.UseVisualStyleBackColor = true;
            this.BtnVentana.Click += new System.EventHandler(this.BtnVentana_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnVentana);
            this.Controls.Add(this.CbxDesplegable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAsteri;
        private System.Windows.Forms.Button BtnExclamacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbxDesplegable;
        private System.Windows.Forms.Button BtnBeep;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnVentana;
    }
}

