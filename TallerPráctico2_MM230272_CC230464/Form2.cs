using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TallerPráctico2_MM230272_CC230464
{
    public partial class FrmBomba : TallerPráctico2_MM230272_CC230464.FrmBase
    {
        Diésel Diesel = new Diésel();
        Gasolina_Especial Especial = new Gasolina_Especial();
        Gasolina_Regular Regular = new Gasolina_Regular();

        public FrmBomba()
        {
            InitializeComponent();
        }
        //Para limpiar los textbox de nuevo precio
        private void Limipiar()
        {
            txtNuevoPrecioD.Clear();
            txtNuevoPrecioE.Clear();
            txtNuevoPrecioR.Clear();
        }
        //Cuando se despache el pedido
        private void btnSurtir_Click(object sender, EventArgs e)
        {
            if(rbtncantgalones.Checked)
            {
                if (rbtnGasEspecial.Checked)
                {
                    double galServ = Convert.ToDouble(txtcantgal.Text);
                    Especial.GalonAdolarE(galServ);
                }
                else if (rbtnGasRegular.Checked)
                {
                    double galServ = Convert.ToDouble(txtcantgal.Text);
                    Regular.GalonAdolarR(galServ);
                }
                else if (rbtnDiesel.Checked)
                {
                    double galServ = Convert.ToDouble(txtcantgal.Text);
                    Diesel.GalonAdolarD(galServ);
                }
            }
            else if(rbtncantdolares.Checked)
            {
                if (rbtnGasEspecial.Checked)
                {
                    double dolServ = Convert.ToDouble(txtcantdolares.Text);
                    double CantidadGalonesRetirada = Especial.DolarAgalonE(dolServ);
                    Especial.cantidadgalonesRE(CantidadGalonesRetirada);
                }
                else if (rbtnGasRegular.Checked)
                {
                    double dolServ = Convert.ToDouble(txtcantdolares.Text);
                    Regular.DolarAgalonR(dolServ);
                }
                else if (rbtnDiesel.Checked)
                {
                    double dolServ = Convert.ToDouble(txtcantdolares.Text);
                    Diesel.DolarAgalonD(dolServ);
                }
            }

        }
        //Cuando se haga un nuevo pedido
        private void btnNuevoLlenado_Click(object sender, EventArgs e)
        {
            txtcantgal.Clear();
            txtcantgal.ReadOnly = true;
            txtcantdolares.Clear();
            txtcantdolares.ReadOnly = true;
            rbtncantgalones.Checked = false;
            rbtncantdolares.Checked = false;
            rbtnGasEspecial.Checked = false;
            rbtnGasRegular.Checked = false;
            rbtnDiesel.Checked = false;
        }
        //Cuando se modifiquen los precios de la gasolina
        private void btnModificar_Click(object sender, EventArgs e)
        {
            double nuevoPrecioE = Convert.ToDouble(txtNuevoPrecioE.Text);
            double nuevoPrecioR = Convert.ToDouble(txtNuevoPrecioR.Text);
            double nuevoPrecioD = Convert.ToDouble(txtNuevoPrecioD.Text);
            Especial.ModificarPrecioE(nuevoPrecioE);
            Regular.ModificarPrecioR(nuevoPrecioR);
            Diesel.ModificarPrecioD(nuevoPrecioD);
            label1.Text = "$" + nuevoPrecioE.ToString();
            label2.Text = "$" + nuevoPrecioR.ToString();
            label3.Text = "$" + nuevoPrecioD.ToString();
            Limipiar();
        }
        //Cuando se quiera consultar los precios de la gasolina
        private void btnVerPrecios_Click(object sender, EventArgs e)
        {

        }
        //Cuando se inicie el programa
        private void FrmBomba_Load(object sender, EventArgs e)
        {
            double precioInicialE = Especial.PrecioInicialE();
            label1.Text = "$" + precioInicialE.ToString();
            double precioInicialR = Regular.PrecioInicialR();
            label2.Text = "$" + precioInicialR.ToString();
            double precioInicialD = Diesel.PrecioInicialD();
            label3.Text = "$" + precioInicialD.ToString();
            double galonesMaxE = Especial.cantidadgalonesRE(CantidadGalonesRetirada);
            label5.Text = galonesMaxE.ToString() + " galones";
            double galonesMaxR = Regular.CantidadMaxGalonesR();
            label7.Text = galonesMaxR.ToString() + " galones";
            double galonesMaxD = Diesel.CantidadMaxGalonesD();
            label9.Text = galonesMaxD.ToString() + " galones";

        }
        //Para llenar bomba
        private void btnLlenarBomba_Click(object sender, EventArgs e)
        {

        }
        //Cuando se despache en galones
        private void rbtncantgalones_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtncantgalones.Checked == true)
            {
                txtcantgal.ReadOnly = false;
                txtcantdolares.ReadOnly = true;
            }
        }

        private void rbtncantdolares_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtncantdolares.Checked == true)
            {
                txtcantgal.ReadOnly = true;
                txtcantdolares.ReadOnly = false;
            }
        }
    }
}
