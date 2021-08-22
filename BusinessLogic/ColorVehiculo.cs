using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
   public   class ColorVehiculo
    {
        public int PK_ColorVehiculo { get; set; }
        public string NombreColor { get; set; }
        public string RGB { get; set; }
        public bool Active { get; set; }
        public ColorVehiculo()
        {
            Init();
        }

        private void Init()
        {
            this.NombreColor = String.Empty;
            this.RGB = String.Empty;
            this.Active = true;
        }

        public bool AgregarColorVehiculo()
        {
            using (BDAutoloteEntities conn = new BDAutoloteEntities())
            {

                try
                {
                    DataAccess.ColorVehiculo t = new DataAccess.ColorVehiculo();

                    t.NombreColor = this.NombreColor;
                    t.RGB = this.RGB;
                    t.Active = this.Active;

                    conn.ColorVehiculo.Add(t);
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
