using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
namespace BusinessLogic
{
  public class CuerpoVehiculo
    {
        public int PK_CuerpoVehiculo { get; set; }
        public string CuerpoVehiculo1 { get; set; }

        public CuerpoVehiculo()
        {
            Init();
        }

        private void Init()
        {
            this.CuerpoVehiculo1 = String.Empty;
           
        }

        public bool AgregarCuerpoVehiculo()
        {
            using (BDAutoloteEntities conn = new BDAutoloteEntities())
            {

                try
                {
                    DataAccess.CuerpoVehiculo t = new DataAccess.CuerpoVehiculo();

                    t.CuerpoVehiculo1 = this.CuerpoVehiculo1;
                    

                    conn.CuerpoVehiculo.Add(t);
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
