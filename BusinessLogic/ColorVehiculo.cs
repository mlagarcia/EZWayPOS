using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    public void ListadoColor(ComboBox Cbo)
    {
      using (BDAutoloteEntities conn = new BDAutoloteEntities())
      {

        try
        {
          var query = (from p in conn.ColorVehiculo
                       where p.Active == true && p.NombreColor != null//Filtar por registros con Active = 1

                       select new
                       {   //Parametros a mostrar del result de la query
                         PK_ColorVehiculo = p.PK_ColorVehiculo,
                         NombreColor = p.NombreColor
                       }
                       ).ToList(); //Convetir de var [query] a list

          Cbo.DataSource = query;
          Cbo.DisplayMember = "NombreColor";
          Cbo.ValueMember = "PK_ColorVehiculo";
        }
        catch (Exception Ex)
        {

        }
      }
    }
  }
}
