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
    public partial class FrmModeloVehiculoViewModel : Form
    {
        BusinessLogic.Controller.DataGridValidator d;
        BusinessLogic.ModeloVehiculo m = new BusinessLogic.ModeloVehiculo();
        FrmActualizarModeloVehiculo act;


        public FrmModeloVehiculoViewModel()
        {
            InitializeComponent();
            this.MaximizeBox = false; //Para no permitir maximizar
            m.ListadoModelo(this.gridModeloVehiculo);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
        private void FrmListadoMarcaVehiculo_Load(object sender, EventArgs e)
        {
            
        }

        private void FrmModeloVehiculoViewModel_Load(object sender, EventArgs e)
        {
            d = new BusinessLogic.Controller.DataGridValidator(gridModeloVehiculo); //Instancia a validador de Grid
                                                                                    //Inicializar valores de grid [ColIndex, Header, WidthSize]
            d.GridMarcasInit(0, "ID #", 80);
            d.GridMarcasInit(1, "Marca", 130);
            d.GridMarcasInit(2, "Modelo", 150);
            d.GridMarcasInit(3, "Cuerpo de Vehículo", 200);
            d.GridMarcasInit(4, "Año de Lanzamiento", 140);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Si campo de busqueda vacio y presionan el boton entonces mostrar todos
            if (String.IsNullOrEmpty(txtModelo.Text))
            {

                m.ListadoModelo(gridModeloVehiculo);
            }
            //Si campo de busqueda tiene valor y presionan el boton entonces mostrar por parametro digitado
            else
            {
                m.listadoBuscarModelo(gridModeloVehiculo, this.txtModelo.Text);
            }

        }

        private void gridModeloVehiculo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void gridModeloVehiculo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridModeloVehiculo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string[] valor = new string[5]; //Arreglo que almacena la fila seleccionada

            valor[0] = gridModeloVehiculo.CurrentRow.Cells[0].Value != null ? gridModeloVehiculo.CurrentRow.Cells[0].Value.ToString() : string.Empty;
            valor[1] = gridModeloVehiculo.CurrentRow.Cells[1].Value != null ? gridModeloVehiculo.CurrentRow.Cells[1].Value.ToString() : string.Empty;
            valor[2] = gridModeloVehiculo.CurrentRow.Cells[2].Value != null ? gridModeloVehiculo.CurrentRow.Cells[2].Value.ToString() : string.Empty;
            valor[3] = gridModeloVehiculo.CurrentRow.Cells[3].Value != null ? gridModeloVehiculo.CurrentRow.Cells[3].Value.ToString() : string.Empty;
            valor[4] = gridModeloVehiculo.CurrentRow.Cells[4].Value != null ? gridModeloVehiculo.CurrentRow.Cells[4].Value.ToString() : string.Empty;

            act = new FrmActualizarModeloVehiculo(valor); //Fila seleccionada se pasa al constructor de la vista de actualizacion
            act.ShowDialog();
        }

        private void txtModelo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtModelo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnBuscar.PerformClick();
            }
        }
    }
}

