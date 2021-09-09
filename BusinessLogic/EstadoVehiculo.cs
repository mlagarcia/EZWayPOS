using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace BusinessLogic
{
   public class EstadoVehiculo
    {
        public int PK_EstadoVehiculo { get; set; }
        public string Estado { get; set; }
        public string DetallesAdicional { get; set; }
        public bool Active { get; set; }
        public EstadoVehiculo()
        {
            Init();
        }
        private void Init()
        {
            this.Estado = String.Empty;
            this.DetallesAdicional = String.Empty;
            this.Active = true;
        }
        public bool AgregarEstadoVehiculo()
        {
            using (BDAutoloteEntities conn = new BDAutoloteEntities())
            {

                try
                {
                    DataAccess.EstadoVehiculo t = new DataAccess.EstadoVehiculo();

                    t.Estado = this.Estado;
                    t.DetallesAdicional = this.DetallesAdicional;
                    t.Active = this.Active;

                    conn.EstadoVehiculo.Add(t);
                    conn.SaveChanges();

                    return true;
                }
                catch (Exception Ex)
                {
                    return false;
                }
            }
        }

    public void ListadoEstado(ComboBox Cbo)
    {
      using (BDAutoloteEntities conn = new BDAutoloteEntities())
      {

        try
        {
          var query = (from p in conn.EstadoVehiculo
                       where p.Active == true //Filtar por registros con Active = 1

                       select new
                       {   //Parametros a mostrar del result de la query
                         PK_EstadoVehiculo = p.PK_EstadoVehiculo,
                         Estado = p.Estado
                       }
                       ).ToList(); //Convetir de var [query] a list

          Cbo.DataSource = query;
          Cbo.DisplayMember = "Estado";
          Cbo.ValueMember = "PK_EstadoVehiculo";
        }
        catch (Exception Ex)
        {

        }
      }
    }


  }
}
