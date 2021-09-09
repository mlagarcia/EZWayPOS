using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Windows.Forms;

namespace BusinessLogic
{
  public  class TipoTransmision
    {
        public int PK_TipoTransmision { get; set; }
        public string TipoTramsmision1{ get; set; }
        public string DetalleAdicional { get; set; }
        public bool Active { get; set; }
        public TipoTransmision()
        {
            Init();
        }
        private void Init()
        {
            this.TipoTramsmision1 = String.Empty;
            this.DetalleAdicional = String.Empty;
            this.Active = true;
        }

        public bool AgregarTipoTransmision()
        {
            using (BDAutoloteEntities conn = new BDAutoloteEntities())
            {

                try
                {
                    DataAccess.TipoTransmision t = new DataAccess.TipoTransmision();

                    t.TipoTransmision1 = this.TipoTramsmision1;
                    t.DetalleAdicional = this.DetalleAdicional;
                    t.Active = this.Active;

                    conn.TipoTransmision.Add(t);
                    conn.SaveChanges();

                    return true;
                }
                catch (Exception Ex)
                {
                    return false;
                }
            }
        }
    public void ListadoTipoTransmision (ComboBox Cbo)
    {
      using (BDAutoloteEntities conn = new BDAutoloteEntities())
      {

        try
        {
          var query = (from p in conn.TipoTransmision
                       where p.Active == true //Filtar por registros con Active = 1

                       select new
                       {   //Parametros a mostrar del result de la query
                         PK_TipoTransmision = p.PK_TipoTransmision,
                         TipoTransmision1 = p.TipoTransmision1
                       }
                       ).ToList(); //Convetir de var [query] a list

          Cbo.DataSource = query;
          Cbo.DisplayMember = "TipoTransmision1";
          Cbo.ValueMember = "PK_TipoTransmision";
        }
        catch (Exception Ex)
        {

        }
      }
    }

  }


}

