namespace WinApp_EjerI13
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLunes = new System.Windows.Forms.TextBox();
            this.txtMartes = new System.Windows.Forms.TextBox();
            this.txtMiercoles = new System.Windows.Forms.TextBox();
            this.txtJueves = new System.Windows.Forms.TextBox();
            this.txtViernes = new System.Windows.Forms.TextBox();
            this.txtSabado = new System.Windows.Forms.TextBox();
            this.txtDomingo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxDomingo = new System.Windows.Forms.CheckBox();
            this.checkBoxSabado = new System.Windows.Forms.CheckBox();
            this.checkBoxViernes = new System.Windows.Forms.CheckBox();
            this.checkBoxJueves = new System.Windows.Forms.CheckBox();
            this.checkBoxMiercoles = new System.Windows.Forms.CheckBox();
            this.checkBoxMartes = new System.Windows.Forms.CheckBox();
            this.checkBoxLunes = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEmpleados = new System.Windows.Forms.TextBox();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.numEmpleado = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(226, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pago de horas trabajadas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número de empleados:";
            // 
            // TxtNumero
            // 
            this.TxtNumero.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumero.Location = new System.Drawing.Point(203, 58);
            this.TxtNumero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(68, 25);
            this.TxtNumero.TabIndex = 2;
            this.TxtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumero_KeyPress);
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl2.Location = new System.Drawing.Point(384, 91);
            this.Lbl2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(187, 17);
            this.Lbl2.TabIndex = 3;
            this.Lbl2.Text = "Días y Horas de Trabajo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtLunes);
            this.groupBox2.Controls.Add(this.txtMartes);
            this.groupBox2.Controls.Add(this.txtMiercoles);
            this.groupBox2.Controls.Add(this.txtJueves);
            this.groupBox2.Controls.Add(this.txtViernes);
            this.groupBox2.Controls.Add(this.txtSabado);
            this.groupBox2.Controls.Add(this.txtDomingo);
            this.groupBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(539, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(97, 218);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Horas";
            // 
            // txtLunes
            // 
            this.txtLunes.Enabled = false;
            this.txtLunes.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLunes.Location = new System.Drawing.Point(27, 19);
            this.txtLunes.Name = "txtLunes";
            this.txtLunes.Size = new System.Drawing.Size(45, 22);
            this.txtLunes.TabIndex = 5;
            this.txtLunes.TextChanged += new System.EventHandler(this.txtLunes_TextChanged);
            // 
            // txtMartes
            // 
            this.txtMartes.Enabled = false;
            this.txtMartes.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMartes.Location = new System.Drawing.Point(27, 47);
            this.txtMartes.Name = "txtMartes";
            this.txtMartes.Size = new System.Drawing.Size(45, 22);
            this.txtMartes.TabIndex = 6;
            this.txtMartes.TextChanged += new System.EventHandler(this.txtMartes_TextChanged);
            // 
            // txtMiercoles
            // 
            this.txtMiercoles.Enabled = false;
            this.txtMiercoles.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiercoles.Location = new System.Drawing.Point(27, 72);
            this.txtMiercoles.Name = "txtMiercoles";
            this.txtMiercoles.Size = new System.Drawing.Size(45, 22);
            this.txtMiercoles.TabIndex = 7;
            // 
            // txtJueves
            // 
            this.txtJueves.Enabled = false;
            this.txtJueves.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJueves.Location = new System.Drawing.Point(27, 98);
            this.txtJueves.Name = "txtJueves";
            this.txtJueves.Size = new System.Drawing.Size(45, 22);
            this.txtJueves.TabIndex = 8;
            // 
            // txtViernes
            // 
            this.txtViernes.Enabled = false;
            this.txtViernes.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViernes.Location = new System.Drawing.Point(27, 123);
            this.txtViernes.Name = "txtViernes";
            this.txtViernes.Size = new System.Drawing.Size(45, 22);
            this.txtViernes.TabIndex = 9;
            // 
            // txtSabado
            // 
            this.txtSabado.Enabled = false;
            this.txtSabado.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSabado.Location = new System.Drawing.Point(27, 151);
            this.txtSabado.Name = "txtSabado";
            this.txtSabado.Size = new System.Drawing.Size(45, 22);
            this.txtSabado.TabIndex = 10;
            // 
            // txtDomingo
            // 
            this.txtDomingo.Enabled = false;
            this.txtDomingo.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomingo.Location = new System.Drawing.Point(27, 179);
            this.txtDomingo.Name = "txtDomingo";
            this.txtDomingo.Size = new System.Drawing.Size(45, 22);
            this.txtDomingo.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxDomingo);
            this.groupBox1.Controls.Add(this.checkBoxSabado);
            this.groupBox1.Controls.Add(this.checkBoxViernes);
            this.groupBox1.Controls.Add(this.checkBoxJueves);
            this.groupBox1.Controls.Add(this.checkBoxMiercoles);
            this.groupBox1.Controls.Add(this.checkBoxMartes);
            this.groupBox1.Controls.Add(this.checkBoxLunes);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(300, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 229);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Días de la semana";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkBoxDomingo
            // 
            this.checkBoxDomingo.AutoSize = true;
            this.checkBoxDomingo.Location = new System.Drawing.Point(15, 191);
            this.checkBoxDomingo.Name = "checkBoxDomingo";
            this.checkBoxDomingo.Size = new System.Drawing.Size(91, 21);
            this.checkBoxDomingo.TabIndex = 6;
            this.checkBoxDomingo.Text = "Domingo";
            this.checkBoxDomingo.UseVisualStyleBackColor = true;
            this.checkBoxDomingo.CheckedChanged += new System.EventHandler(this.checkBoxDomingo_CheckedChanged);
            // 
            // checkBoxSabado
            // 
            this.checkBoxSabado.AutoSize = true;
            this.checkBoxSabado.Location = new System.Drawing.Point(15, 164);
            this.checkBoxSabado.Name = "checkBoxSabado";
            this.checkBoxSabado.Size = new System.Drawing.Size(82, 21);
            this.checkBoxSabado.TabIndex = 5;
            this.checkBoxSabado.Text = "Sábado";
            this.checkBoxSabado.UseVisualStyleBackColor = true;
            this.checkBoxSabado.CheckedChanged += new System.EventHandler(this.checkBoxSabado_CheckedChanged);
            // 
            // checkBoxViernes
            // 
            this.checkBoxViernes.AutoSize = true;
            this.checkBoxViernes.Location = new System.Drawing.Point(15, 137);
            this.checkBoxViernes.Name = "checkBoxViernes";
            this.checkBoxViernes.Size = new System.Drawing.Size(83, 21);
            this.checkBoxViernes.TabIndex = 4;
            this.checkBoxViernes.Text = "Viernes";
            this.checkBoxViernes.UseVisualStyleBackColor = true;
            this.checkBoxViernes.CheckedChanged += new System.EventHandler(this.checkBoxViernes_CheckedChanged);
            // 
            // checkBoxJueves
            // 
            this.checkBoxJueves.AutoSize = true;
            this.checkBoxJueves.Location = new System.Drawing.Point(15, 110);
            this.checkBoxJueves.Name = "checkBoxJueves";
            this.checkBoxJueves.Size = new System.Drawing.Size(79, 21);
            this.checkBoxJueves.TabIndex = 3;
            this.checkBoxJueves.Text = "Jueves";
            this.checkBoxJueves.UseVisualStyleBackColor = true;
            this.checkBoxJueves.CheckedChanged += new System.EventHandler(this.checkBoxJueves_CheckedChanged);
            // 
            // checkBoxMiercoles
            // 
            this.checkBoxMiercoles.AutoSize = true;
            this.checkBoxMiercoles.Location = new System.Drawing.Point(15, 83);
            this.checkBoxMiercoles.Name = "checkBoxMiercoles";
            this.checkBoxMiercoles.Size = new System.Drawing.Size(98, 21);
            this.checkBoxMiercoles.TabIndex = 2;
            this.checkBoxMiercoles.Text = "Miércoles";
            this.checkBoxMiercoles.UseVisualStyleBackColor = true;
            this.checkBoxMiercoles.CheckedChanged += new System.EventHandler(this.checkBoxMiercoles_CheckedChanged);
            // 
            // checkBoxMartes
            // 
            this.checkBoxMartes.AutoSize = true;
            this.checkBoxMartes.Location = new System.Drawing.Point(15, 56);
            this.checkBoxMartes.Name = "checkBoxMartes";
            this.checkBoxMartes.Size = new System.Drawing.Size(77, 21);
            this.checkBoxMartes.TabIndex = 1;
            this.checkBoxMartes.Text = "Martes";
            this.checkBoxMartes.UseVisualStyleBackColor = true;
            this.checkBoxMartes.CheckedChanged += new System.EventHandler(this.checkBoxMartes_CheckedChanged);
            // 
            // checkBoxLunes
            // 
            this.checkBoxLunes.AutoSize = true;
            this.checkBoxLunes.Location = new System.Drawing.Point(15, 29);
            this.checkBoxLunes.Name = "checkBoxLunes";
            this.checkBoxLunes.Size = new System.Drawing.Size(71, 21);
            this.checkBoxLunes.TabIndex = 0;
            this.checkBoxLunes.Text = "Lunes";
            this.checkBoxLunes.UseVisualStyleBackColor = true;
            this.checkBoxLunes.CheckedChanged += new System.EventHandler(this.checkBoxLunes_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Pago por hora: $4";
            // 
            // textBoxEmpleados
            // 
            this.textBoxEmpleados.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmpleados.Location = new System.Drawing.Point(64, 155);
            this.textBoxEmpleados.Multiline = true;
            this.textBoxEmpleados.Name = "textBoxEmpleados";
            this.textBoxEmpleados.ReadOnly = true;
            this.textBoxEmpleados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxEmpleados.Size = new System.Drawing.Size(171, 154);
            this.textBoxEmpleados.TabIndex = 28;
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblRegistro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.Location = new System.Drawing.Point(400, 122);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(164, 17);
            this.lblRegistro.TabIndex = 27;
            this.lblRegistro.Text = "Registro Empleado 1:";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(102, 343);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(88, 28);
            this.btnMostrar.TabIndex = 26;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(446, 366);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(91, 28);
            this.btnCalcular.TabIndex = 25;
            this.btnCalcular.Text = "Guardar";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.Location = new System.Drawing.Point(443, 409);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(0, 16);
            this.lblEmpresa.TabIndex = 29;
            // 
            // numEmpleado
            // 
            this.numEmpleado.AutoSize = true;
            this.numEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.numEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEmpleado.Location = new System.Drawing.Point(493, 122);
            this.numEmpleado.Name = "numEmpleado";
            this.numEmpleado.Size = new System.Drawing.Size(0, 17);
            this.numEmpleado.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(622, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(719, 449);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numEmpleado);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.textBoxEmpleados);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtLunes;
        private System.Windows.Forms.TextBox txtMartes;
        private System.Windows.Forms.TextBox txtMiercoles;
        private System.Windows.Forms.TextBox txtJueves;
        private System.Windows.Forms.TextBox txtViernes;
        private System.Windows.Forms.TextBox txtSabado;
        private System.Windows.Forms.TextBox txtDomingo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxDomingo;
        private System.Windows.Forms.CheckBox checkBoxSabado;
        private System.Windows.Forms.CheckBox checkBoxViernes;
        private System.Windows.Forms.CheckBox checkBoxJueves;
        private System.Windows.Forms.CheckBox checkBoxMiercoles;
        private System.Windows.Forms.CheckBox checkBoxMartes;
        private System.Windows.Forms.CheckBox checkBoxLunes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEmpleados;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label numEmpleado;
        private System.Windows.Forms.Button button1;
    }
}

