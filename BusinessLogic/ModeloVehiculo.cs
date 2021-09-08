using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Windows.Forms;
using System.Data;
using System.Data.Objects.SqlClient;

namespace BusinessLogic
{
    public class ModeloVehiculo
    {

        public int PK_ModeloVehiculo { get; set; }
        public string ModeloVehiculo1 { get; set; }
        public int ModeloAnio { get; set; }
        public int? ModeloAnioLanzamiento { get; set; }
        public bool Active { get; set; }

        public CuerpoVehiculo CuerpoVehiculo { get; set; }
        public MarcaVehiculo MarcaVehiculo { get; set; }


        private BDAutoloteEntities conn;
        public ModeloVehiculo()
        {
            Init();
        }
        private void Init()
        {
            this.ModeloVehiculo1 = string.Empty;
            this.ModeloAnio = 1999;
            this.Active = true;
            conn = new BDAutoloteEntities();
        }

        #region ModeloVehiculoInterfaces 
        public bool AgregarModeloVehiculo()
        {
            using (BDAutoloteEntities conn = new BDAutoloteEntities())
            {
                try
                {
                    DataAccess.ModeloVehiculo t = new DataAccess.ModeloVehiculo();
                    t.ModeloVehiculo1 = this.ModeloVehiculo1;
                    t.FK_CuerpoVehiculo = this.CuerpoVehiculo.PK_CuerpoVehiculo;
                    t.FK_MarcaVehiculo = this.MarcaVehiculo.PK_MarcaVehiculo;
                    t.ModeloAnio = this.ModeloAnio;
                    t.ModeloAnioLanzamiento = this.ModeloAnioLanzamiento;
                    t.Active = true;

                    conn.ModeloVehiculo.Add(t);
                    conn.SaveChanges();

                    return true;
                }
                catch (Exception Ex)
                {
                    return false;
                }
            }

        }

        public bool ActualizarModelo()

        {
            using (BDAutoloteEntities conn = new BDAutoloteEntities())
            {
                try
                {
                    DataAccess.ModeloVehiculo t = new DataAccess.ModeloVehiculo();
                    t.PK_ModeloVehiculo = this.PK_ModeloVehiculo;
                    t.ModeloVehiculo1 = this.ModeloVehiculo1;
                    t.FK_CuerpoVehiculo = this.CuerpoVehiculo.PK_CuerpoVehiculo;
                    t.FK_MarcaVehiculo = this.MarcaVehiculo.PK_MarcaVehiculo;
                    t.ModeloAnio = this.ModeloAnio;
                    t.ModeloAnioLanzamiento = this.ModeloAnioLanzamiento;
                    t.Active = true;

                    conn.ModeloVehiculo.Attach(t);
                    conn.Entry(t).State = EntityState.Modified;
                    conn.SaveChanges();

                    return true;
                }
                catch (Exception Ex)
                {
                    return false;
                }

            }

        }

        public bool EliminarModelo()

        {
            using (BDAutoloteEntities conn = new BDAutoloteEntities())
            {
                try
                {
                    DataAccess.ModeloVehiculo t = new DataAccess.ModeloVehiculo();
                    t.PK_ModeloVehiculo = this.PK_ModeloVehiculo;
                    t.ModeloVehiculo1 = this.ModeloVehiculo1;
                    t.FK_CuerpoVehiculo = this.CuerpoVehiculo.PK_CuerpoVehiculo;
                    t.FK_MarcaVehiculo = this.MarcaVehiculo.PK_MarcaVehiculo;
                    t.ModeloAnio = this.ModeloAnio;
                    t.ModeloAnioLanzamiento = this.ModeloAnioLanzamiento;
                    t.Active = this.Active;

                    conn.ModeloVehiculo.Attach(t);
                    conn.Entry(t).Property(x => x.Active).IsModified = true;
                    conn.SaveChanges();

                    return true;
                }
                catch (Exception Ex)
                {
                    return false;
                }

            }

        }

        public void listadoBuscarModelo(DataGridView data, String ModeloBuscar)
        {
            using (BDAutoloteEntities conn = new BDAutoloteEntities())
            {

                try
                {
                    var query = (from m in conn.ModeloVehiculo
                                 join p in conn.CuerpoVehiculo
                                 on m.FK_CuerpoVehiculo equals p.PK_CuerpoVehiculo
                                 join mr in conn.MarcaVehiculo
                                 on m.FK_MarcaVehiculo equals mr.PK_MarcaVehiculo//Join de MarcaVehiculo con CatalogoPais
                                 where m.Active == true //Filtar por registros con Active = 1
                                 && m.ModeloVehiculo1.ToLower().StartsWith(ModeloBuscar.ToLower())
                                 //Convertir parametro y campo a minuscula para poder comparar el contenido

                                 select new
                                 {   //Parametros a mostrar del result de la query
                                     PK_ModeloVehiculo = m.PK_ModeloVehiculo,
                                     MarcaVehiculo = mr.MarcaVehiculo1,
                                     ModeloVehiculo1 = m.ModeloVehiculo1,
                                     CuerpoVehiculo = p.CuerpoVehiculo1,
                                     ModeloAnioLanzamiento = m.ModeloAnioLanzamiento,

                                 }
                                 ).ToList(); //Convetir de var [query] a list

                    data.DataSource = query; //Pasar list a DataGridView
                }
                catch (Exception Ex)
                {

                }

            }
        }

