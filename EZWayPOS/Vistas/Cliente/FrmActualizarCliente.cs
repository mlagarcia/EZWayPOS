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
using EZWayPOS.Vistas.Main;

namespace EZWayPOS.Vistas.Cliente
{
    public partial class FrmActualizarCliente : Form
    {
        BusinessLogic.Cliente mv = new BusinessLogic.Cliente();
        BusinessLogic.Controller.CommonValidator.CboValidator val = new BusinessLogic.Controller.CommonValidator.CboValidator();
        BusinessLogic.TipoCliente t = new BusinessLogic.TipoCliente();
        FrmClienteViewModel v;
        DialogResult d;
        MdiMain m;
        public FrmActualizarCliente(string[] Valor)
        {
            InitializeComponent();
            txtId.Text = Valor[0];
            this.txtId.Enabled = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Text = "Actualizar Cliente: "+ Valor[2];

            CboTipoCliente.DataSource = t.ListadoTipoCliente();
            CboTipoCliente.DisplayMember = "TipoCliente1";
            CboTipoCliente.ValueMember = "PK_TipoCliente";
            CboTipoCliente.Text = Valor[1];

            this.TxtPrimerNombre.Text = Valor[2];
            this.TxtSegundoNombre.Text = Valor[3];
            this.TxtPrimerApellido.Text = Valor[4];
            this.TxtSegundoApellido.Text = Valor[5];
            this.FechaNacPicker.Text = Valor[6];

            CboSexo.Items.Add("Masculino");
            CboSexo.Items.Add("Femenino");
            CboSexo.Text = Valor[7]; //Seleccionar por defecto año fundacion de la marca
        }

        private void FrmActualizarCliente_Load(object sender, EventArgs e)
        {

        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtPrimerNombre.Text) || String.IsNullOrEmpty(TxtPrimerApellido.Text))
            {
                MessageBox.Show(this, "Los campos con astericos son obligatorios, revise e intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtPrimerNombre.Focus();
            }
            else
            {
                mv.PK_Cliente = Convert.ToInt32(txtId.Text);
                mv.PrimerNombre = this.TxtPrimerNombre.Text;
                mv.SegundoNombre = this.TxtSegundoNombre.Text;
                mv.PrimerApellido = this.TxtPrimerApellido.Text;
                mv.SegundoApellido = this.TxtSegundoApellido.Text;
                mv.FechaNacimiento = this.FechaNacPicker.Value.Date;
                mv.Sexo = this.CboSexo.Text;
                mv.TipoCliente = new BusinessLogic.TipoCliente() { PK_TipoCliente = (int)CboTipoCliente.SelectedValue };
                mv.Active = true;

                if (mv.ActualizarCliente() == true)
                {
                    MessageBox.Show("Client actualizado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if (mv.ActualizarCliente() == false)
                {
                    MessageBox.Show("Ha ocurrido un error", "Ups..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            d = MessageBox.Show("Esta seguro que desea eliminar este cliente", "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (d == DialogResult.Yes)
            {
                mv.PK_Cliente = Convert.ToInt32(txtId.Text);
                mv.PrimerNombre = this.TxtPrimerNombre.Text;
                mv.SegundoNombre = this.TxtSegundoNombre.Text;
                mv.PrimerApellido = this.TxtPrimerApellido.Text;
                mv.SegundoApellido = this.TxtSegundoApellido.Text;
                mv.FechaNacimiento = this.FechaNacPicker.Value.Date;
                mv.Sexo = this.CboSexo.Text;
                mv.TipoCliente = new BusinessLogic.TipoCliente() { PK_TipoCliente = (int)CboTipoCliente.SelectedValue };
                mv.Active = false;

                if (mv.EliminarCliente() == true)
                {
                    MessageBox.Show("Cliente eliminado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else if (mv.EliminarCliente() == false)
                {
                    MessageBox.Show("Ha ocurrido un error", "Ups..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
