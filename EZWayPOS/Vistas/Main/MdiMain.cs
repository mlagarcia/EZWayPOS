using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZWayPOS.Vistas.ColorVehiculo;
using EZWayPOS.Vistas.CuerpoVehiculo;


namespace EZWayPOS.Vistas.Main
{
    public partial class MdiMain : Form
    {
        private Color_Vehiculo cv;
        private FrmCuerpoVehiculo cpv;

        private int childFormNumber = 0;

        public MdiMain()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }

        private void ShowNewForm(object sender, EventArgs e)
        {

        }


        private void MdiMain_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    client.BackColor = Color.White;
                }
            }
        }

        private void tiposDeVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cv == null)
            {
                cv = new Color_Vehiculo();
                cv.FormClosed += new FormClosedEventHandler(Cv_FormClosed);
                cv.MdiParent = this;
                cv.Show();
            }
            else
            {
                cv.WindowState = FormWindowState.Normal;
            }
        }

        private void Cv_FormClosed(object sender, FormClosedEventArgs e)
        {
            cv = null;
        }

        private void cerrarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void tipoDeVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cpv == null)
            {
                cpv = new FrmCuerpoVehiculo(); //Crear instancia de formulario
                cpv.FormClosed += new FormClosedEventHandler(Cpv_FormClosed); // Comprobar si el handler de eventos tiene cerrado el formulario
                cpv.MdiParent = this; //Agregar formulario el MDI
                cpv.Show(); //Mostrar formulario
            }
            else
            {
                cpv.WindowState = FormWindowState.Normal; //Si hay instancia de formulario mostrarlo en estado normal
            }
        }

        private void Cpv_FormClosed(object sender, FormClosedEventArgs e)
        {
            cpv = null;
        }
    }
}
