using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;



namespace BusinessLogic
{
    public class Vehiculo
    {
        BDAutoloteEntities conn;
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

        public CatalogoTipoMoneda CatalogoTipoMoneda { get; set; }
        public CatalogoTipoMoneda CatalogoTipoMoneda1 { get; set; }
        public CatalogoUnidadLongitud CatalogoUnidadLongitud { get; set; }
        public ColorVehiculo ColorVehiculo { get; set; }
        public CuerpoVehiculo CuerpoVehiculo { get; set; }
        public EstadoVehiculo EstadoVehiculo { get; set; }
        public ModeloVehiculo ModeloVehiculo { get; set; }
        public TipoMotor TipoMotor { get; set; }
        public TipoTransmision TipoTransmision { get; set; }
        public TipoVehiculo TipoVehiculo { get; set; }
        public Vehiculo()
        {
            conn = new BDAutoloteEntities();
            Init();
        }

        public void Init()
        {
            this.Kilometraje = 0;
            this.Placa = string.Empty;
            this.VIN = string.Empty;
            this.Disponible = true;
            this.Active = true;
            this.PrecioCompra = 0;
            this.PrecioVenta = 0;

        }
        public bool AgregarVehiculo()
        {
            using (BDAutoloteEntities conn = new BDAutoloteEntities())
            {
                try
                {
                    DataAccess.Vehiculo t = new DataAccess.Vehiculo();
                    t.FK_ColorVehiculo = this.ColorVehiculo.PK_ColorVehiculo;
                    t.FK_EstadoVehiculo = this.EstadoVehiculo.PK_EstadoVehiculo;
                    t.FK_ModeloVehiculo = this.ModeloVehiculo.PK_ModeloVehiculo;
                    t.FK_TipoKilometraje = this.CatalogoUnidadLongitud.PK_UnidadLongitud;
                    t.FK_TipoTransmision = this.TipoTransmision.PK_TipoTransmision;
                    t.FK_PrecioCompraMoneda = this.CatalogoTipoMoneda.PK_TipoMoneda;
                    t.PrecioCompra = this.PrecioCompra;
                    t.FK_PrecioVentaMoneda = this.CatalogoTipoMoneda1.PK_TipoMoneda;
                    t.PrecioVenta = this.PrecioVenta;
                    t.FK_TipoVehiculo = this.TipoVehiculo.PK_TipoVehiculo;
                    t.FK_TipoMotor = this.TipoMotor.PK_TipoMotor;
                    t.Kilometraje = this.Kilometraje;
                    t.Placa = this.Placa;
                    t.VIN = this.VIN;
                    t.Disponible = this.Disponible;
                    t.Active = true;

                    conn.Vehiculo.Add(t);
                    conn.SaveChanges();

                    return true;
                }
                catch (Exception Ex)
                {
                    return false;
                }
            }

        }
    }



}
