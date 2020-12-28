using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public abstract class ConectionSQL          //Abstract = no se puede instanciar
    {
        private readonly string Connection;

        public ConectionSQL()                   //Se crea la coneccion con SQL
        {
            Connection = "Server=DESKTOP-E3NADF3;DataBase= Almacen;integrated security= true";      //Indica el nombre del servidor
        }                                                                                           //(mi PC), el nombre de la BDD y el metodo    
        protected SqlConnection GetConnection()                                                     //de acceso a la BDD (credenciales de windows)
        {
            return new SqlConnection(Connection);                   //Devuelve la coneccion SQL
        }
    }
}
