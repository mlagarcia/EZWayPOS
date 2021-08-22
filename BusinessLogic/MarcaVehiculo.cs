using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
namespace BusinessLogic
{
  public   class MarcaVehiculo
    {
        public int PK_MarcaVehiculo { get; set; }
        public Nullable<int> FK_Pais { get; set; }
        public string MarcaVehiculo1 { get; set; }
        public Nullable<int> AnioFundacion { get; set; }
        public bool Active { get; set; }

        public MarcaVehiculo()
        {
            Init();
        }

        private void Init()
        {
            this.MarcaVehiculo1= String.Empty;

        }
        public bool AgregarMarcaVehiculo()
        {
            using (BDAutoloteEntities conn = new BDAutoloteEntities())
            {

                try
                {
                    DataAccess.MarcaVehiculo t = new DataAccess.MarcaVehiculo();

                    t.MarcaVehiculo1 = this.MarcaVehiculo1;
                    t.AnioFundacion = this.AnioFundacion;


                    conn.MarcaVehiculo.Add(t);
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
