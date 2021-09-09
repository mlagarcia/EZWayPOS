using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    public void ListadoMotor(ComboBox Cbo)
    {
      using (BDAutoloteEntities conn = new BDAutoloteEntities())
      {

        try
        {
          var query = (from p in conn.TipoMotor
                       where p.Active == true //Filtar por registros con Active = 1

                       select new
                       {   //Parametros a mostrar del result de la query
                         PK_TipoMotor = p.PK_TipoMotor,
                         TipoMotor1 = p.TipoMotor1
                       }
                       ).ToList(); //Convetir de var [query] a list

          Cbo.DataSource = query;
          Cbo.DisplayMember = "TipoMotor1";
          Cbo.ValueMember = "PK_TipoMotor";
        }
        catch (Exception Ex)
        {

        }
      }
    }


  }
}
