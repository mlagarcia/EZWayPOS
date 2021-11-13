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
using EZWayPOS.Vistas.Main;

namespace EZWayPOS.Vistas
{
    public partial class FrmInicioSesion : Form
    {
        BusinessLogic.Login.LoginProvider l;
        MdiMain m;
        public FrmInicioSesion()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void FrmInicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.TxtUser.Text) || String.IsNullOrEmpty(this.TxtPwd.Text))
            {
                MessageBox.Show(this, "Usuario y contraseña son obligatorios, revise e intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.TxtUser.Focus();
            }
            else
            {
                l = new BusinessLogic.Login.LoginProvider();
                l.NombreUsuario = this.TxtUser.Text;
                l.PWD = this.TxtPwd.Text;

                if (l.InicioSesion() == true)
                {
                    if (l.flag == 1)
                    {
                        
                        m = new MdiMain(this.TxtUser.Text);
                        m.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(this, "Usuario y/o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.TxtUser.Focus();
                    }
                }
                else
                {
                    MessageBox.Show(this, "Lo sentimos, ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.TxtUser.Focus();
                }
            }
        }

        private void FrmInicioSesion_KeyDown(object sender, KeyEventArgs e)
        {
         
        }

        private void FrmInicioSesion_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void FrmInicioSesion_KeyUp(object sender, KeyEventArgs e)
        {
       
        }

        private void TxtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.BtnEntrar.PerformClick();
            }
        }
    }
}
