namespace _16.WindowsFormsApp1.Matriz
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblElementosPositivos = new System.Windows.Forms.Label();
            this.lblElementosNegativos = new System.Windows.Forms.Label();
            this.lblSumaTotal = new System.Windows.Forms.Label();
            this.lblSumaColumnasPares = new System.Windows.Forms.Label();
            this.lblMultiplicacionNegativos = new System.Windows.Forms.Label();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFilas = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtColumnas = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.prueba = new System.Windows.Forms.Label();
            this.prueba1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnCalcular.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(325, 297);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(104, 33);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(262, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Operaciones con Matriz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "- Cantidad de elementos positivos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "- Cantidad de elementos negativos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "- Suma de todos los elementos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(549, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "- Suma de todos los elementos situados en las columnas de orden par:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(84, 497);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(378, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "- Multiplicación de todos los números negativos:";
            // 
            // lblElementosPositivos
            // 
            this.lblElementosPositivos.AutoSize = true;
            this.lblElementosPositivos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElementosPositivos.Location = new System.Drawing.Point(365, 343);
            this.lblElementosPositivos.Name = "lblElementosPositivos";
            this.lblElementosPositivos.Size = new System.Drawing.Size(0, 21);
            this.lblElementosPositivos.TabIndex = 7;
            // 
            // lblElementosNegativos
            // 
            this.lblElementosNegativos.AutoSize = true;
            this.lblElementosNegativos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElementosNegativos.Location = new System.Drawing.Point(376, 381);
            this.lblElementosNegativos.Name = "lblElementosNegativos";
            this.lblElementosNegativos.Size = new System.Drawing.Size(0, 21);
            this.lblElementosNegativos.TabIndex = 8;
            // 
            // lblSumaTotal
            // 
            this.lblSumaTotal.AutoSize = true;
            this.lblSumaTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumaTotal.Location = new System.Drawing.Point(337, 418);
            this.lblSumaTotal.Name = "lblSumaTotal";
            this.lblSumaTotal.Size = new System.Drawing.Size(0, 21);
            this.lblSumaTotal.TabIndex = 9;
            // 
            // lblSumaColumnasPares
            // 
            this.lblSumaColumnasPares.AutoSize = true;
            this.lblSumaColumnasPares.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumaColumnasPares.Location = new System.Drawing.Point(639, 457);
            this.lblSumaColumnasPares.Name = "lblSumaColumnasPares";
            this.lblSumaColumnasPares.Size = new System.Drawing.Size(0, 21);
            this.lblSumaColumnasPares.TabIndex = 10;
            // 
            // lblMultiplicacionNegativos
            // 
            this.lblMultiplicacionNegativos.AutoSize = true;
            this.lblMultiplicacionNegativos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiplicacionNegativos.Location = new System.Drawing.Point(468, 497);
            this.lblMultiplicacionNegativos.Name = "lblMultiplicacionNegativos";
            this.lblMultiplicacionNegativos.Size = new System.Drawing.Size(0, 21);
            this.lblMultiplicacionNegativos.TabIndex = 11;
            // 
            // txtElemento
            // 
            this.txtElemento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtElemento.Location = new System.Drawing.Point(325, 239);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(120, 27);
            this.txtElemento.TabIndex = 12;
            this.txtElemento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtElemento_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(234, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Elemento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(171, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Numero de columnas:";
            // 
            // txtFilas
            // 
            this.txtFilas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilas.Location = new System.Drawing.Point(325, 121);
            this.txtFilas.Name = "txtFilas";
            this.txtFilas.Size = new System.Drawing.Size(120, 23);
            this.txtFilas.TabIndex = 14;
            this.txtFilas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilas_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(205, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Numero de filas:";
            // 
            // txtColumnas
            // 
            this.txtColumnas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColumnas.Location = new System.Drawing.Point(325, 159);
            this.txtColumnas.Name = "txtColumnas";
            this.txtColumnas.Size = new System.Drawing.Size(120, 23);
            this.txtColumnas.TabIndex = 16;
            this.txtColumnas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtColumnas_KeyPress);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(591, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(86, 251);
            this.listBox1.TabIndex = 18;
            // 
            // prueba
            // 
            this.prueba.AutoSize = true;
            this.prueba.Location = new System.Drawing.Point(659, 116);
            this.prueba.Name = "prueba";
            this.prueba.Size = new System.Drawing.Size(0, 13);
            this.prueba.TabIndex = 19;
            // 
            // prueba1
            // 
            this.prueba1.AutoSize = true;
            this.prueba1.Location = new System.Drawing.Point(677, 179);
            this.prueba1.Name = "prueba1";
            this.prueba1.Size = new System.Drawing.Size(0, 13);
            this.prueba1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.prueba1);
            this.Controls.Add(this.prueba);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtColumnas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFilas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.lblMultiplicacionNegativos);
            this.Controls.Add(this.lblSumaColumnasPares);
            this.Controls.Add(this.lblSumaTotal);
            this.Controls.Add(this.lblElementosNegativos);
            this.Controls.Add(this.lblElementosPositivos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblElementosPositivos;
        private System.Windows.Forms.Label lblElementosNegativos;
        private System.Windows.Forms.Label lblSumaTotal;
        private System.Windows.Forms.Label lblSumaColumnasPares;
        private System.Windows.Forms.Label lblMultiplicacionNegativos;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFilas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtColumnas;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label prueba;
        private System.Windows.Forms.Label prueba1;
    }
}

