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
        BusinessLogic.Controller.CommonValidator.CboValidator val = new BusinessLogic.Controller.CommonValidator.CboValidator();
        FrmModeloVehiculoViewModel v;
        DialogResult d;
        public FrmActualizarModeloVehiculo(string[] Valor)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            txtId.Text = Valor[0];
            this.txtId.Enabled = false;// Mostrar Id

            val.CboInit(CboMarca);
            mv.listadoMarca(CboMarca);
            CboMarca.Text = Valor[1];


            this.TxtModeloVehiculo.Text = Valor[2];

            val.CboInit(CboCuerpo);
            mv.listadoCuerpoVehiculo(CboCuerpo); //Seleccionar por defecto pais de la marca
            CboCuerpo.Text = Valor[3];

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
            if (CboMarca.SelectedIndex == -1 || CboCuerpo.SelectedIndex == -1 || CboAnioLanzamiento.SelectedIndex == -1)
            {
                MessageBox.Show("Revise las opciones seleccionadas e intente de nuevo", "Ups...ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (String.IsNullOrEmpty(this.TxtModeloVehiculo.Text))
                {
                    MessageBox.Show(this, "Los campos con astericos son obligatorios, revise e intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtModeloVehiculo.Focus();
                }
                else
                {
                    mv.PK_ModeloVehiculo = Convert.ToInt32(txtId.Text);
                    mv.ModeloVehiculo1 = this.TxtModeloVehiculo.Text;
                    mv.MarcaVehiculo = new BusinessLogic.MarcaVehiculo() { PK_MarcaVehiculo = (int)CboMarca.SelectedValue };
                    mv.CuerpoVehiculo = new BusinessLogic.CuerpoVehiculo() { PK_CuerpoVehiculo = (int)CboCuerpo.SelectedValue };
                    mv.ModeloAnioLanzamiento = (int)this.CboAnioLanzamiento.SelectedItem;
                    mv.ModeloAnio = (int)this.CboAnioLanzamiento.SelectedItem;
                    mv.Active = true;

                    if (mv.ActualizarModelo() == true)
                    {
                        MessageBox.Show("Modelo actualizado con éxito", "Modelo Vehiculo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else if (mv.ActualizarModelo() == false)
                    {
                        MessageBox.Show("Ups.. Ha ocurrido un error", "Modelo Vehiculo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            d = MessageBox.Show("Esta seguro que desea eliminar este modelo", "Eliminar modelo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
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
        }

        private void CboCuerpo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

