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


namespace EZWayPOS.Vistas.MarcaVehiculo
{
    public partial class FrmActualizarMarcaVehiculo : Form
    {
        BusinessLogic.MarcaVehiculo mv = new BusinessLogic.MarcaVehiculo();
        BusinessLogic.Controller.CommonValidations.CboValidator val = new BusinessLogic.Controller.CommonValidations.CboValidator();
        FrmMarcaVehiculoViewModel v;
        DialogResult d;
        public FrmActualizarMarcaVehiculo(string[] Valor)
        {
            InitializeComponent();
            this.txtId.Text = Valor[0]; // Mostrar Id
            this.txtId.Enabled = false;
            this.TxtMarcaVehiculo.Text = Valor[1]; // Mostrar Marca
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            val.CboInit(CboPais);
            CboPais.DataSource = mv.ListadoPaises(); //Seleccionar por defecto pais de la marca
            CboPais.DisplayMember = "NombrePais";
            CboPais.ValueMember = "PK_Pais";
            CboPais.Text = Valor[2];

            val.CboInit(CboFundacion);
            CboFundacion.DataSource = Enumerable.Range(1900, 100).ToList();
            CboFundacion.Text = Valor[3]; //Seleccionar por defecto año fundacion de la marca

        }

        private void FrmActualizarMarcaVehiculo_Load(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (CboPais.SelectedIndex == -1 || CboFundacion.SelectedIndex == -1)
            {
                MessageBox.Show("Revise las opciones seleccionadas e intente de nuevo", "Ups...ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (String.IsNullOrEmpty(TxtMarcaVehiculo.Text))
                {
                    MessageBox.Show(this, "Los campos con astericos son obligatorios, revise e intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtMarcaVehiculo.Focus();
                }
                else
                {
                    mv.PK_MarcaVehiculo = Convert.ToInt32(txtId.Text);
                    mv.MarcaVehiculo1 = this.TxtMarcaVehiculo.Text;
                    mv.Pais = new CatalogoPais() { PK_Pais = (int)CboPais.SelectedValue };
                    mv.AnioFundacion = (int)this.CboFundacion.SelectedItem;
                    mv.Active = true;

                    if (mv.ActualizarMarca() == true)
                    {
                        MessageBox.Show("Marca guardada con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();

                    }
                    else if (mv.ActualizarMarca() == false)
                    {
                        MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            d = MessageBox.Show("Esta seguro que desea eliminar esta marca", "Eliminar marca", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                mv.PK_MarcaVehiculo = Convert.ToInt32(txtId.Text);
                mv.MarcaVehiculo1 = this.TxtMarcaVehiculo.Text;
                mv.Pais = new CatalogoPais() { PK_Pais = (int)CboPais.SelectedValue };
                mv.AnioFundacion = (int)this.CboFundacion.SelectedItem;
                mv.Active = false;

                if (mv.EliminarMarca() == true)
                {
                    MessageBox.Show("Registro eliminado con éxito", "Marca Vehiculo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else if (mv.EliminarMarca() == false)
                {
                    MessageBox.Show("Ha ocurrido un error", "Marca Vehiculo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
