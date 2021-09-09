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

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(this.TxtNombreColor.Text))
            {
                MessageBox.Show(this, "Los campos con astericos son obligatorios, revise e intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNombreColor.Focus();

            }
            else
            {

                t.NombreColor = this.TxtNombreColor.Text;
                t.RGB = SelectedColor.BackColor.ToArgb().ToString();

                t.Active = true;

                if (t.AgregarColorVehiculo() == true)
                {
                    this.TxtNombreColor.Clear();


                    MessageBox.Show("Color guardado con éxito", "Color Vehiculo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (t.AgregarColorVehiculo() == false)
                {
                    MessageBox.Show("Ha ocurrido un error", "Ups..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                this.SelectedColor.BackColor = this.colorDialog1.Color;

        }

        private void Color_Vehiculo_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SelectedColor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

