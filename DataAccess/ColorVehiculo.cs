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
    
    public partial class ColorVehiculo
    {
        public ColorVehiculo()
        {
            this.Vehiculo = new HashSet<Vehiculo>();
        }
    
        public int PK_ColorVehiculo { get; set; }
        public string NombreColor { get; set; }
        public string RGB { get; set; }
        public bool Active { get; set; }
    
        public virtual ICollection<Vehiculo> Vehiculo { get; set; }
    }
}
