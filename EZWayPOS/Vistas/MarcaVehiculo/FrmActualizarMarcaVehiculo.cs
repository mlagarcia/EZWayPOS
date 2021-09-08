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
        public FrmActualizarMarcaVehiculo(string [] Valor)
        {
            InitializeComponent();
            this.txtId.Text = Valor[0]; // Mostrar Id
            this.txtId.Enabled = false;
            this.TxtMarcaVehiculo.Text = Valor[1]; // Mostrar Marca

            val.CboInit(CboPais);
            CboPais.DataSource = mv.ListadoPaises(); //Seleccionar por defecto pais de la marca
            CboPais.DisplayMember = "NombrePais";
            CboPais.ValueMember = "PK_Pais";
            //CboPais.Text = Valor[2];

            val.CboInit(CboFundacion);
            CboFundacion.DataSource = Enumerable.Range(1900, 100).ToList();
            CboFundacion.Text = Valor[3]; //Seleccionar por defecto año fundacion de la marca

        }

        private void FrmActualizarMarcaVehiculo_Load(object sender, EventArgs e)
        {
      
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (CboPais.SelectedIndex == -1)
            {
                MessageBox.Show("Error", "No es un pais valido");
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
                   
                    MessageBox.Show("Registro Guardado con Exito", "Tipo Motor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else if (mv.ActualizarMarca() == false)
                {
                    MessageBox.Show("Ha ocurrido un error", "TipoMotor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mv.PK_MarcaVehiculo = Convert.ToInt32(txtId.Text);
            mv.MarcaVehiculo1 = this.TxtMarcaVehiculo.Text;
            mv.Pais = new CatalogoPais() { PK_Pais = (int)CboPais.SelectedValue };
            mv.AnioFundacion = (int)this.CboFundacion.SelectedItem;
            mv.Active = false;

            if (mv.EliminarMarca() == true)
            {
                MessageBox.Show("Registro eliminado con Exito", "Marca Vehiculo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            else if (mv.EliminarMarca() == false)
            {
                MessageBox.Show("Ha ocurrido un error", "MarcaVehiculo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
