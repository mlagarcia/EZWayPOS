using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;


namespace BusinessLogic
{
    public class MarcaVehiculo
    {

        public int PK_MarcaVehiculo { get; set; }
        public CatalogoPais Pais { get; set; }
        public string MarcaVehiculo1 { get; set; }
        public int? AnioFundacion { get; set; }
        public bool Active { get; set; }

        private BDAutoloteEntities conn;



    public MarcaVehiculo()
        {
            Init();
        }

        private void Init()
        {
            this.MarcaVehiculo1 = String.Empty;
            this.AnioFundacion = 1999;
            this.Active = true;
            conn = new BDAutoloteEntities();

        }

        #region MarcaVehiculoInterfaces 
        public bool AgregarMarcaVehiculo()
        {
            using (BDAutoloteEntities conn = new BDAutoloteEntities())
            {
                try
                {
                    DataAccess.MarcaVehiculo t = new DataAccess.MarcaVehiculo();
                    t.MarcaVehiculo1 = this.MarcaVehiculo1;
                    t.FK_Pais = this.Pais.PK_Pais;
                    t.AnioFundacion = this.AnioFundacion;
                    t.Active = true;

                    conn.MarcaVehiculo.Add(t);
                    conn.SaveChanges();

                    return true;
                }
                catch (Exception Ex)
                {
                    return false;
                }
            }
        }

        public bool ActualizarMarca()

        {
            using (BDAutoloteEntities conn = new BDAutoloteEntities())
            {
                try
                {
                    DataAccess.MarcaVehiculo t = new DataAccess.MarcaVehiculo();
                    t.PK_MarcaVehiculo = this.PK_MarcaVehiculo;
                    t.MarcaVehiculo1 = this.MarcaVehiculo1;
                    t.FK_Pais = this.Pais.PK_Pais;
                    t.AnioFundacion = this.AnioFundacion;
                    t.Active = true;
                    
                    conn.MarcaVehiculo.Attach(t);
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

        public bool EliminarMarca()

        {
            using (BDAutoloteEntities conn = new BDAutoloteEntities())
            {
                try
                {
                    DataAccess.MarcaVehiculo t = new DataAccess.MarcaVehiculo();
                    t.PK_MarcaVehiculo = this.PK_MarcaVehiculo;
                    t.MarcaVehiculo1 = this.MarcaVehiculo1;
                    t.FK_Pais = this.Pais.PK_Pais;
                    t.AnioFundacion = this.AnioFundacion;
                    t.Active = this.Active;


                    conn.MarcaVehiculo.Attach(t);
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
        public IEnumerable<object> ListadoPaises()
        {
            try
            {
                return conn.CatalogoPais.ToList();
            }
            catch (Exception Ex)
            {
                return null;
            }

        }

        public IEnumerable<object> DetallePais(string Pais)
        {
            using (BDAutoloteEntities conn = new BDAutoloteEntities())
            {
                try
                {
                    var query = (from p in conn.CatalogoPais
                                 where p.NombrePais == Pais
                                 select p).ToList(); //Convetir de var [query] a list
                    return query;
                }
                catch (Exception Ex)
                {
                    return null;
                }
            }
        }


        public void ListadoMarcas(DataGridView data)
        {
            using (BDAutoloteEntities conn = new BDAutoloteEntities())
            {

                try
                {
                    var query = (from m in conn.MarcaVehiculo
                                 join p in conn.CatalogoPais
                                 on m.FK_Pais equals p.PK_Pais //Join de MarcaVehiculo con CatalogoPais
                                 where m.Active == true //Filtar por registros con Active = 1

                                 select new
                                 {   //Parametros a mostrar del result de la query
                                     PK_MarcaVehiculo = m.PK_MarcaVehiculo,
                                     MarcaVehiculo1 = m.MarcaVehiculo1,
                                     Pais = p.NombrePais,
                                     AnioFundacion = m.AnioFundacion
                                 }
                                 ).ToList(); //Convetir de var [query] a list

                    data.DataSource = query; //Pasar list a DataGridView
                }
                catch (Exception Ex)
                {

                }


            }
        }

        public void ListadoMarcasCbo(ComboBox Cbo)
        {
            using (BDAutoloteEntities conn = new BDAutoloteEntities())
            {

                try
                {
                    var query = (from m in conn.MarcaVehiculo
                                 join p in conn.CatalogoPais
                                 on m.FK_Pais equals p.PK_Pais //Join de MarcaVehiculo con CatalogoPais
                                 where m.Active == true //Filtar por registros con Active = 1

                                 select new
                                 {   //Parametros a mostrar del result de la query
                                     PK_MarcaVehiculo = m.PK_MarcaVehiculo,
                                     MarcaVehiculo1 = m.MarcaVehiculo1,

                                 }
                                 ).ToList(); //Convetir de var [query] a list

                    Cbo.DataSource = query;
                    Cbo.DisplayMember = "MarcaVehiculo1";
                    Cbo.ValueMember = "PK_MarcaVehiculo";
                }
                catch (Exception Ex)
                {

                }
            }
        }



        public void listadoBuscarMarca(DataGridView data, String MarcaBuscar)
        {
            using (BDAutoloteEntities conn = new BDAutoloteEntities())
            {

                try
                {
                    var query = (from m in conn.MarcaVehiculo
                                 join p in conn.CatalogoPais
                                 on m.FK_Pais equals p.PK_Pais //Join de MarcaVehiculo con CatalogoPais
                                 where m.Active == true //Filtar por registros con Active = 1
                                 && m.MarcaVehiculo1.ToLower().StartsWith(MarcaBuscar.ToLower())
                                 //Convertir parametro y campo a minuscula para poder comparar el contenido

                                 select new
                                 {   //Parametros a mostrar del result de la query
                                     PK_MarcaVehiculo = m.PK_MarcaVehiculo,
                                     MarcaVehiculo1 = m.MarcaVehiculo1,
                                     Pais = p.NombrePais,
                                     AnioFundacion = m.AnioFundacion
                                 }
                                 ).ToList(); //Convetir de var [query] a list

                    data.DataSource = query; //Pasar list a DataGridView
                }
                catch (Exception Ex)
                {

                }

            }
        }

    }

    #endregion MarcaVehiculoInterfaces

}

