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
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.TxtEstado.Text))
            {
                MessageBox.Show(this, "Los campos con astericos son obligatorios, revise e intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtEstado.Focus();
            }
            else
            {
                t.Estado = this.TxtEstado.Text;
                t.DetallesAdicional = this.TxtDetalleAdicional.Text;

                t.Active = true;

                if (t.AgregarEstadoVehiculo() == true)
                {
                    this.TxtEstado.Clear();
                    this.TxtDetalleAdicional.Clear();

                    MessageBox.Show("Registro guardado con éxito", "Estado Vehiculo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (t.AgregarEstadoVehiculo() == false)
                {
                    MessageBox.Show("Ha ocurrido un error", "Estado Vehiculo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEstadoVehiculo_Load(object sender, EventArgs e)
        {

        }
    }
}
