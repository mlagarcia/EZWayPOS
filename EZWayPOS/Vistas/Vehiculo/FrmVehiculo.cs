using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace EZWayPOS.Vistas.Vehiculo
{
    public partial class FrmVehiculo : Form

    {
        BusinessLogic.Controller.CommonValidations.CboValidator cv = new BusinessLogic.Controller.CommonValidations.CboValidator();
        BusinessLogic.MarcaVehiculo mv = new BusinessLogic.MarcaVehiculo();
        BusinessLogic.ModeloVehiculo mvl = new BusinessLogic.ModeloVehiculo();
        BusinessLogic.TipoTransmision tp = new BusinessLogic.TipoTransmision();
        BusinessLogic.TipoMotor tm = new BusinessLogic.TipoMotor();
        BusinessLogic.ColorVehiculo co = new BusinessLogic.ColorVehiculo();
        BusinessLogic.EstadoVehiculo es = new BusinessLogic.EstadoVehiculo();
        BusinessLogic.CatalogoUnidadLongitud ul = new BusinessLogic.CatalogoUnidadLongitud();
        BusinessLogic.TipoVehiculo tv = new BusinessLogic.TipoVehiculo();
        BusinessLogic.CatalogoTipoMoneda tmo = new BusinessLogic.CatalogoTipoMoneda();
        BusinessLogic.Vehiculo v = new BusinessLogic.Vehiculo();
        public FrmVehiculo()
        {
            InitializeComponent();
            cv.CboInit(CboMarca);
            mv.ListadoMarcasCbo(CboMarca);
            CboMarca.SelectedIndex = 0;
            mvl.ListadoModeloPorMarca((int)CboMarca.SelectedValue, CboModelo);
            CboMarca.SelectedIndexChanged += CboMarca_SelectedIndexChanged;


            tp.ListadoTipoTransmision(CboTipo);
            CboTipo.SelectedIndex = 0;


            tm.ListadoMotor(CboMotor);
            CboMotor.SelectedIndex = 0;


            co.ListadoColor(CboColor);
            CboColor.SelectedIndex = 0;


            es.ListadoEstado(CboEstado);
            CboEstado.SelectedIndex = 0;


            ul.ListadoUnidad(CboUnidad);
            CboUnidad.SelectedIndex = 0;

            tv.ListadoTipoVehiculo(CboTipoV);
            CboTipoV.SelectedIndex = 0;

            tmo.ListadoTipoMoneda(CboCompra);
            CboCompra.SelectedIndex = 0;


            tmo.ListadoTipoMoneda(CboVenta);
            CboVenta.SelectedIndex = 0;

            RdSi.Checked = true;

        }

        private void CboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboMarca.SelectedIndex >= 0)
            {
                mvl.ListadoModeloPorMarca((int)CboMarca.SelectedValue, CboModelo);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CboMarca.SelectedIndex == -1)
            {
                MessageBox.Show("No es una Marca Valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (String.IsNullOrEmpty(TxtPlaca.Text) || String.IsNullOrEmpty(TxtVIN.Text) || String.IsNullOrEmpty(TxtKm.Text))
                {
                    MessageBox.Show(this, "Los campos con astericos son obligatorios, revise e intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtPlaca.Focus();
                }
                else
                {
                    v.ColorVehiculo = new BusinessLogic.ColorVehiculo() { PK_ColorVehiculo = (int)CboColor.SelectedValue };
                    v.EstadoVehiculo = new BusinessLogic.EstadoVehiculo() { PK_EstadoVehiculo = (int)CboEstado.SelectedValue };
                    v.ModeloVehiculo = new BusinessLogic.ModeloVehiculo() { PK_ModeloVehiculo = (int)CboModelo.SelectedValue };
                    v.EstadoVehiculo = new BusinessLogic.EstadoVehiculo() { PK_EstadoVehiculo = (int)CboEstado.SelectedValue };
                    v.CatalogoUnidadLongitud = new BusinessLogic.CatalogoUnidadLongitud() { PK_UnidadLongitud = (int)CboUnidad.SelectedValue };
                    v.TipoTransmision = new BusinessLogic.TipoTransmision() { PK_TipoTransmision = (int)CboTipo.SelectedValue };
                    v.TipoTransmision = new BusinessLogic.TipoTransmision() { PK_TipoTransmision = (int)CboTipo.SelectedValue };
                    v.CatalogoTipoMoneda = new BusinessLogic.CatalogoTipoMoneda() { PK_TipoMoneda = (int)CboCompra.SelectedValue };
                    v.CatalogoTipoMoneda1 = new BusinessLogic.CatalogoTipoMoneda() { PK_TipoMoneda = (int)CboVenta.SelectedValue };
                    v.CatalogoTipoMoneda = new BusinessLogic.CatalogoTipoMoneda() { PK_TipoMoneda = (int)CboCompra.SelectedValue };
                    v.TipoVehiculo = new BusinessLogic.TipoVehiculo() { PK_TipoVehiculo = (int)CboTipoV.SelectedValue };
                    v.TipoMotor = new BusinessLogic.TipoMotor() { PK_TipoMotor = (int)CboMotor.SelectedValue };
                    v.Placa = TxtPlaca.Text;
                    v.VIN = TxtVIN.Text;
                    v.Active = true;

                    if (String.IsNullOrEmpty(TxtPrecioCompra.Text))
                    {
                        v.PrecioCompra = 0;
                    }
                    else
                    {
                        v.PrecioCompra = Convert.ToDecimal(TxtPrecioCompra.Text);
                    }

                    if (String.IsNullOrEmpty(TxtPrecioVenta.Text))
                    {
                        v.PrecioVenta = 0;
                    }
                    else
                    {
                        v.PrecioVenta = Convert.ToDecimal(TxtPrecioVenta.Text);
                    }

                    if (String.IsNullOrEmpty(TxtKm.Text))
                    {
                        v.Kilometraje = 0;
                    }
                    else
                    {
                        v.Kilometraje = Convert.ToInt32(TxtKm.Text);
                    }

                    if (RdSi.Checked == true)
                    {
                        v.Disponible = true;
                    }
                    else
                    {
                        v.Disponible = false;

                    }

                    if (v.AgregarVehiculo() == true)
                    {
                        MessageBox.Show("Vehiculo guardado con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CboMarca.SelectedIndex = 0;
                        CboColor.SelectedIndex = 0;
                        CboModelo.SelectedIndex = 0;
                        CboMotor.SelectedIndex = 0;
                        this.CboEstado.SelectedIndex = 0;
                        this.CboTipo.SelectedIndex = 0;
                        this.CboUnidad.SelectedIndex = 0;
                        this.CboVenta.SelectedIndex = 0;
                        this.CboCompra.SelectedIndex = 0;
                        this.CboTipoV.SelectedIndex = 0;
                        this.TxtKm.Clear();
                        this.TxtPlaca.Clear();
                        this.TxtVIN.Clear();
                        this.TxtPrecioCompra.Clear();
                        this.TxtPrecioVenta.Clear();
                        this.RdSi.Checked = true;
                    }
                    else if (v.AgregarVehiculo() == false)
                    {
                        MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CboMarca_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void TxtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TxtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TxtKm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
