using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EZWayPOS.Vistas
{
    public partial class FrmTipoTransmision : Form
    {
        BusinessLogic.TipoTransmision t = new BusinessLogic.TipoTransmision();
        public FrmTipoTransmision()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            t.TipoTramsmision1 = this.TxtTipoTransmision.Text;
            t.DetalleAdicional = this.TxtDetalleAdicional.Text;

            t.Active = true;

            if (t.AgregarTipoTransmision() == true)
            {
                this.TxtTipoTransmision.Clear();


                MessageBox.Show("Registro Guardado con Exito", "Tipo Transmision", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (t.AgregarTipoTransmision() == false)
            {
                MessageBox.Show("Ha ocurrido un error", "Tipo Transmision", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    private void FrmTipoTransmision_Load(object sender, EventArgs e)
    {

    }
  }
}
