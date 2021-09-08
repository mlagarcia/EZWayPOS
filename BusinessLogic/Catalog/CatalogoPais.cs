using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
   public class CatalogoPais
    {
      
        public int PK_Pais { get; set; }
        public string NombrePais { get; set; }

        public virtual ICollection<DireccionEmpleado> DireccionEmpleado { get; set; }
        public virtual ICollection<DireccionCliente> DireccionCliente { get; set; }
        public virtual ICollection<DireccionProveedor> DireccionProveedor { get; set; }
        public virtual ICollection<DireccionAutolote> DireccionAutolote { get; set; }
        public virtual ICollection<MarcaVehiculo> MarcaVehiculo { get; set; }
    }
}
