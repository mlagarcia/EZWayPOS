using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace BusinessLogic
{
  public  class TipoMoneda
    {
        public int PK_TipoMoneda { get; set; }
        public string TipoMoneda1 { get; set; }
        public string Simbolo { get; set; }

        public TipoMoneda()
        {
            Init();

        }
        private void Init()
        {
            this.TipoMoneda1 = String.Empty;
            this.Simbolo = String.Empty;
        }
        public void ListadoTipoMoneda(ComboBox Cbo)
        {
            using (BDAutoloteEntities conn = new BDAutoloteEntities())
            {

                try
                {
                    var query = (from p in conn.CatalogoTipoMoneda
                                     //Filtar por registros con Active = 1

                                 select new
                                 {   //Parametros a mostrar del result de la query
                                     PK_TipoMoneda = p.PK_TipoMoneda,
                                     TipoMoneda = p.TipoMoneda + " ("+p.Simbolo+")"
                                 }
                                 ).ToList(); //Convetir de var [query] a list

                    Cbo.DataSource = query;
                    Cbo.DisplayMember = "TipoMoneda";
                    Cbo.ValueMember = "PK_TipoMoneda";
                }
                catch (Exception Ex)
                {

                }
            }
        }






    }
}
