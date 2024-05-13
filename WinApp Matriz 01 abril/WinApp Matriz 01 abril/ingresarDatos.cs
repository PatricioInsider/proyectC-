using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp_Matriz_01_abril
{
    public partial class ingresarDatos : Form
    {
        public object[] vector = new object[3];
        public ingresarDatos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            dataSet11.ReadXml("D:\\Estud.xml");
            string nombreIngresado = txtNombre.Text;
            int edad = int.Parse(comboBox1.Text);

            
            vector[1] = nombreIngresado;

            vector[2] = edad;
            dataSet11.TblEstudiantes.Rows.Add(vector);
            dataSet11.WriteXml("D:\\Estud.xml");
        }
    }
}
