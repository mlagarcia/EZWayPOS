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
    
    public partial class ModeloVehiculo
    {
        public ModeloVehiculo()
        {
            this.Vehiculo = new HashSet<Vehiculo>();
        }
    
        public int PK_ModeloVehiculo { get; set; }
        public Nullable<int> FK_MarcaVehiculo { get; set; }
        public Nullable<int> FK_CuerpoVehiculo { get; set; }
        public string ModeloVehiculo1 { get; set; }
        public int ModeloAnio { get; set; }
        public Nullable<int> ModeloAnioLanzamiento { get; set; }
        public bool Active { get; set; }
    
        public virtual CuerpoVehiculo CuerpoVehiculo { get; set; }
        public virtual MarcaVehiculo MarcaVehiculo { get; set; }
        public virtual ICollection<Vehiculo> Vehiculo { get; set; }
    }
}
