using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compra_Interactiva_con_precios
{
    public partial class frmVehiculos : Form
    {
        private double precio;
        calcularIva ObjCalculoIva = new calcularIva();
        public frmVehiculos()
        {
            InitializeComponent();
            precio = 0;
        }

        private void rbtnLambo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnLambo.Checked == true)
            {
                pboxDeportivos.Image = Properties.Resources.Lamborghini;
                lblPrecioDeportivos.Text = "$500000";
                precio = double.Parse(lblPrecioDeportivos.Text.Substring(1));
                lblIvaDeportivos.Text = "$" + ObjCalculoIva.calculoIva(precio).ToString();
            }
        }

        private void rbtnFerrari_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFerrari.Checked == true)
            {
                pboxDeportivos.Image = Properties.Resources.Ferrari;
                lblPrecioDeportivos.Text = "$700000";
                precio = double.Parse(lblPrecioDeportivos.Text.Substring(1));
                lblIvaDeportivos.Text = "$" + ObjCalculoIva.calculoIva(precio).ToString();
            }
        }
        private void rbtnMaserati_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMaserati.Checked == true)
            {
                pboxDeportivos.Image = Properties.Resources.Maserati_gt;
                lblPrecioDeportivos.Text = "$1000000";
                precio = double.Parse(lblPrecioDeportivos.Text.Substring(1));
                lblIvaDeportivos.Text = "$" + ObjCalculoIva.calculoIva(precio).ToString();
            }
        }

        private void rbtnChery_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnChery.Checked == true)
            {
                pboxFamiliares.Image = Properties.Resources.chery;
                lblPrecioFami.Text = "$20500";
                precio = double.Parse(lblPrecioFami.Text.Substring(1));
                lblIvaFami.Text = "$" + ObjCalculoIva.calculoIva(precio).ToString();
            }
        }

        private void rbtnGroove_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnGroove.Checked == true)
            {
                pboxFamiliares.Image = Properties.Resources.chevrolet_groove;
                lblPrecioFami.Text = "$31000"; 
                precio = double.Parse(lblPrecioFami.Text.Substring(1));
                lblIvaFami.Text = "$" + ObjCalculoIva.calculoIva(precio).ToString();
            }
        }

        private void rbtnCeratoR_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCeratoR.Checked == true)
            {
                pboxFamiliares.Image = Properties.Resources.kia;
                lblPrecioFami.Text = "$19500";
                precio = double.Parse(lblPrecioFami.Text.Substring(1));
                lblIvaFami.Text = "$" + ObjCalculoIva.calculoIva(precio).ToString();
            }
        }

        private void rbtnFactory_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFactory.Checked == true)
            {
                pboxMotos.Image = Properties.Resources.factory;
                lblPrecioMotos.Text = "$2500";
                precio = double.Parse(lblPrecioMotos.Text.Substring(1));
                lblIvaMotos.Text = "$" + ObjCalculoIva.calculoIva(precio).ToString();
            }
        }

        private void rbtnDY_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDY.Checked == true)
            {
                pboxMotos.Image = Properties.Resources.daytona;
                lblPrecioMotos.Text = "$3000";
                precio = double.Parse(lblPrecioMotos.Text.Substring(1));
                lblIvaMotos.Text = "$" + ObjCalculoIva.calculoIva(precio).ToString();
            }
        }

        private void rbtnShineray_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnShineray.Checked == true)
            {
                pboxMotos.Image = Properties.Resources.moto_shineray;
                lblPrecioMotos.Text = "$3500";
                precio = double.Parse(lblPrecioMotos.Text.Substring(1));
                lblIvaMotos.Text = "$" + ObjCalculoIva.calculoIva(precio).ToString();
            }
        }

        private void rbtnFord_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFord.Checked == true)
            {
                pbox4x4.Image = Properties.Resources.ford;
                lblPrecio4x4.Text = "$35000";
                precio = double.Parse(lblPrecio4x4.Text.Substring(1));
                lblIva4x4.Text = "$" + ObjCalculoIva.calculoIva(precio).ToString();
            }
        }

        private void rbtnToyota_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnToyota.Checked == true)
            {
                pbox4x4.Image = Properties.Resources.fortuner;
                lblPrecio4x4.Text = "$45000";
                precio = double.Parse(lblPrecio4x4.Text.Substring(1));
                lblIva4x4.Text = "$" + ObjCalculoIva.calculoIva(precio).ToString();
            }
        }

        private void rbtnJeep_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnJeep.Checked == true)
            {
                pbox4x4.Image = Properties.Resources.jeep;
                lblPrecio4x4.Text = "$37000";
                precio = double.Parse(lblPrecio4x4.Text.Substring(1));
                lblIva4x4.Text = "$" + ObjCalculoIva.calculoIva(precio).ToString();
            }
        }

        private void frmVehiculos_Shown(object sender, EventArgs e)
        {
            pboxFamiliares.Image = null;
            rbtnCeratoR.Checked = false;
            rbtnJeep.Checked = false;
            rbtnGroove.Checked = false;
            rbtnFerrari.Checked = false;
            rbtnToyota.Checked = false;
            rbtnJeep.Checked = false;
            rbtnChery.Checked = false;
            rbtnDY.Checked = false;
            rbtnFactory.Checked = false;
            rbtnFord.Checked = false;
            rbtnShineray.Checked = false;
            rbtnMaserati.Checked = false;
        }

        double precioTotal = 0;
        private void CalcularPrecioTotal(double precio)
        {
            precioTotal += precio;
            lblTotalVehiculos.Text = "$" + precioTotal.ToString();
        }

        private void btnCalcularTotal_Click_1(object sender, EventArgs e)
        {
            // Reiniciar el precio total antes de calcular
            precioTotal = 0.0;

            // Verificar cada vehículo y agregar su precio al total si está seleccionado
            if (rbtnLambo.Checked)
            {
                CalcularPrecioTotal(500000);
            }
            else if (rbtnFerrari.Checked)
            {
                CalcularPrecioTotal(700000);
            }
            else if (rbtnMaserati.Checked)
            {
                CalcularPrecioTotal(1000000);
            }
            else if (rbtnChery.Checked)
            {
                CalcularPrecioTotal(20500);
            }
            else if (rbtnGroove.Checked)
            {
                CalcularPrecioTotal(31000);
            }
            else if (rbtnCeratoR.Checked)
            {
                CalcularPrecioTotal(19500);
            }
            else if (rbtnFactory.Checked)
            {
                CalcularPrecioTotal(2500);
            }
            else if (rbtnDY.Checked)
            {
                CalcularPrecioTotal(3000);
            }
            else if (rbtnShineray.Checked)
            {
                CalcularPrecioTotal(3500);
            }
            else if (rbtnFord.Checked)
            {
                CalcularPrecioTotal(35000);
            }
            else if (rbtnToyota.Checked)
            {
                CalcularPrecioTotal(45000);
            }
            else if (rbtnJeep.Checked)
            {
                CalcularPrecioTotal(37000);
            }
        }
    }
}
