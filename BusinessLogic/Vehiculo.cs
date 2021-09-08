using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
   public  class Vehiculo
    {
        public int PK_Vehiculo { get; set; }
        public Nullable<int> FK_ModeloVehiculo { get; set; }
        public Nullable<int> FK_CuerpoVehiculo { get; set; }
        public Nullable<int> FK_TipoTransmision { get; set; }
        public Nullable<int> FK_TipoMotor { get; set; }
        public Nullable<int> FK_ColorVehiculo { get; set; }
        public Nullable<int> FK_EstadoVehiculo { get; set; }
        public Nullable<int> FK_PrecioCompraMoneda { get; set; }
        public Nullable<int> FK_PrecioVentaMoneda { get; set; }
        public Nullable<int> FK_TipoKilometraje { get; set; }
        public int Kilometraje { get; set; }
        public string VIN { get; set; }
        public string Placa { get; set; }
        public Nullable<decimal> PrecioCompra { get; set; }
        public Nullable<decimal> PrecioVenta { get; set; }
        public bool Disponible { get; set; }
        public bool Active { get; set; }
        public Nullable<int> FK_TipoVehiculo { get; set; }


    }
}
