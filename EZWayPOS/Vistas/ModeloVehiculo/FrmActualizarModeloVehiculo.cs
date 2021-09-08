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

namespace EZWayPOS.Vistas.ModeloVehiculo
{
    public partial class FrmActualizarModeloVehiculo : Form
    {
        BusinessLogic.ModeloVehiculo mv = new BusinessLogic.ModeloVehiculo();
        BusinessLogic.Controller.CommonValidations.CboValidator val = new BusinessLogic.Controller.CommonValidations.CboValidator();
        FrmModeloVehiculoViewModel v;
        public FrmActualizarModeloVehiculo(string[] Valor)
        {
            InitializeComponent();
            txtId.Text = Valor[0];
            this.txtId.Enabled = false;// Mostrar Id

            val.CboInit(CboMarca);
            mv.listadoMarca(CboMarca);
            CboMarca.Text = Valor[1];

           
            this.TxtModeloVehiculo.Text = Valor[2];

            val.CboInit(CboCuerpo);
            mv.listadoCuerpoVehiculo(CboCuerpo); //Seleccionar por defecto pais de la marca
            CboCuerpo.Text=Valor[3];

            val.CboInit(CboAnioLanzamiento);
            CboAnioLanzamiento.DataSource = Enumerable.Range(1900, 200).ToList();
            CboAnioLanzamiento.Text = Valor[4]; //Seleccionar por defecto año fundacion de la marca

        }

        public object Valor { get; }

        private void FrmActualizarModeloVehiculo_Load(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (CboCuerpo.SelectedIndex == -1)
            {
                MessageBox.Show("Error", "No es un cuerpo vehiculo Valido valido");
            }
            else
            {
                mv.PK_ModeloVehiculo = Convert.ToInt32(txtId.Text);
                mv.ModeloVehiculo1 = this.TxtModeloVehiculo.Text;
                mv.MarcaVehiculo = new BusinessLogic.MarcaVehiculo() { PK_MarcaVehiculo = (int)CboMarca.SelectedValue };
                mv.CuerpoVehiculo = new BusinessLogic.CuerpoVehiculo() { PK_CuerpoVehiculo = (int)CboCuerpo.SelectedValue };
                mv.ModeloAnioLanzamiento = (int)this.CboAnioLanzamiento.SelectedItem;
                mv.ModeloAnio= (int)this.CboAnioLanzamiento.SelectedItem;
                mv.Active = true;

                if (mv.ActualizarModelo() == true)
                {
                    MessageBox.Show("Registro Guardado con Exito", "Tipo Motor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else if (mv.ActualizarModelo() == false)
                {
                    MessageBox.Show("Ha ocurrido un error", "ModeloVehiculo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mv.PK_ModeloVehiculo = Convert.ToInt32(txtId.Text);
            mv.ModeloVehiculo1 = this.TxtModeloVehiculo.Text;
            mv.MarcaVehiculo = new BusinessLogic.MarcaVehiculo() { PK_MarcaVehiculo = (int)CboMarca.SelectedValue };
            mv.CuerpoVehiculo = new BusinessLogic.CuerpoVehiculo() { PK_CuerpoVehiculo = (int)CboCuerpo.SelectedValue };
            mv.ModeloAnioLanzamiento = (int)this.CboAnioLanzamiento.SelectedItem;
            mv.ModeloAnio = (int)this.CboAnioLanzamiento.SelectedItem;
            mv.Active = false;

            if (mv.EliminarModelo() == true)
            {
                MessageBox.Show("Registro eliminado con Exito", "Tipo Motor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            else if (mv.EliminarModelo() == false)
            {
                MessageBox.Show("Ha ocurrido un error", "ModeloVehiculo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    private void CboCuerpo_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
  }
    }

