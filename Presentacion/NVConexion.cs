using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Presentacion
{
    class NVConexion
    {

        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;

        public NVConexion()
        {
            try
            {
                cn = new SqlConnection("Data Source=.;Initial Catalog=Almacen;Integrated Security=True"); //cambiar a la direccion de su base de datos
                cn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto a la base de datos." + ToString());
            }
        }

        public string Insertar(int mat, string userna, string contraseña, string nombr, string apelli, string rol, string correo, string carg)
        {
            string salida = "Usuario Agregado";
            try
            {
                cmd = new SqlCommand("Insert into Users(Matricula,UserName,Password,Name1,Apellido,Rol,Email,Cargo) values(" + mat + ",'" + userna + "','" + contraseña + "','" + nombr + "','" + apelli + "','" + rol + "','" + correo + "','" + carg + "')", cn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                salida = "No se registro.";
            }
            return salida;
        }

        public int personaRegistrada(int mat)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from Users where Matricula = " + mat + "", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ya esta Registrado." + ex.ToString());
            }
            return contador;
        }

        public void Mostrarusuario(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from Users", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo llenar.");
            }
        }

        public void llenartexboxconsulta(int matr, TextBox txtusuario, TextBox txtnombre, TextBox txtapellido, TextBox txtcontrase, ComboBox txtrol, TextBox txtcorreo, TextBox txtcargo)
        {
            try
            {
                cmd = new SqlCommand("Select * from Users where Matricula=" + matr + "", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtusuario.Text = dr["UserName"].ToString();
                    txtnombre.Text = dr["Password"].ToString();
                    txtapellido.Text = dr["Name1"].ToString();
                    txtcontrase.Text = dr["Apellido"].ToString();
                    txtrol.Text = dr["Rol"].ToString();
                    txtcorreo.Text = dr["Email"].ToString();
                    txtcargo.Text = dr["Cargo"].ToString();

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos." + ex.ToString());
            }
        }

        public string actualizar(int matric, string usuario, string con, string nombre, string apellido, string rol, string correo, string cargo)
        {
            string salida = "Se actualizaron los datos";
            try
            {
                cmd = new SqlCommand("Update Users set UserName='" + usuario + "', Password='" + con + "', Name1='" + nombre + "',Apellido='" + apellido + "', Rol='" + rol + "', Email='" + correo + "', Cargo='" + cargo + "' where Matricula=" + matric + "", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se actualizo." + ex.ToString();  //manda mesaje en una ventana
            }
            return salida;
        }

    }
}
