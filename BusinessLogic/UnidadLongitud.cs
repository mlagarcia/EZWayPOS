using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace BusinessLogic
{
  public class UnidadLongitud
  {
    public int PK_UnidadLongitud { get; set; }
    public string TipoLongitud { get; set; }
    public string Abreviatura { get; set; }

    public UnidadLongitud () {
      Init();

    }
    private void Init()
    {
      this.TipoLongitud = String.Empty;
      this.Abreviatura = String.Empty;
    }

    public void ListadoUnidad(ComboBox Cbo)
    {
      using (BDAutoloteEntities conn = new BDAutoloteEntities())
      {

        try
        {
          var query = (from p in conn.CatalogoUnidadLongitud
                        //Filtar por registros con Active = 1

                       select new
                       {   //Parametros a mostrar del result de la query
                         PK_UnidadLongitud = p.PK_UnidadLongitud,
                         TipoLongitud= p.TipoLongitud
                       }
                       ).ToList(); //Convetir de var [query] a list

          Cbo.DataSource = query;
          Cbo.DisplayMember = "TipoLongitud";
          Cbo.ValueMember = "PK_UnidadLongitud";
        }
        catch (Exception Ex)
        {

        }
      }
    }


  }
}
