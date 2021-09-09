using System;
using System.Windows.Forms;

namespace EZWayPOS.Vistas.TipoVehiculo
{

    public partial class FrmTipoVehiculo : Form
    {
        BusinessLogic.TipoVehiculo t = new BusinessLogic.TipoVehiculo();
        public FrmTipoVehiculo()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(TxtTipoVehiculo.Text))
            {
                MessageBox.Show(this, "Los campos con astericos son obligatorios, revise e intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtTipoVehiculo.Focus();
            }
            else
            {
                t.TipoVehiculo1 = this.TxtTipoVehiculo.Text;
                t.DetallesAdicional = this.TxtDescripcion.Text;
                t.Active = true;

                if (t.agregarTipoVehiculo() == true)
                {
                    this.TxtTipoVehiculo.Clear();
                    this.TxtDescripcion.Clear();
                    MessageBox.Show("Registro Guardado con Exito", "Tipo de Vehiculo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (t.agregarTipoVehiculo() == false)
                {
                    MessageBox.Show("Ha ocurrido un error", "Tipo de Vehiculo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
