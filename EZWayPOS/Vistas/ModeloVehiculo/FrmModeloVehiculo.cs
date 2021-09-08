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

namespace EZWayPOS.Vistas.ModeloVehiculo
{
    public partial class FrmModeloVehiculo : Form
    {
        BusinessLogic.ModeloVehiculo m = new BusinessLogic.ModeloVehiculo();
        BusinessLogic.Controller.CommonValidations.CboValidator val = new BusinessLogic.Controller.CommonValidations.CboValidator();

        public FrmModeloVehiculo()
        {
            InitializeComponent();
            val.CboInit(CboMarca);
            m.listadoMarca(CboMarca);
            val.CboInit(CboCuerpo);
            m.listadoCuerpoVehiculo(CboCuerpo);
            val.CboInit(CboLanzamiento);
            CboLanzamiento.DataSource = Enumerable.Range(1930, 100).ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (CboMarca.SelectedIndex == -1)
            {
                MessageBox.Show("Error", "No es una marca valida");
            }
            else
            {
                m.ModeloVehiculo1 = this.TxtModelo.Text;
                m.MarcaVehiculo = new BusinessLogic.MarcaVehiculo() { PK_MarcaVehiculo = (int)CboMarca.SelectedValue };
                m.CuerpoVehiculo = new BusinessLogic.CuerpoVehiculo() { PK_CuerpoVehiculo = (int)CboCuerpo.SelectedValue };
                m.ModeloAnio = (int)this.CboLanzamiento.SelectedItem;
                m.ModeloAnioLanzamiento = (int)this.CboLanzamiento.SelectedItem;

                m.Active = true;


                if (m.AgregarModeloVehiculo() == true)
                {
                    this.TxtModelo.Clear();
                    this.CboMarca.SelectedIndex = 1;
                    this.CboLanzamiento.SelectedIndex = 1;
                    this.CboCuerpo.SelectedIndex = 1;
                    MessageBox.Show("Registro Guardado con Exito", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (m.AgregarModeloVehiculo() == false)
                {
                    MessageBox.Show("Ha ocurrido un error", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    private void button2_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
