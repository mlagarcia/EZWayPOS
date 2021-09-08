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
    }
}