        public void listadoCuerpoVehiculo(ComboBox cbo)
        {
            using (conn = new BDAutoloteEntities())
            {
                try
                {
                    var query = (from m in conn.CuerpoVehiculo

                                 select new
                                 {   //Parametros a mostrar del result de la query
                                     PK_CuerpoVehiculo = m.PK_CuerpoVehiculo,
                                     CuerpoVehiculo1 = m.CuerpoVehiculo1
                                 }
                                 ).ToList(); //Convetir de var [query] a list

                    cbo.DataSource = query;
                    cbo.DisplayMember = "CuerpoVehiculo1";
                    cbo.ValueMember = "PK_CuerpoVehiculo";
                }
                catch (Exception Ex)
                {

                }

            }
        }

        public void listadoMarca(ComboBox cbo)
        {
            using (conn = new BDAutoloteEntities())
            {
                try
                {
                    var query = (from m in conn.MarcaVehiculo
                                 where m.Active == true

                                 select new
                                 {   //Parametros a mostrar del result de la query
                                     PK_MarcaVehiculo = m.PK_MarcaVehiculo,
                                     MarcaVehiculo1 = m.MarcaVehiculo1
                                 }
                                 ).ToList(); //Convetir de var [query] a list

                    cbo.DataSource = query;
                    cbo.DisplayMember = "MarcaVehiculo1"; //Nombre de la columna en el modelo
                    cbo.ValueMember = "PK_MarcaVehiculo";
                }
                catch (Exception Ex)
                {

                }

            }
        }

        public void ListadoModelo(DataGridView data)
        {
            using (BDAutoloteEntities conn = new BDAutoloteEntities())
            {

                try
                {
                    var query = (from m in conn.ModeloVehiculo
                                 join p in conn.CuerpoVehiculo on m.FK_CuerpoVehiculo equals p.PK_CuerpoVehiculo
                                 join mr in conn.MarcaVehiculo on m.FK_MarcaVehiculo equals mr.PK_MarcaVehiculo
                                 where m.Active == true //Filtar por registros con Active = 1

                                 select new
                                 {   //Parametros a mostrar del result de la query
                                     PK_ModeloVehiculo = m.PK_ModeloVehiculo,
                                     MarcaVehiculo = mr.MarcaVehiculo1,
                                     ModeloVehiculo1 = m.ModeloVehiculo1,
                                     CuerpoVehiculo = p.CuerpoVehiculo1,
                                     ModeloAnioLanzamiento = m.ModeloAnioLanzamiento,
                                 }
                                 ).ToList(); //Convetir de var [query] a list

                    data.DataSource = query; //Pasar list a DataGridView
                }
                catch (Exception Ex)
                {

                }


            }
        }


        public void ListadoModeloPorMarca(int IdMarca, ComboBox Cbo)
        {
            using (BDAutoloteEntities conn = new BDAutoloteEntities())
            {

                try
                {
                    var query = (from m in conn.ModeloVehiculo
                                 join p in conn.CuerpoVehiculo on m.FK_CuerpoVehiculo equals p.PK_CuerpoVehiculo
                                 join mr in conn.MarcaVehiculo on m.FK_MarcaVehiculo equals mr.PK_MarcaVehiculo
                                 where m.Active == true //Filtar por registros con Active = 1
                                 && m.FK_MarcaVehiculo==IdMarca

                                 select new
                                 {   //Parametros a mostrar del result de la query
                                     PK_ModeloVehiculo = m.PK_ModeloVehiculo,
                                     ModeloVehiculo1 = m.ModeloVehiculo1+" - Año: "+ (SqlFunctions.StringConvert((double)m.ModeloAnio).Trim()) + " ["+p.CuerpoVehiculo1+ "]"
                                 }
                                 ).ToList(); //Convetir de var [query] a list

                    Cbo.DataSource = query;
                    Cbo.DisplayMember = "ModeloVehiculo1";
                    Cbo.ValueMember = "PK_ModeloVehiculo";
                }
                catch (Exception Ex)
                {

                }


            }
        }

        #endregion ModeloVehiculoInterfaces 


    }

}
