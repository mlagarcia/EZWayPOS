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


namespace EZWayPOS.Vistas.Cliente
{
    public partial class FrmCliente : Form
    {
        BusinessLogic.Cliente mv = new BusinessLogic.Cliente();
        BusinessLogic.TipoCliente t = new BusinessLogic.TipoCliente();
        BusinessLogic.Controller.CommonValidations.CboValidator val = new BusinessLogic.Controller.CommonValidations.CboValidator();
        public FrmCliente()
        {
            InitializeComponent();
            CboTipoCliente.DataSource = t.ListadoTipoCliente();
            CboTipoCliente.DisplayMember = "TipoCliente1";
            CboTipoCliente.ValueMember = "PK_TipoCliente";

            CboSexo.Items.Add("Masculino");
            CboSexo.Items.Add("Femenino");
            CboSexo.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (CboTipoCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Error", "No es un cliente Valido");
            }
            else
            {
        
                mv.PrimerNombre = this.TxtPrimerNombre.Text;
                mv.PrimerApellido = this.TxtPrimerApellido.Text;
                mv.SegundoNombre = this.TxtSegundoNombre.Text;
                mv.SegundoApellido = this.TxtSegundoApellido.Text;
                mv.TipoCliente = new TipoCliente() { PK_TipoCliente = (int)CboTipoCliente.SelectedValue };
                mv.FechaNacimiento = this.FechaNacPicker.Value.Date;
                mv.Sexo = this.CboSexo.SelectedItem.ToString();
                mv.Active = true;


                if (mv.AgregarCliente() == true)
                {
                    this.TxtPrimerNombre.Clear();
                    this.TxtPrimerApellido.Clear();
                    this.TxtSegundoNombre.Clear();
                    this.TxtSegundoApellido.Clear();
                    this.CboSexo.SelectedIndex = 0;
                    this.CboTipoCliente.SelectedIndex = 0;
                    MessageBox.Show("Registro Guardado con Exito", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (mv.AgregarCliente() == false)
                {
                    MessageBox.Show("Ha ocurrido un error", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }

    private void button2_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
