using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZWayPOS.Vistas.MarcaVehiculo
{
    public partial class FrmEstadoVehiculo : Form
    {
        BusinessLogic.EstadoVehiculo t = new BusinessLogic.EstadoVehiculo();
        public FrmEstadoVehiculo()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            t.Estado = this.TxtEstado.Text;
            t.DetallesAdicional = this.TxtDetalleAdicional.Text;

            t.Active = true;

            if (t.AgregarEstadoVehiculo() == true)
            {
                this.TxtEstado.Clear();


                MessageBox.Show("Registro Guardado con Exito", "Estado Vehiculo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (t.AgregarEstadoVehiculo() == false)
            {
                MessageBox.Show("Ha ocurrido un error", "Estado Vehiculo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
