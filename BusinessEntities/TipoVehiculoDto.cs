using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class TipoVehiculoDto
    {

        public int PK_TipoVehiculo { get; set; }
        public string TipoVehiculo1 { get; set; }
        public string DetallesAdicional { get; set; }
        public bool Active { get; set; }

        public TipoVehiculoDto()
        {
        }

    }
}
