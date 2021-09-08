using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZWayPOS.Vistas.TipoMotor
{
    public partial class FrmTipoMotor : Form
    {
        BusinessLogic.TipoMotor t = new BusinessLogic.TipoMotor();
        public FrmTipoMotor()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            t.TipoMotor1 = this.TxtTipoMotor.Text;
            t.DetalleAdicional = this.TxtDetalleAdicional.Text;

            t.Active = true;

            if (t.AgregarTipoMotor() == true)
            {
                this.TxtTipoMotor.Clear();


                MessageBox.Show("Registro Guardado con Exito", "Tipo Motor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (t.AgregarTipoMotor() == false)
            {
                MessageBox.Show("Ha ocurrido un error", "TipoMotor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
