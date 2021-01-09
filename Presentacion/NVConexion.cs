using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using Auxiliar.Cache;
using Dominio;
using System.Drawing;

namespace Presentacion
{
    class NVConexion
    {

        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;
        MessageBoxCustom MessageBoxCustom = new MessageBoxCustom();

        public NVConexion()
        {
            try
            {
                cn = new SqlConnection("Server=.;DataBase= Almacen;integrated security= true"); //cambiar a la direccion de su base de datos
                cn.Open();
            }
            catch (Exception ex)
            {
                MessageBoxBlack("No se conecto a la base de datos." + ex.ToString());
            }
        }

        public void Insertar(int mat, string userna, string contraseña, string nombr, string apelli, string rol, string correo, string carg)
        {
            
            try
            {
                if ((userna != "") || (contraseña != "") || (nombr != "") || (apelli != "") || (rol != "") || (correo != "") || (carg != ""))
                {
                    cmd = new SqlCommand("Insert into Users(Matricula,UserName,Password,Name1,Apellido,Rol,Email,Picture,Cargo) values(" + mat + ",'" + userna + "','" + contraseña + "','" + nombr + "','" + apelli + "','" + rol + "','" + correo + "',@Pic ,'" + carg + "')", cn);
                    cmd.Parameters.AddWithValue("@Pic", LoginCache.Picture2);
                    cmd.ExecuteNonQuery();
                    MessageBoxBlack("Usuario Agregado.");
                }
              
            }
            catch (Exception )
            {
                MessageBoxBlack("No se registro."); 
            }
            
        }

        public void InsertarsinIMG(int mat, string userna, string contraseña, string nombr, string apelli, string rol, string correo, string carg)
        {

            try
            {
                if ((userna != "") || (contraseña != "") || (nombr != "") || (apelli != "") || (rol != "") || (correo != "") || (carg != ""))
                {
                    cmd = new SqlCommand("Insert into Users(Matricula,UserName,Password,Name1,Apellido,Rol,Email,Picture,Cargo) values(" + mat + ",'" + userna + "','" + contraseña + "','" + nombr + "','" + apelli + "','" + rol + "','" + correo + "',@Pic ,'" + carg + "')", cn);
                    cmd.Parameters.AddWithValue("@Pic", LoginCache.Pictureemergency);
                    cmd.ExecuteNonQuery();
                    MessageBoxBlack("Usuario Agregado.");
                }

            }
            catch (Exception)
            {

                MessageBoxBlack("No se registro.");
            }

        }

        internal void insertarimagen(string pic)
        {
            throw new NotImplementedException();
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
                MessageBoxBlack("Ya esta Registrado." + ex.ToString());
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
                MessageBoxBlack("No se puedo llenar." + ex.ToString());
            }
        }

        public void llenartexboxconsulta(int matr, TextBox txtusuario, TextBox txtnombre, TextBox txtapellido, TextBox txtcontrase, ComboBox txtrol, TextBox txtcorreo, TextBox txtcargo, PictureBoxRounded IMG)
        {
            try
            {
                ModeloUsuario user = new ModeloUsuario();
                
                cmd = new SqlCommand("Select * from Users where Matricula=" + matr + "", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    user.ConsultaIMGMatri(matr);
                    txtusuario.Text = dr["UserName"].ToString();
                    txtnombre.Text = dr["Password"].ToString();
                    txtapellido.Text = dr["Name1"].ToString();
                    txtcontrase.Text = dr["Apellido"].ToString();
                    txtrol.Text = dr["Rol"].ToString();
                    txtcorreo.Text = dr["Email"].ToString();
                    txtcargo.Text = dr["Cargo"].ToString();
                    VerIMG(IMG, matr, LoginCache.Picture3);

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBoxBlack("No se pudo llenar los campos." + ex.ToString());
            }
        }

        public void VerIMG(PictureBoxRounded Pic, int Matri, byte[] PictureBytes)
        {    
            System.IO.MemoryStream MStream = new System.IO.MemoryStream(PictureBytes);
            Pic.Image = System.Drawing.Bitmap.FromStream(MStream);
        }

        public void actualizar(int matric, string usuario, string con, string nombre, string apellido, string rol, string correo, string cargo)
        {
            
            try
            {
                if ((usuario == "") || (con == "") || (nombre == "") || (apellido == "") || (rol == "") || (correo == "") || (cargo == ""))
                {
                    MessageBoxBlack("Verifique si están bien los datos ingresados.");
                }
                else
                {
                    cmd = new SqlCommand("Update Users set UserName='" + usuario + "', Password='" + con + "', Name1='" + nombre + "',Apellido='" + apellido + "', Rol='" + rol + "', Email='" + correo + "', Picture=@Pic, Cargo='" + cargo + "' where Matricula=" + matric + "", cn);
                    cmd.Parameters.AddWithValue("@Pic", LoginCache.Picture2);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Datos actualizados.");
                    MessageBoxBlack("Datos actualizados");
                }
                
            }
            catch (Exception)
            {
                // MessageBox.Show("No se actualizo.");  //manda mesaje en una ventana
                MessageBoxBlack("No se actualizo");
            }
            
        }

        public void actualizardefault(int ID)
        {
            cmd = new SqlCommand("Update Users set Picture=@Pic where ID = " + ID + "", cn);
            cmd.Parameters.AddWithValue("@Pic", LoginCache.Pictureemergency);
            cmd.ExecuteNonQuery();
        }

        public string eliminar(int mat)
        {
            string salida = "Usuario Eliminado";
            try
            {
                cmd = new SqlCommand("Delete from Users where Matricula = " + mat + "", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se Elimino."+ex.ToString();
            }
            return salida;
        }

        public string insertarimagen(PictureBox img)
        {
            string mensaje = "Se inserto la imagen.";
            try
            {
                cmd = new SqlCommand("Insert into Users values(@Picture)",cn);
                cmd.Parameters.Add("@Picture", SqlDbType.Image);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                img.Image.Save(ms,System.Drawing.Imaging.ImageFormat.Png);
                cmd.Parameters["@Picture"].Value = ms.GetBuffer();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                mensaje = "No se inserto la imagen" + ex.ToString();
            }
            return mensaje;
        }

        public void MessageBoxBlack(string msg)
        {
            MessageBoxCustom.Mensaje.Text = "       " + msg;
            MessageBoxCustom.ShowDialog();
        }
    }
}
