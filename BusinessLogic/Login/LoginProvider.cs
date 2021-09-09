using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic.Login
{
    public class LoginProvider
    {
        public int PK_Usuario { get; set; }
        public string NombreUsuario { get; set; }
        public string PWD { get; set; }
        public bool Active { get; set; }
       
        BDAutoloteEntities conn;
        public int flag = 0;

        public LoginProvider()
        {
            conn = new BDAutoloteEntities();

        }

        public bool InicioSesion()
        {
            

            using (conn = new BDAutoloteEntities())
            {
                try
                {
                    var query = (from p in conn.Usuarios
                                 where p.NombreUsuario.Equals(this.NombreUsuario) && p.PWD.Equals(this.PWD)
                                 && p.Active == true
                                 select new
                                 {   //Parametros a mostrar del result de la query
                                     PK_Usuario = p.PK_Usuario,
                                     Usuario = p.NombreUsuario
                                 }
                                 ).ToList(); //Convetir de var [query] a list

                    if (query.Count > 0)
                    {  
                            flag = 1; 
                    }
                    return true;
                }
                catch (Exception Ex)
                {
                    return false;

                }

            }

        }





    }
}
