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
        BusinessLogic.Controller.CommonValidations.CboValidator val = new BusinessLogic.Controller.CommonValidations.CboValidator();

        public FrmMarcaVehiculo()
        {
            InitializeComponent();
            val.CboInit(CboPais);
            CboPais.DataSource = mv.ListadoPaises();
            CboPais.DisplayMember = "NombrePais";
            CboPais.ValueMember = "PK_Pais";

            val.CboInit(CboFundacion);
            CboFundacion.DataSource = Enumerable.Range(1900, 100).ToList();
  
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (CboPais.SelectedIndex == -1)
            {
                MessageBox.Show("Error","No es un pais valido");
            }
            else
            {
                mv.MarcaVehiculo1 = this.TxtMarcaVehiculo.Text;
                mv.Pais = new CatalogoPais() { PK_Pais = (int)CboPais.SelectedValue };
                mv.AnioFundacion = (int) this.CboFundacion.SelectedItem;
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

        private void FrmMarcaVehiculo_Load(object sender, EventArgs e)
        {
    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }



