using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;


namespace BusinessLogic
{
    public class TipoVehiculo
    {

        public int PK_TipoVehiculo { get; set; }
        public string TipoVehiculo1 { get; set; }
        public string DetallesAdicional { get; set; }
        public bool Active { get; set; }

        public TipoVehiculo()
        {
            Init();
        }

        private void Init()
        {
            this.TipoVehiculo1 = String.Empty;
            this.DetallesAdicional = String.Empty;
            this.Active = true;
        }


        public bool agregarTipoVehiculo()
        {
            using (BDAutoloteEntities conn = new BDAutoloteEntities())
            {

                try
                {
                    DataAccess.TipoVehiculo t = new DataAccess.TipoVehiculo();

                    t.TipoVehiculo1 = this.TipoVehiculo1;
                    t.DetallesAdicional = this.DetallesAdicional;
                    t.Active = this.Active;

                    conn.TipoVehiculo.Add(t);
                    conn.SaveChanges();

                    return true;
                }
                catch (Exception Ex)
                {
                    return false;
                }
            }
        }
        public void ListadoTipoVehiculo(ComboBox Cbo)
        {
            using (BDAutoloteEntities conn = new BDAutoloteEntities())
            {

                try
                {
                    var query = (from p in conn.TipoVehiculo
                                 where p.Active == true
                                     //Filtar por registros con Active = 1

                                 select new
                                 {   //Parametros a mostrar del result de la query
                                     PK_TipoVehiculo = p.PK_TipoVehiculo,
                                     TipoVehiculo1 = p.TipoVehiculo1
                                 }
                                 ).ToList(); //Convetir de var [query] a list

                    Cbo.DataSource = query;
                    Cbo.DisplayMember = "TipoVehiculo1";
                    Cbo.ValueMember = "PK_TipoVehiculo";
                }
                catch (Exception Ex)
                {

                }
            }
        }

    }
}
