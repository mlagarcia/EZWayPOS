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

namespace EZWayPOS.Vistas.Cliente
{
    public partial class FrmClienteViewModel : Form
    {

        BusinessLogic.Controller.DataGridValidator d;
        BusinessLogic.Cliente m = new BusinessLogic.Cliente();
        FrmActualizarCliente act;
        public FrmClienteViewModel()
        {
            InitializeComponent();
            this.MaximizeBox = false; //Para no permitir maximizar
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            m.listadoCliente(this.gridCliente);
            CboTipoBusqueda.Items.Add("Nombre");
            CboTipoBusqueda.Items.Add("Apellido");
            CboTipoBusqueda.SelectedIndex = 0;
        }


        public void FrmClienteViewModel_Load(object sender, EventArgs e)
        {
            d = new BusinessLogic.Controller.DataGridValidator(gridCliente); //Instancia a validador de Grid
                                                                             //Inicializar valores de grid [ColIndex, Header, WidthSize]
            d.GridMarcasInit(0, "ID #", 100);
            d.GridMarcasInit(1, "Tipo de Cliente", 120);
            d.GridMarcasInit(2, "Primer Nombre", 120);
            d.GridMarcasInit(3, "Segundo Nombre", 100);
            d.GridMarcasInit(4, "Primer Apellido", 120);
            d.GridMarcasInit(5, "Segundo Apellido", 100);
            d.GridMarcasInit(6, "Fecha Nacimiento", 100);
            d.GridMarcasInit(7, "Sexo", 82);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Si campo de busqueda vacio y presionan el boton entonces mostrar todos
            if (String.IsNullOrEmpty(txtCliente.Text))
            {

                m.listadoCliente(gridCliente);
            }
            //Si campo de busqueda tiene valor y presionan el boton entonces mostrar por parametro digitado
            else
            {
                if (CboTipoBusqueda.SelectedIndex == 0)
                {
                    m.listadoBuscarClienteNombre(gridCliente, this.txtCliente.Text);
                }
                else
                {
                    m.listadoBuscarClienteApellido(gridCliente, this.txtCliente.Text);
                }
            }

        }

        private void gridCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string[] valor = new string[8]; //Arreglo que almacena la fila seleccionada

            valor[0] = gridCliente.CurrentRow.Cells[0].Value != null ? gridCliente.CurrentRow.Cells[0].Value.ToString() : string.Empty;
            valor[1] = gridCliente.CurrentRow.Cells[1].Value != null ? gridCliente.CurrentRow.Cells[1].Value.ToString() : string.Empty;
            valor[2] = gridCliente.CurrentRow.Cells[2].Value != null ? gridCliente.CurrentRow.Cells[2].Value.ToString() : string.Empty;
            valor[3] = gridCliente.CurrentRow.Cells[3].Value != null ? gridCliente.CurrentRow.Cells[3].Value.ToString() : string.Empty;
            valor[4] = gridCliente.CurrentRow.Cells[4].Value != null ? gridCliente.CurrentRow.Cells[4].Value.ToString() : string.Empty;
            valor[5] = gridCliente.CurrentRow.Cells[5].Value != null ? gridCliente.CurrentRow.Cells[5].Value.ToString() : string.Empty;
            valor[6] = gridCliente.CurrentRow.Cells[6].Value != null ? gridCliente.CurrentRow.Cells[6].Value.ToString() : string.Empty;
            valor[7] = gridCliente.CurrentRow.Cells[7].Value != null ? gridCliente.CurrentRow.Cells[7].Value.ToString() : string.Empty;
            act = new FrmActualizarCliente(valor); //Fila seleccionada se pasa al constructor de la vista de actualizacion
            act.ShowDialog();


        }

        private void txtCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnBuscar.PerformClick();
            }
        }
    }
}
