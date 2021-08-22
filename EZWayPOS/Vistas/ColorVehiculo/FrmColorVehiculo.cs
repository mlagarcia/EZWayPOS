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

namespace EZWayPOS.Vistas.ColorVehiculo
{
    public partial class Color_Vehiculo : Form
    {
        BusinessLogic.ColorVehiculo t = new BusinessLogic.ColorVehiculo();
        public Color_Vehiculo()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            t.NombreColor = this.TxtNombreColor.Text;
            t.RGB = SelectedColor.BackColor.ToArgb().ToString();
        
            t.Active = true;

            if (t.AgregarColorVehiculo() == true)
            {
                this.TxtNombreColor.Clear();

                
                MessageBox.Show("Registro Guardado con Exito", "Color Vehiculo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (t.AgregarColorVehiculo() == false)
            {
                MessageBox.Show("Ha ocurrido un error", "ColorVehiculo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
         if (colorDialog1.ShowDialog()==DialogResult.OK)
            this.SelectedColor.BackColor = this.colorDialog1.Color;
            
        }

        private void Color_Vehiculo_Load(object sender, EventArgs e)
        {

        }
    }
    }

