using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compra_Interactiva_con_precios
{
    public partial class frmRopa : Form
    {
        public frmRopa()
        {
            InitializeComponent();
        }


        private void cbxZapatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            double precio = 0;

            calcularIva ObjCalculoIva = new calcularIva();
            switch (cbxZapatos.SelectedIndex)
            {
                case 0:
                    pbxZapatos.Image = Properties.Resources.jordan_1;
                    lblPrecioZaps.Text = "$299,99";
                    precio = double.Parse(lblPrecioZaps.Text.Substring(1));
                    ivaZaps.Text = "$" + ObjCalculoIva.calculoIva(precio).ToString();
                    break;
                case 1:
                    pbxZapatos.Image = Properties.Resources.zapato_vestir;
                    lblPrecioZaps.Text = "$99,99";
                    precio = double.Parse(lblPrecioZaps.Text.Substring(1));
                    ivaZaps.Text = "$" + ObjCalculoIva.calculoIva(precio).ToString();
                    break;
                case 2:
                    pbxZapatos.Image = Properties.Resources.zapatillas;
                    lblPrecioZaps.Text = "$59,99";
                    precio = double.Parse(lblPrecioZaps.Text.Substring(1));
                    ivaZaps.Text = "$" + ObjCalculoIva.calculoIva(precio).ToString();
                    break;
                case 3:
                    pbxZapatos.Image = Properties.Resources.sandalias;
                    lblPrecioZaps.Text = "$29,99";
                    precio = double.Parse(lblPrecioZaps.Text.Substring(1));
                    ivaZaps.Text = "$" + ObjCalculoIva.calculoIva(precio).ToString();
                    break;
            }
        }

        private void cbxChamarras_SelectedIndexChanged(object sender, EventArgs e)
        {
            double precio = 0;
            calcularIva ObjCalculoIva = new calcularIva();
            switch (cbxChamarras.SelectedIndex)
            {
                //Chamarra cuero
                case 0:
                    pbxChamarras.Image = Properties.Resources.chamarra_cuero;
                    lblPrecioChamarra.Text = "$59,99";
                    precio = double.Parse(lblPrecioChamarra.Text.Substring(1));
                    ivaChamarra.Text = "$" + ObjCalculoIva.calculoIva(precio).ToString();
                    break;
                //Chamarra deportiva
                case 1: pbxChamarras.Image = Properties.Resources.chamarra_deportiva;
                    lblPrecioChamarra.Text = "$49,99";
                    precio = double.Parse(lblPrecioChamarra.Text.Substring(1));
                    ivaChamarra.Text = "$" + ObjCalculoIva.calculoIva(precio).ToString();
                    break;
                //Chamarra acolchada
                case 2:
                    pbxChamarras.Image = Properties.Resources.Chaleco_Alcochado;
                    lblPrecioChamarra.Text = "$39,99";
                    precio = double.Parse(lblPrecioChamarra.Text.Substring(1));
                    ivaChamarra.Text = "$" + ObjCalculoIva.calculoIva(precio).ToString();
                    break;
                //Chamarra biker
                case 3:
                    pbxChamarras.Image = Properties.Resources.chamarra_biker;
                    lblPrecioChamarra.Text = "$89,99";
                    precio = double.Parse(lblPrecioChamarra.Text.Substring(1));
                    ivaChamarra.Text = "$" + ObjCalculoIva.calculoIva(precio).ToString();
                    break;
                //Chamarra americana
                case 4:
                    pbxChamarras.Image = Properties.Resources.chaqueta_americana;
                    lblPrecioChamarra.Text = "$69,99";
                    precio = double.Parse(lblPrecioChamarra.Text.Substring(1));
                    ivaChamarra.Text = "$" + ObjCalculoIva.calculoIva(precio).ToString();
                    break;
            }
        }

        private void cbxPants_SelectedIndexChanged(object sender, EventArgs e)
        {
            double precio = 0;
            calcularIva ObjCalculoIva = new calcularIva();

            switch (cbxPants.SelectedIndex)
            {
                case 0:
                    pbxPants.Image = Properties.Resources.jeans;
                    lblPrecioPants.Text = "$49,99";
                    precio = double.Parse(lblPrecioPants.Text.Substring(1));
                    ivaPants.Text = "$" + ObjCalculoIva.calculoIva(precio).ToString();
                    break;
                case 1:
                    pbxPants.Image = Properties.Resources.pants_cargo;
                    lblPrecioPants.Text = "$39,99";
                    precio = double.Parse(lblPrecioPants.Text.Substring(1));
                    ivaPants.Text = "$" + ObjCalculoIva.calculoIva(precio).ToString();
                    break;
                case 2:
                    pbxPants.Image = Properties.Resources.pants_deportivos;
                    lblPrecioPants.Text = "$29,99";
                    precio = double.Parse(lblPrecioPants.Text.Substring(1));
                    ivaPants.Text = "$" + ObjCalculoIva.calculoIva(precio).ToString();
                    break;
                case 3:
                    pbxPants.Image = Properties.Resources.pants_vestir;
                    lblPrecioPants.Text = "$69,99";
                    precio = double.Parse(lblPrecioPants.Text.Substring(1));
                    ivaPants.Text = "$" + ObjCalculoIva.calculoIva(precio).ToString();
                    break;
            }
        }

        private void cbxTorso_SelectedIndexChanged(object sender, EventArgs e)
        {
            double precio = 0;
            calcularIva ObjCalculoIva = new calcularIva();
            switch (cbxTorso.SelectedIndex)
            {
                case 0:
                    pbxTorso.Image = Properties.Resources.camiseta;
                    lblPrecioTorso.Text = "$19,99";
                    precio = double.Parse(lblPrecioTorso.Text.Substring(1));
                    ivaTorso.Text = "$" + ObjCalculoIva.calculoIva(precio).ToString();
                    break;
                case 1:
                    pbxTorso.Image = Properties.Resources.camisa_polo;
                    lblPrecioTorso.Text = "$29,99";
                    precio = double.Parse(lblPrecioTorso.Text.Substring(1));
                    ivaTorso.Text = "$" + ObjCalculoIva.calculoIva(precio).ToString();
                    break;
                case 2:
                    pbxTorso.Image = Properties.Resources.camisa_vestir;
                    lblPrecioTorso.Text = "$39,99";
                    precio = double.Parse(lblPrecioTorso.Text.Substring(1));
                    ivaTorso.Text = "$" + ObjCalculoIva.calculoIva(precio).ToString();
                    break;
                case 3:
                    pbxTorso.Image = Properties.Resources.sudadera;
                    lblPrecioTorso.Text = "$59,99";
                    precio = double.Parse(lblPrecioTorso.Text.Substring(1));
                    ivaTorso.Text = "$" + ObjCalculoIva.calculoIva(precio).ToString();
                    break;
                case 4:
                    pbxTorso.Image = Properties.Resources.bividi;
                    lblPrecioTorso.Text = "$19,99";
                    precio = double.Parse(lblPrecioTorso.Text.Substring(1));
                    ivaTorso.Text = "$" + ObjCalculoIva.calculoIva(precio).ToString();
                    break;
                case 5:
                    pbxTorso.Image = Properties.Resources.camiseta_sin_manga;
                    lblPrecioTorso.Text = "$15,99";
                    precio = double.Parse(lblPrecioTorso.Text.Substring(1));
                    ivaTorso.Text = "$" + ObjCalculoIva.calculoIva(precio).ToString();
                    break;
                case 6:
                    pbxTorso.Image = Properties.Resources.jersey;
                    lblPrecioTorso.Text = "$99,99";
                    precio = double.Parse(lblPrecioTorso.Text.Substring(1));
                    ivaTorso.Text = "$" + ObjCalculoIva.calculoIva(precio).ToString();
                    break;
            }
        }


        private void btnCalcularTotal_Click(object sender, EventArgs e)
        {
            lblPrecioTotal.Text = string.Empty;

            double precioChamarras, precioPants, precioZaps, precioTors;
            double cantidadChamsNum, cantidadPantalonesNum, cantidadZapatosNum, cantidadTorsNum;

            string cantidadChamStr = cantidadChamarras.Text;
            string cantidadPantalonesStr = cantidadPants.Text;
            string cantidadZapatosStr = cantidadZaps.Text;
            string cantidadTorsStr = cantidadTorso.Text;

            precioChamarras = double.Parse(ivaChamarra.Text.Substring(1));
            precioPants = double.Parse(ivaPants.Text.Substring(1));
            precioZaps = double.Parse(ivaZaps.Text.Substring(1));
            precioTors = double.Parse(ivaTorso.Text.Substring(1));

            cantidadChamsNum = double.Parse(cantidadChamStr);
            cantidadPantalonesNum = double.Parse(cantidadPantalonesStr);
            cantidadZapatosNum = double.Parse(cantidadZapatosStr);
            cantidadTorsNum = double.Parse(cantidadTorsStr);

            double totalPant = precioPants * cantidadPantalonesNum;
            double totalCham = precioChamarras * cantidadChamsNum;
            double totalTors = precioTors * cantidadTorsNum;
            double totalZaps = precioZaps * cantidadZapatosNum;

            double total = totalPant + totalCham + totalTors + totalZaps;

            lblPrecioTotal.Text = total.ToString();
        }

        private void frmRopa_Shown(object sender, EventArgs e)
        {
            cantidadZaps.Value = 1;
            cantidadTorso.Value = 1;
            cantidadChamarras.Value = 1;
            cantidadPants.Value = 1;
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compra exitosa");
        }
    }
}