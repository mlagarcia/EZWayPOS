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
    public partial class FrmMarcaVehiculo : Form
    {
        BusinessLogic.MarcaVehiculo mv = new BusinessLogic.MarcaVehiculo();
        BusinessLogic.Controller.CommonValidator.CboValidator val = new BusinessLogic.Controller.CommonValidator.CboValidator();

        public FrmMarcaVehiculo()
        {
            InitializeComponent();
            val.CboInit(CboPais);
            CboPais.DataSource = mv.ListadoPaises();
            CboPais.DisplayMember = "NombrePais";
            CboPais.ValueMember = "PK_Pais";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            val.CboInit(CboFundacion);
            CboFundacion.DataSource = Enumerable.Range(1900, 100).ToList();
  
        }


        private void button1_Click(object sender, EventArgs e)
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
                    mv.MarcaVehiculo1 = this.TxtMarcaVehiculo.Text;
                    mv.Pais = new CatalogoPais() { PK_Pais = (int)CboPais.SelectedValue };
                    mv.AnioFundacion = (int)this.CboFundacion.SelectedItem;
                    mv.Active = true;


                    if (mv.AgregarMarcaVehiculo() == true)
                    {
                        this.TxtMarcaVehiculo.Clear();
                        this.CboFundacion.SelectedIndex = 1;
                        this.CboFundacion.SelectedIndex = 1;
                        MessageBox.Show("Registro Guardado con Exito", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (mv.AgregarMarcaVehiculo() == false)
                    {
                        MessageBox.Show("Ha ocurrido un error", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void FrmMarcaVehiculo_Load(object sender, EventArgs e)
        {
    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }



