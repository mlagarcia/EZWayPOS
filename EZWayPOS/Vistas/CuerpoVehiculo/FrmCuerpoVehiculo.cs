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

namespace EZWayPOS.Vistas.CuerpoVehiculo
{
    public partial class FrmCuerpoVehiculo : Form
    {
        BusinessLogic.CuerpoVehiculo t = new BusinessLogic.CuerpoVehiculo();
        public FrmCuerpoVehiculo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t.CuerpoVehiculo1 = this.txtCuerpoVehiculo1.Text;
            

            if (t.AgregarCuerpoVehiculo() == true)
            {
                this.txtCuerpoVehiculo1.Clear();


                MessageBox.Show("Registro Guardado con Exito", "Color Vehiculo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (t.AgregarCuerpoVehiculo() == false)
            {
                MessageBox.Show("Ha ocurrido un error", "CuerpoVehiculo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
