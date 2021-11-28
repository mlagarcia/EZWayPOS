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
        BusinessLogic.Controller.CommonValidator.CboValidator val = new BusinessLogic.Controller.CommonValidator.CboValidator();
        public FrmCliente()
        {
            InitializeComponent();

            tt.SetToolTip(this.TxtPrimerNombre, "Ingrese primer nombre");
            
            CboTipoCliente.DataSource = t.ListadoTipoCliente();
            CboTipoCliente.DisplayMember = "TipoCliente1";
            CboTipoCliente.ValueMember = "PK_TipoCliente";

            CboSexo.Items.Add("Masculino");
            CboSexo.Items.Add("Femenino");
            CboSexo.SelectedIndex = 0;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
          
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty (TxtPrimerNombre.Text) || String.IsNullOrEmpty(TxtPrimerApellido.Text))
            {
                MessageBox.Show(this,"Los campos con astericos son obligatorios, revise e intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtPrimerNombre.Focus();
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
                    MessageBox.Show("Cliente guardado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (mv.AgregarCliente() == false)
                {
                    MessageBox.Show("Ha ocurrido un error", "Ups..", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
