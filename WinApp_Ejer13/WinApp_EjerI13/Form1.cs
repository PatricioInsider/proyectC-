using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp_EjerI13
{
    public partial class Form1 : Form
    {
        int numero, horaLunes, horaMartes, horaMiercoles, horaJueves, horaViernes, horaSabado, horaDomingo;
        //string numEmpleado;
        //const int MaxEmpleados = 50;
        ClEmpleado[] empleados = new ClEmpleado[50];
        int numeroEmpleados = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            Lbl2.Visible = false;
            btnCalcular.Visible = false;
            btnMostrar.Visible = false;
            lblRegistro.Visible = false;
        }
        private void TxtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    numero = int.Parse(TxtNumero.Text);
                    if (numero < 1)
                    {
                        MessageBox.Show("Ingrese un número positivo", "ERROR", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        TxtNumero.Clear();
                    }
                    else
                    {
                        groupBox1.Visible = true;
                        groupBox2.Visible = true;
                        Lbl2.Visible = true;
                        btnCalcular.Visible = true;
                        btnMostrar.Visible = true;
                        lblRegistro.Visible = true;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ingrese números enteros", "ERROR", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                TxtNumero.Clear();
            }
        }

        private void checkBoxLunes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLunes.Checked)
            {
                txtLunes.Enabled = true;
                txtLunes.Focus();
            }
            else
            {
                txtLunes.Enabled = false;
                txtLunes.Clear();
                horaLunes = 0;
            }
        }

      

        private void checkBoxMartes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMartes.Checked)
            {
                txtMartes.Enabled = true;
                txtMartes.Focus();
            }
            else
            {
                txtMartes.Enabled = false;
                txtMartes.Clear();
                horaMartes = 0;
            }
        }

        private void checkBoxMiercoles_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMiercoles.Checked)
            {
                txtMiercoles.Enabled = true;
                txtMiercoles.Focus();
            }
            else
            {
                txtMiercoles.Enabled = false;
                txtMiercoles.Clear();
                horaMiercoles = 0;
            }
        }

        private void checkBoxJueves_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxJueves.Checked)
            {
                txtJueves.Enabled = true;
                txtJueves.Focus();
            }
            else
            {
                txtJueves.Enabled = false;
                txtJueves.Clear();
                horaJueves = 0;
            }
        }


        private void checkBoxViernes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxViernes.Checked)
            {
                txtViernes.Enabled = true;
                txtViernes.Focus();
            }
            else
            {
                txtViernes.Enabled = false;
                txtViernes.Clear();
                horaViernes = 0;
            }
        }

        private void checkBoxSabado_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSabado.Checked)
            {
                txtSabado.Enabled = true;
                txtSabado.Focus();
            }
            else
            {
                txtSabado.Enabled = false;
                txtSabado.Clear();
                horaSabado = 0;
            }
        }

        private void checkBoxDomingo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDomingo.Checked)
            {
                txtDomingo.Enabled = true;
                txtDomingo.Focus();
            }
            else
            {
                txtDomingo.Enabled = false;
                txtDomingo.Clear();
                horaDomingo = 0;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidarEntrada(TextBox textBox, int minValor, int maxValor)
        {
            try
            {
                int valor = int.Parse(textBox.Text);
                if (valor < minValor || valor > maxValor)
                {
                    MessageBox.Show($"Ingrese un número válido entre {minValor} y {maxValor}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Clear();
                    return false;
                }
                return true;
            }
            catch
            {
                MessageBox.Show("Ingrese un número válido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
                return false;
            }
        }

        private void txtLunes_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtLunes.Text, out int valor) && ValidarEntrada(txtLunes, 1, 24))
            {
                horaLunes = valor;
                checkBoxMartes.Focus();
            }
        }

        private void txtMartes_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtMartes.Text, out int valor) && ValidarEntrada(txtMartes, 1, 24))
            {
                horaMartes = valor;
                checkBoxMiercoles.Focus();
            }
        }




        private void inicializar()
        {
            txtLunes.Clear();
            txtMartes.Clear();
            txtMiercoles.Clear();
            txtJueves.Clear();
            txtViernes.Clear();
            txtSabado.Clear();
            txtDomingo.Clear();
            checkBoxLunes.Checked = false;
            checkBoxMartes.Checked = false;
            checkBoxMiercoles.Checked = false;
            checkBoxJueves.Checked = false;
            checkBoxViernes.Checked = false;
            checkBoxSabado.Checked = false;
            checkBoxDomingo.Checked = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (numeroEmpleados < numero)
            {
                ClEmpleado empleado = new ClEmpleado(horaLunes, horaMartes, horaMiercoles, horaJueves, horaViernes, horaSabado, horaDomingo);
                empleados[numeroEmpleados] = empleado;
                numeroEmpleados++;
                string aux = ($"Registro Empleado: {numeroEmpleados + 1} $");
                lblRegistro.Text = aux.ToString();
                inicializar();
            }
            else
            {
                btnCalcular.Enabled = false; // Deshabilitar el botón
                inicializar();
                MessageBox.Show($"Se ha alcanzado el límite máximo de empleados ({numero}).", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MostrarSueldos()
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder sc = new StringBuilder();
            int totalAPagar = 0;
            // Calcular y mostrar el sueldo de cada empleado
            for (int i = 0; i < numeroEmpleados; i++)
            {
                
                int sueldo = empleados[i].CalcularSueldo();
                totalAPagar += sueldo;
                sb.AppendLine($"Empleado {i + 1}:  {sueldo} $");
                
            }
            sc.AppendLine($"La empresa debe pagar en total {totalAPagar} $");
            // Mostrar los sueldos en un control de texto
            textBoxEmpleados.Text = sb.ToString();
            lblEmpresa.Text = sc.ToString();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarSueldos();
        }
    }
}
