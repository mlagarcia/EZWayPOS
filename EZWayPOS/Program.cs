using EZWayPOS.Vistas.TipoVehiculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZWayPOS.Vistas.ColorVehiculo;
using EZWayPOS.Vistas.CuerpoVehiculo;
using EZWayPOS.Vistas.Main;

namespace EZWayPOS
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmTipoVehiculo());
          // Application.Run(new Color_Vehiculo());
            Application.Run(new MdiMain());
        }
    }
}
