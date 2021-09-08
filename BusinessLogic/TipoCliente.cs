using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class TipoCliente
    {

        public int PK_TipoCliente { get; set; }
        public string TipoCliente1 { get; set; }
        public bool Active { get; set; }

        private BDAutoloteEntities conn;
        public TipoCliente(){

            conn = new BDAutoloteEntities();
        }

        public IEnumerable<object> ListadoTipoCliente()
        {
            try
            {
                return conn.TipoCliente.ToList();
            }
            catch (Exception Ex)
            {
                return null;
            }


        }



    }
}
