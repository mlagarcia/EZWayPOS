using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;
using System.Windows.Forms;

namespace BusinessLogic
{
    public class Cliente
    {
        public int PK_Cliente { get; set; }
        public TipoCliente TipoCliente { get; set; }
        public string PrimerNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoNombre { get; set; }
        public string SegundoApellido { get; set; }
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public bool Active { get; set; }
        private BDAutoloteEntities conn;

        public Cliente()
        {
            Init();
        }
        private void Init()
        {
            this.PrimerNombre = string.Empty;
            this.PrimerApellido = string.Empty;
            this.SegundoNombre = string.Empty;
            this.SegundoApellido = string.Empty;
            this.Sexo = string.Empty;
            this.Active = true;
            conn = new BDAutoloteEntities();
        }
        public bool AgregarCliente()
        {
            using (BDAutoloteEntities conn = new BDAutoloteEntities())
            {
                try
                {
                    DataAccess.Cliente t = new DataAccess.Cliente();
                    t.FK_TipoCliente = this.TipoCliente.PK_TipoCliente;
                    t.PrimerNombre = this.PrimerNombre;
                    t.PrimerApellido = this.PrimerApellido;
                    t.SegundoNombre = this.SegundoNombre;
                    t.SegundoApellido = this.SegundoApellido;
                    t.FechaNacimiento = this.FechaNacimiento;
                    t.Sexo = this.Sexo;
                    t.Active = true;

                    conn.Cliente.Add(t);
                    conn.SaveChanges();

                    return true;
                }
                catch (Exception Ex)
                {
                    return false;
                }
            }
        }
        public bool EliminarCliente()
        {
            using (BDAutoloteEntities conn = new BDAutoloteEntities())
            {
                try
                {
                    DataAccess.Cliente t = new DataAccess.Cliente();
                    t.PK_Cliente = this.PK_Cliente;
                    t.FK_TipoCliente = this.TipoCliente.PK_TipoCliente;
                    t.PrimerNombre = this.PrimerNombre;
                    t.PrimerApellido = this.PrimerApellido;
                    t.SegundoNombre = this.SegundoNombre;
                    t.SegundoApellido = this.SegundoApellido;
                    t.FechaNacimiento = this.FechaNacimiento;
                    t.Sexo = this.Sexo;
                    t.Active = this.Active;

                    conn.Cliente.Attach(t);
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

        public IEnumerable<object> DetalleTipoCliente(string TipoCliente)
        {
            using (BDAutoloteEntities conn = new BDAutoloteEntities())
            {
                try
                {
                    var query = (from p in conn.TipoCliente
                                 where p.TipoCliente1 == TipoCliente
                                 select p).ToList(); //Convetir de var [query] a list
                    return query;
                }
                catch (Exception Ex)
                {
                    return null;
                }
            }
        }

        public bool ActualizarCliente()
        {
            using (BDAutoloteEntities conn = new BDAutoloteEntities())
            {
                try
                {
                    DataAccess.Cliente t = new DataAccess.Cliente();
                    t.PK_Cliente = this.PK_Cliente;
                    t.FK_TipoCliente = this.TipoCliente.PK_TipoCliente;
                    t.PrimerNombre = this.PrimerNombre;
                    t.PrimerApellido = this.PrimerApellido;
                    t.SegundoNombre = this.SegundoNombre;
                    t.SegundoApellido = this.SegundoApellido;
                    t.FechaNacimiento = this.FechaNacimiento;
                    t.Sexo = this.Sexo;
                    t.Active = true;

                    conn.Cliente.Attach(t);
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

        public void listadoBuscarClienteNombre(DataGridView data, String ClienteBuscar)
        {
            using (BDAutoloteEntities conn = new BDAutoloteEntities())
            {

                try
                {
                    var query = (from m in conn.Cliente
                                 join p in conn.TipoCliente
                                 on m.FK_TipoCliente equals p.PK_TipoCliente//Join de MarcaVehiculo con CatalogoPais
                                 where m.Active == true //Filtar por registros con Active = 1
                                 && m.PrimerNombre.ToLower().StartsWith(ClienteBuscar.ToLower())
                                 //Convertir parametro y campo a minuscula para poder comparar el contenido

                                 select new
                                 {   //Parametros a mostrar del result de la query
                                     PK_Cliente = m.PK_Cliente,
                                     TipoCliente1 = p.TipoCliente1,
                                     PrimerNombre = m.PrimerNombre,
                                     SegundoNombre = m.SegundoNombre,
                                     PrimerApellido = m.PrimerApellido,
                                     SegundoApellido = m.SegundoApellido,
                                     FechaNacimiento = m.FechaNacimiento,
                                     sexo = m.Sexo
                                 }
                                 ).ToList(); //Convetir de var [query] a list

                    data.DataSource = query; //Pasar list a DataGridView
                }
                catch (Exception Ex)
                {
                }
            }
        }

        public void listadoBuscarClienteApellido(DataGridView data, String ClienteBuscar)
        {
            using (BDAutoloteEntities conn = new BDAutoloteEntities())
            {

                try
                {
                    var query = (from m in conn.Cliente
                                 join p in conn.TipoCliente
                                 on m.FK_TipoCliente equals p.PK_TipoCliente//Join de MarcaVehiculo con CatalogoPais
                                 where m.Active == true //Filtar por registros con Active = 1
                                 && m.PrimerApellido.ToLower().StartsWith(ClienteBuscar.ToLower())
                                 //Convertir parametro y campo a minuscula para poder comparar el contenido

                                 select new
                                 {   //Parametros a mostrar del result de la query
                                     PK_Cliente = m.PK_Cliente,
                                     TipoCliente1 = p.TipoCliente1,
                                     PrimerNombre = m.PrimerNombre,
                                     SegundoNombre = m.SegundoNombre,
                                     PrimerApellido = m.PrimerApellido,
                                     SegundoApellido = m.SegundoApellido,
                                     FechaNacimiento = m.FechaNacimiento,
                                     sexo = m.Sexo
                                 }
                                 ).ToList(); //Convetir de var [query] a list

                    data.DataSource = query; //Pasar list a DataGridView
                }
                catch (Exception Ex)
                {
                }
            }
        }

        public void listadoCliente(DataGridView data)
        {
            using (BDAutoloteEntities conn = new BDAutoloteEntities())
            {

                try
                {
                    var query = (from m in conn.Cliente
                                 join p in conn.TipoCliente
                                 on m.FK_TipoCliente equals p.PK_TipoCliente//Join de MarcaVehiculo con CatalogoPais
                                 where m.Active == true //Filtar por registros con Active = 1

                                 select new
                                 {   //Parametros a mostrar del result de la query
                                     PK_Cliente = m.PK_Cliente,
                                     TipoCliente1 = p.TipoCliente1,
                                     PrimerNombre = m.PrimerNombre,
                                     SegundoNombre = m.SegundoNombre,
                                     PrimerApellido = m.PrimerApellido,
                                     SegundoApellido = m.SegundoApellido,
                                     FechaNacimiento = m.FechaNacimiento,
                                     sexo = m.Sexo
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
}

