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
    
    public partial class Cliente
    {
        public Cliente()
        {
            this.ContactoCliente = new HashSet<ContactoCliente>();
            this.DireccionCliente = new HashSet<DireccionCliente>();
            this.IdentificacionCliente = new HashSet<IdentificacionCliente>();
            this.VentaVehiculo = new HashSet<VentaVehiculo>();
        }
    
        public int PK_Cliente { get; set; }
        public Nullable<int> FK_TipoCliente { get; set; }
        public string PrimerNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoNombre { get; set; }
        public string SegundoApellido { get; set; }
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public bool Active { get; set; }
    
        public virtual TipoCliente TipoCliente { get; set; }
        public virtual ICollection<ContactoCliente> ContactoCliente { get; set; }
        public virtual ICollection<DireccionCliente> DireccionCliente { get; set; }
        public virtual ICollection<IdentificacionCliente> IdentificacionCliente { get; set; }
        public virtual ICollection<VentaVehiculo> VentaVehiculo { get; set; }
    }
}
