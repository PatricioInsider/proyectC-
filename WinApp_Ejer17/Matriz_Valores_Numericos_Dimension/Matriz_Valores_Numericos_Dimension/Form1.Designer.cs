namespace Matriz_Valores_Numericos_Dimension
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblElemtPosit = new System.Windows.Forms.Label();
            this.lblElemtNeg = new System.Windows.Forms.Label();
            this.lblTotalSum = new System.Windows.Forms.Label();
            this.lblSumColOrPar = new System.Windows.Forms.Label();
            this.lblMultpNumNeg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfilas = new System.Windows.Forms.TextBox();
            this.txtCol = new System.Windows.Forms.TextBox();
            this.btnConfirmarD = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Location = new System.Drawing.Point(48, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(406, 186);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCalcular.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.Black;
            this.btnCalcular.Location = new System.Drawing.Point(98, 353);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(86, 29);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblElemtPosit
            // 
            this.lblElemtPosit.AutoSize = true;
            this.lblElemtPosit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElemtPosit.Location = new System.Drawing.Point(722, 365);
            this.lblElemtPosit.Name = "lblElemtPosit";
            this.lblElemtPosit.Size = new System.Drawing.Size(120, 17);
            this.lblElemtPosit.TabIndex = 2;
            this.lblElemtPosit.Text = "______________";
            // 
            // lblElemtNeg
            // 
            this.lblElemtNeg.AutoSize = true;
            this.lblElemtNeg.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElemtNeg.Location = new System.Drawing.Point(722, 389);
            this.lblElemtNeg.Name = "lblElemtNeg";
            this.lblElemtNeg.Size = new System.Drawing.Size(120, 17);
            this.lblElemtNeg.TabIndex = 3;
            this.lblElemtNeg.Text = "______________";
            // 
            // lblTotalSum
            // 
            this.lblTotalSum.AutoSize = true;
            this.lblTotalSum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSum.Location = new System.Drawing.Point(722, 415);
            this.lblTotalSum.Name = "lblTotalSum";
            this.lblTotalSum.Size = new System.Drawing.Size(120, 17);
            this.lblTotalSum.TabIndex = 4;
            this.lblTotalSum.Text = "______________";
            // 
            // lblSumColOrPar
            // 
            this.lblSumColOrPar.AutoSize = true;
            this.lblSumColOrPar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumColOrPar.Location = new System.Drawing.Point(722, 440);
            this.lblSumColOrPar.Name = "lblSumColOrPar";
            this.lblSumColOrPar.Size = new System.Drawing.Size(120, 17);
            this.lblSumColOrPar.TabIndex = 5;
            this.lblSumColOrPar.Text = "______________";
            // 
            // lblMultpNumNeg
            // 
            this.lblMultpNumNeg.AutoSize = true;
            this.lblMultpNumNeg.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultpNumNeg.Location = new System.Drawing.Point(722, 465);
            this.lblMultpNumNeg.Name = "lblMultpNumNeg";
            this.lblMultpNumNeg.Size = new System.Drawing.Size(120, 17);
            this.lblMultpNumNeg.TabIndex = 6;
            this.lblMultpNumNeg.Text = "______________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(557, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Filas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(674, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Columnas:";
            // 
            // txtfilas
            // 
            this.txtfilas.Location = new System.Drawing.Point(599, 183);
            this.txtfilas.Name = "txtfilas";
            this.txtfilas.Size = new System.Drawing.Size(35, 20);
            this.txtfilas.TabIndex = 9;
            this.txtfilas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfilas_KeyPress);
            // 
            // txtCol
            // 
            this.txtCol.Location = new System.Drawing.Point(750, 183);
            this.txtCol.Name = "txtCol";
            this.txtCol.Size = new System.Drawing.Size(35, 20);
            this.txtCol.TabIndex = 10;
            this.txtCol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCol_KeyPress);
            // 
            // btnConfirmarD
            // 
            this.btnConfirmarD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConfirmarD.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarD.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmarD.Location = new System.Drawing.Point(617, 223);
            this.btnConfirmarD.Name = "btnConfirmarD";
            this.btnConfirmarD.Size = new System.Drawing.Size(102, 29);
            this.btnConfirmarD.TabIndex = 11;
            this.btnConfirmarD.Text = "Confirmar";
            this.btnConfirmarD.UseVisualStyleBackColor = false;
            this.btnConfirmarD.Click += new System.EventHandler(this.btnConfirmDimensions_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(298, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Matriz de valores numéricos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(524, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ingresar el número de columnas y filas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(196, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ingresar datos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(392, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cant. de elementos positivos:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(392, 465);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(346, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Multiplicación de todos los números negativos:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(392, 440);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(349, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Suma de elementos en columnas de orden par:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(392, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(224, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Suma de todos los elementos:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(392, 389);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(227, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Cant. de elementos negativos:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Location = new System.Drawing.Point(230, 353);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(86, 29);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(559, 331);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Datos Resultantes";
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnSalir.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.Black;
            this.BtnSalir.Location = new System.Drawing.Point(740, 506);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(102, 29);
            this.BtnSalir.TabIndex = 23;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(872, 557);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConfirmarD);
            this.Controls.Add(this.txtCol);
            this.Controls.Add(this.txtfilas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMultpNumNeg);
            this.Controls.Add(this.lblSumColOrPar);
            this.Controls.Add(this.lblTotalSum);
            this.Controls.Add(this.lblElemtNeg);
            this.Controls.Add(this.lblElemtPosit);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Matriz";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblElemtPosit;
        private System.Windows.Forms.Label lblElemtNeg;
        private System.Windows.Forms.Label lblTotalSum;
        private System.Windows.Forms.Label lblSumColOrPar;
        private System.Windows.Forms.Label lblMultpNumNeg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfilas;
        private System.Windows.Forms.TextBox txtCol;
        private System.Windows.Forms.Button btnConfirmarD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnSalir;
    }
}

