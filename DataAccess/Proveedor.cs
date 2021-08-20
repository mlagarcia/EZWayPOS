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
    
    public partial class Proveedor
    {
        public Proveedor()
        {
            this.CompraVehiculo = new HashSet<CompraVehiculo>();
            this.ContactoProveedor = new HashSet<ContactoProveedor>();
            this.DireccionProveedor = new HashSet<DireccionProveedor>();
            this.IdentificacionProveedor = new HashSet<IdentificacionProveedor>();
        }
    
        public int PK_Proveedor { get; set; }
        public Nullable<int> FK_TipoProveedor { get; set; }
        public string PrimerNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoNombre { get; set; }
        public string SegundoApellido { get; set; }
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public bool Active { get; set; }
    
        public virtual ICollection<CompraVehiculo> CompraVehiculo { get; set; }
        public virtual ICollection<ContactoProveedor> ContactoProveedor { get; set; }
        public virtual ICollection<DireccionProveedor> DireccionProveedor { get; set; }
        public virtual ICollection<IdentificacionProveedor> IdentificacionProveedor { get; set; }
        public virtual TipoProveedor TipoProveedor { get; set; }
    }
}
