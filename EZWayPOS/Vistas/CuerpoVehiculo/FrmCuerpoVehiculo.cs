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
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtCuerpoVehiculo1.Text))
            {
                MessageBox.Show(this, "Los campos con astericos son obligatorios, revise e intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCuerpoVehiculo1.Focus();
            }
            else
            {

                t.CuerpoVehiculo1 = this.txtCuerpoVehiculo1.Text;

                if (t.AgregarCuerpoVehiculo() == true)
                {
                    this.txtCuerpoVehiculo1.Clear();


                    MessageBox.Show("Cuerpo de vehiculo guardado con éxito", "Cuerpo Vehiculo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (t.AgregarCuerpoVehiculo() == false)
                {
                    MessageBox.Show("Ha ocurrido un error", "Cuerpo Vehiculo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmCuerpoVehiculo_Load(object sender, EventArgs e)
        {

        }
    }
}
