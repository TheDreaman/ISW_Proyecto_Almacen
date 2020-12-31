using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Auxiliar.Cache;

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
                        while(Reader.Read())
                        {
                            LoginCache.ID = Reader.GetInt32(0);
                            LoginCache.Matricula = Reader.GetInt32(1);
                            LoginCache.Name1 = Reader.GetString(4);
                            LoginCache.Apellido = Reader.GetString(5);
                            LoginCache.Rol = Reader.GetString(6);
                            LoginCache.Email = Reader.GetString(7);
                            LoginCache.Cargo = Reader.GetString(9);
                        }
                        return true;                //La consulta existe
                    }
                    else
                    {
                        return false;               //La consulta no existe
                    }
                }
            }
        }

        public byte[] ConsultaIMG(int ID)
        {
            using (var Conect = GetConnection())
            {
                Conect.Open();
                SqlDataAdapter DA = new SqlDataAdapter();
                DA = new SqlDataAdapter("select Picture from Users where ID = '" + ID + "'",Conect);
                DataSet DS = new DataSet();
                DA.Fill(DS, "Users");
                byte[] Data = new byte[0];
                DataRow DR;
                DR = DS.Tables["Users"].Rows[0];
                Data = (byte[])DR["Picture"];
                LoginCache.Picture = Data;
                return Data;
            }
        }
    }
}
