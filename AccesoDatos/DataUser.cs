using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class DataUser:ConectionSQL          //Hereda de la clase ConectionSQL
    {
        public bool Login(string user, string pass)
        {
            using(var Conect = GetConnection())
            {
                Conect.Open();
                using (var Comando = new SqlCommand())
                {
                    Comando.Connection = Conect;
                    Comando.CommandText = "select *from Users where UserName=@user and Password=@pass";
                    Comando.Parameters.AddWithValue("@user", user);
                    Comando.Parameters.AddWithValue("@pass", pass);
                    Comando.CommandType = CommandType.Text;
                    SqlDataReader Reader = Comando.ExecuteReader();
                    if(Reader.HasRows)
                    {
                        return true;                //La consulta existe
                    }
                    else
                    {
                        return false;               //La consulta no existe
                    }
                }
            }
        }
    }
}
