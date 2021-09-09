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
using EZWayPOS.Vistas.TipoMotor;
using EZWayPOS.Vistas.MarcaVehiculo;
using EZWayPOS.Vistas.ModeloVehiculo;
using EZWayPOS.Vistas.Cliente;
using EZWayPOS.Vistas.Vehiculo;
using EZWayPOS.Vistas.TipoVehiculo;

namespace EZWayPOS.Vistas.Main
{
    public partial class MdiMain : Form
    {
        private Color_Vehiculo cv;
        private FrmCuerpoVehiculo cpv;
        private FrmTipoMotor cvp;
        private FrmTipoTransmision d;
        private FrmEstadoVehiculo j;
        private FrmMarcaVehiculo marca;
        private FrmMarcaVehiculoViewModel marcaViewModel;
        private FrmModeloVehiculo mod;
        private FrmModeloVehiculoViewModel modv;
        private FrmCliente cl;
        private FrmClienteViewModel Cl1;
        private FrmVehiculo vh;
        private FrmTipoVehiculo tv;
        private FrmInicioSesion s;

        public MdiMain(String user)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = false;
            this.usuarioToolStripMenuItem.Text = "Mariela";
            this.usuarioToolStripMenuItem.Text = user;
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

        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tipoMotorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cvp == null)
            {
                cvp = new FrmTipoMotor(); //Crear instancia de formulario
                cvp.FormClosed += new FormClosedEventHandler(Cvp_FormClosed); // Comprobar si el handler de eventos tiene cerrado el formulario
                cvp.MdiParent = this; //Agregar formulario el MDI
                cvp.Show(); //Mostrar formulario
            }
            else
            {
                cvp.WindowState = FormWindowState.Normal; //Si hay instancia de formulario mostrarlo en estado normal
            }

        }

        private void Cvp_FormClosed(object sender, FormClosedEventArgs e)
        {
            cvp = null;
        }

        private void tipoTransmisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (d == null)
            {
                d = new FrmTipoTransmision(); //Crear instancia de formulario
                d.FormClosed += new FormClosedEventHandler(d_FormClosed); // Comprobar si el handler de eventos tiene cerrado el formulario
                d.MdiParent = this; //Agregar formulario el MDI
                d.Show(); //Mostrar formulario
            }
            else
            {
                d.WindowState = FormWindowState.Normal; //Si hay instancia de formulario mostrarlo en estado normal
            }

        }
        private void d_FormClosed(object sender, FormClosedEventArgs e)
        {
            d = null;
        }

        private void estadoVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (j == null)
            {
                j = new FrmEstadoVehiculo(); //Crear instancia de formulario
                j.FormClosed += new FormClosedEventHandler(j_FormClosed); // Comprobar si el handler de eventos tiene cerrado el formulario
                j.MdiParent = this; //Agregar formulario el MDI
                j.Show(); //Mostrar formulario
            }
            else
            {
                j.WindowState = FormWindowState.Normal; //Si hay instancia de formulario mostrarlo en estado normal
            }
        }

        private void j_FormClosed(object sender, FormClosedEventArgs e)
        {
            d = null;
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (marca == null)
            {
                marca = new FrmMarcaVehiculo(); //Crear instancia de formulario
                marca.FormClosed += new FormClosedEventHandler(Marca_FormClosed);// Comprobar si el handler de eventos tiene cerrado el formulario
                marca.MdiParent = this; //Agregar formulario el MDI
                marca.Show(); //Mostrar formulario
            }
            else
            {
                marca.WindowState = FormWindowState.Normal; //Si hay instancia de formulario mostrarlo en estado normal
            }
        }

        private void Marca_FormClosed(object sender, FormClosedEventArgs e)
        {
            marca = null;
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (marcaViewModel == null)
            {
                marcaViewModel = new FrmMarcaVehiculoViewModel(); //Crear instancia de formulario
                marcaViewModel.FormClosed += new FormClosedEventHandler(MarcaViewModel_FormClosed);// Comprobar si el handler de eventos tiene cerrado el formulario
                marcaViewModel.MdiParent = this; //Agregar formulario el MDI
                marcaViewModel.Show(); //Mostrar formulario
            }
            else
            {
                marcaViewModel.WindowState = FormWindowState.Normal; //Si hay instancia de formulario mostrarlo en estado normal
            }
        }

        private void MarcaViewModel_FormClosed(object sender, FormClosedEventArgs e)
        {
            marcaViewModel = null;
        }

        private void agregarModeloToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (mod == null)
            {
                mod = new FrmModeloVehiculo(); //Crear instancia de formulario
                mod.FormClosed += new FormClosedEventHandler(Mod_FormClosed); // Comprobar si el handler de eventos tiene cerrado el formulario
                mod.MdiParent = this; //Agregar formulario el MDI
                mod.Show(); //Mostrar formulario
            }
            else
            {
                mod.WindowState = FormWindowState.Normal; //Si hay instancia de formulario mostrarlo en estado normal
            }
        }

        private void Mod_FormClosed(object sender, FormClosedEventArgs e)
        {
            mod = null;
        }

        private void buscarModeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modv == null)
            {
                modv = new FrmModeloVehiculoViewModel();
                modv.FormClosed += new FormClosedEventHandler(Modv_FormClosed);
                modv.MdiParent = this;
                modv.Show();
            }
            else
            {
                modv.WindowState = FormWindowState.Normal;
            }
        }

        private void Modv_FormClosed(object sender, FormClosedEventArgs e)
        {
            modv = null;
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (cl == null)
            {
                cl = new FrmCliente();
                cl.FormClosed += new FormClosedEventHandler(Cl_FormClosed);
                cl.MdiParent = this;
                cl.Show();
            }
            else
            {
                cl.WindowState = FormWindowState.Normal;

            }
        }

        private void Cl_FormClosed(object sender, FormClosedEventArgs e)
        {
            cl = null;
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buscarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Cl1 == null)

            {
                Cl1 = new FrmClienteViewModel();
                Cl1.FormClosed += new FormClosedEventHandler(Cl1_FormClosed);
                Cl1.MdiParent = this;
                Cl1.Show();
            }
            else
            {
                Cl1.WindowState = FormWindowState.Normal;
            }
        }

        private void Cl1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cl1 = null;
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vh == null)
            {
                vh = new FrmVehiculo();
                vh.FormClosed += new FormClosedEventHandler(Vh_FormClosed);
                vh.MdiParent = this;
                vh.Show();
            }
            else 
            {
                vh.WindowState = FormWindowState.Normal;
            }
        }

        private void Vh_FormClosed(object sender, FormClosedEventArgs e)
        {
            vh = null;
           
        }

        private void tiposDeEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tiposDeVehiculoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           if (tv == null)
            {
                tv = new FrmTipoVehiculo();
                tv.FormClosed += new FormClosedEventHandler(Tv_FormClosed);
                tv.MdiParent = this;
                tv.Show();
            }else
            {
                tv.WindowState = FormWindowState.Normal;
            }
            
        }

        private void Tv_FormClosed(object sender, FormClosedEventArgs e)
        {
            tv = null;
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            s = new FrmInicioSesion();
            s.Show();
            this.Hide();
      
        }
    }
}
