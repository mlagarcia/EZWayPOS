//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;  
    public partial class Vehiculo
    {
        public Vehiculo()
        {
            this.DetalleCompraVehiculo = new HashSet<DetalleCompraVehiculo>();
            this.DetalleVentaVehiculo = new HashSet<DetalleVentaVehiculo>();
        }
    
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
    
        public virtual CatalogoTipoMoneda CatalogoTipoMoneda { get; set; }
        public virtual CatalogoTipoMoneda CatalogoTipoMoneda1 { get; set; }
        public virtual CatalogoUnidadLongitud CatalogoUnidadLongitud { get; set; }
        public virtual ColorVehiculo ColorVehiculo { get; set; }
        public virtual CuerpoVehiculo CuerpoVehiculo { get; set; }
        public virtual ICollection<DetalleCompraVehiculo> DetalleCompraVehiculo { get; set; }
        public virtual ICollection<DetalleVentaVehiculo> DetalleVentaVehiculo { get; set; }
        public virtual EstadoVehiculo EstadoVehiculo { get; set; }
        public virtual ModeloVehiculo ModeloVehiculo { get; set; }
        public virtual TipoMotor TipoMotor { get; set; }
        public virtual TipoTransmision TipoTransmision { get; set; }
        public virtual TipoVehiculo TipoVehiculo { get; set; }
    }
}
