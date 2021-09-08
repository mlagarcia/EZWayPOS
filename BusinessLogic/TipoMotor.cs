using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
  public class TipoMotor
    {
        public int PK_TipoMotor { get; set; }
        public string TipoMotor1 { get; set; }
        public string DetalleAdicional { get; set; }
        public bool Active { get; set; }
        public TipoMotor()
        {
            Init();
        }
        private void Init()
        {
            this.TipoMotor1 = String.Empty;
            this.DetalleAdicional = String.Empty;
            this.Active = true;
        }
        public bool AgregarTipoMotor()
        {
            using (BDAutoloteEntities conn = new BDAutoloteEntities())
            {

                try
                {
                    DataAccess.TipoMotor t = new DataAccess.TipoMotor();

                    t.TipoMotor1 = this.TipoMotor1;
                    t.DetalleAdicional = this.DetalleAdicional;
                    t.Active = this.Active;

                    conn.TipoMotor.Add(t);
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
