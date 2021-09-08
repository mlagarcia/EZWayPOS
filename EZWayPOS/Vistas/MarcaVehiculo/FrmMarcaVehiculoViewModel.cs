using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EZWayPOS.Vistas.MarcaVehiculo
{
    public partial class FrmMarcaVehiculoViewModel : Form
    {
        BusinessLogic.Controller.DataGridValidator d;
        BusinessLogic.MarcaVehiculo m = new BusinessLogic.MarcaVehiculo();
        FrmActualizarMarcaVehiculo act;


        public FrmMarcaVehiculoViewModel()
        {
            InitializeComponent();
            this.MaximizeBox = false; //Para no permitir maximizar
            m.ListadoMarcas(gridMarcaVehiculo);

        }

        private void FrmListadoMarcaVehiculo_Load(object sender, EventArgs e)
        {
            d = new BusinessLogic.Controller.DataGridValidator(gridMarcaVehiculo); //Instancia a validador de Grid
            //Inicializar valores de grid [ColIndex, Header, WidthSize]
            d.GridMarcasInit(0, "ID #", 80);
            d.GridMarcasInit(1, "Marca", 125);
            d.GridMarcasInit(2, "País de Origen", 100);
            d.GridMarcasInit(3, "Año de Fundación", 80);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Si campo de busqueda vacio y presionan el boton entonces mostrar todos
            if (String.IsNullOrEmpty(txtMarca.Text))
            {

                m.ListadoMarcas(gridMarcaVehiculo);
            }
            //Si campo de busqueda tiene valor y presionan el boton entonces mostrar por parametro digitado
            else
            {
                m.listadoBuscarMarca(gridMarcaVehiculo, this.txtMarca.Text);
            }

        }

        private void gridMarcaVehiculo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridMarcaVehiculo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string[] valor = new string[4]; //Arreglo que almacena la fila seleccionada

            valor[0] = gridMarcaVehiculo.CurrentRow.Cells[0].Value != null ? gridMarcaVehiculo.CurrentRow.Cells[0].Value.ToString() : string.Empty;
            valor[1] = gridMarcaVehiculo.CurrentRow.Cells[1].Value != null ? gridMarcaVehiculo.CurrentRow.Cells[1].Value.ToString() : string.Empty;
            valor[2] = gridMarcaVehiculo.CurrentRow.Cells[2].Value != null ? gridMarcaVehiculo.CurrentRow.Cells[2].Value.ToString() : string.Empty;
            valor[3] = gridMarcaVehiculo.CurrentRow.Cells[3].Value != null ? gridMarcaVehiculo.CurrentRow.Cells[3].Value.ToString() : string.Empty;

            act = new FrmActualizarMarcaVehiculo(valor); //Fila seleccionada se pasa al constructor de la vista de actualizacion
            act.ShowDialog();

        }

    private void gridMarcaVehiculo_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
    {

    }
  }
}
