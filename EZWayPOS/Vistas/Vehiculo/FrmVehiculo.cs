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
        BusinessLogic.UnidadLongitud ul = new BusinessLogic.UnidadLongitud();
        BusinessLogic.TipoVehiculo tv = new BusinessLogic.TipoVehiculo();
        BusinessLogic.TipoMoneda tmo = new BusinessLogic.TipoMoneda();
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

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CboMarca_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
