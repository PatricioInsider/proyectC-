using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matriz_Valores_Numericos_Dimension
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnLimpiar.Enabled = false;
            btnCalcular.Enabled = false;
            txtfilas.KeyDown += new KeyEventHandler(TextBox_KeyDown);
            txtCol.KeyDown += new KeyEventHandler(TextBox_KeyDown);
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox currentTextBox = sender as TextBox;

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Left)
            {
                switch (currentTextBox.Name)
                {
                    case "txtfilas":
                        if (e.KeyCode == Keys.Right)
                            txtCol.Focus();
                        break;
                    case "txtCol":
                        if (e.KeyCode == Keys.Left)
                            txtfilas.Focus();
                        break;
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnConfirmDimensions_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtfilas.Text) || string.IsNullOrWhiteSpace(txtCol.Text))
            {
                MessageBox.Show("Ingrese valores para el número de filas y columnas.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rowCount, colCount;
            if (!int.TryParse(txtfilas.Text, out rowCount) || rowCount <= 0 || !int.TryParse(txtCol.Text, out colCount) || colCount <= 0)
            {
                MessageBox.Show("Ingrese números enteros positivos para el número de filas y columnas.", "Valores Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dataGridView1.Columns.Clear();
            for (int i = 0; i < colCount; i++)
            {
                dataGridView1.Columns.Add($"col{i}", $"col{i}");
            }

            dataGridView1.Rows.Clear();
            for (int i = 0; i < rowCount; i++)
            {
                dataGridView1.Rows.Add();
            }

            dataGridView1.ReadOnly = false;
            btnCalcular.Enabled = true;
            btnLimpiar.Enabled = true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                    {
                        MessageBox.Show("Llene todos los campos de la matriz para poder calcular.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    int num;
                    if (!int.TryParse(cell.Value.ToString(), out num))
                    {
                        MessageBox.Show("Ingrese solo números en la matriz.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

            int rowCount = dataGridView1.Rows.Count;
            int colCount = dataGridView1.Columns.Count;
            int positiveCount = 0;
            int negativeCount = 0;
            int totalSum = 0;
            int evenColSum = 0;
            long negativeProduct = 1;

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    int num = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value);
                    totalSum += num;
                    if (num > 0)
                        positiveCount++;
                    else if (num < 0)
                    {
                        negativeCount++;
                        negativeProduct *= num;
                    }

                    if (j % 2 == 0)
                        evenColSum += num;
                }
            }
            lblElemtPosit.Text = $"{positiveCount}";
            lblElemtNeg.Text = $"{negativeCount}";
            lblTotalSum.Text = $"{totalSum}";
            lblSumColOrPar.Text = $"{evenColSum}";
            lblMultpNumNeg.Text = $"{negativeProduct}";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtfilas.Text = "";
            txtCol.Text = "";
            lblElemtPosit.Text = "";
            lblElemtNeg.Text = "";
            lblTotalSum.Text = "";
            lblSumColOrPar.Text = "";
            lblMultpNumNeg.Text = "";
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            btnLimpiar.Enabled = false;
            btnCalcular.Enabled = false;
        }

        private void txtfilas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtCol.Focus();
                e.Handled = true;
            }
        }

        private void txtCol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnConfirmarD.Focus();
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
