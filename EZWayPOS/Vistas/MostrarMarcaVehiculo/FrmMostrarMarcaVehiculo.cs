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
using DataAccess.DBAutolote;
using BusinessLogic.DBAutolote; 

namespace EZWayPOS.Vistas.MostrarMarcaVehiculo
{
  public partial class FrmMostrarMarcaVehiculo : Form
  {
    public FrmMostrarMarcaVehiculo()
    {
      InitializeComponent();
    }

    private void FrmMostrarMarcaVehiculo_Load(object sender, EventArgs e)
    {
      Refresh();

    }

    private void Refresh() {

      using ( DBAutoloteEntities db = new DBAutoloteEntities())

    }
  }
}
