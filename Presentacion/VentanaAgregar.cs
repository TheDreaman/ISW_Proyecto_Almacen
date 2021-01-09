using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Auxiliar.Cache;
using System.Runtime.InteropServices;


namespace Presentacion
{
    public partial class VentanaAgregar : Form
    {
        static string conexionstring = "Server=.;DataBase= Almacen;integrated security= true";
        SqlConnection conexion = new SqlConnection(conexionstring);
        NVConexion c = new NVConexion();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int left, int top, int right, int bottom, int width, int height);
        public VentanaAgregar()
        {
            InitializeComponent();
            conexion.Open();
            textBox2.Visible = false;
            textBox4.Visible = false;
            button1.Visible = false;
            label2.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            comboBox1.Visible = false;
            numericUpDown1.Visible = false;

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void button1_Click(object sender, EventArgs e)
        
        {
            conexion.Open();
            if (comboBox1.Text == "Agregar")
            {
              
                int flag = 0;
                string query = "Update Productos set Cantidad = Cantidad+(" + numericUpDown1.Value + ") where ID_Producto = '" + textBox1.Text + "'";
                SqlCommand comando = new SqlCommand(query, conexion);

                flag = comando.ExecuteNonQuery();
                if (flag == 1)
                {
                    c.MessageBoxBlack("Se agregó " + numericUpDown1.Value);
                    string query2 = "insert into Movimientos values('"+textBox1.Text+"','"+numericUpDown1.Value+"', '"+textBox2.Text+"','"+textBox4.Text+"','"+LoginCache.ID+"',GETDATE(),'Alta','"+LoginCache.usuario+"','"+LoginCache.Cargo+"','"+LoginCache.Rol+"','"+LoginCache.Name1+"','"+LoginCache.Apellido+"')";
                    SqlCommand comando2 = new SqlCommand(query2, conexion);

                    comando2.ExecuteNonQuery();

                }
                else
                {
                    c.MessageBoxBlack("No se encontró el producto");
                }
            }
            if (comboBox1.Text == "Quitar")

            {
                int flag = 0;
                string query = "Update Productos set Cantidad = Cantidad+(-" + numericUpDown1.Value + ") where ID_Producto = '" + textBox1.Text + "'and Cantidad >="+numericUpDown1.Value+"";
                SqlCommand comando = new SqlCommand(query, conexion);

                flag = comando.ExecuteNonQuery();
                if (flag == 1)
                {
                    c.MessageBoxBlack("Se eliminó " + numericUpDown1.Value);
            
                    string query2 = "insert into Movimientos values('" + textBox1.Text + "','" + numericUpDown1.Value + "', '" + textBox2.Text + "','" + textBox4.Text + "','" + LoginCache.ID + "',GETDATE(),'Baja','" + LoginCache.usuario + "','" + LoginCache.Cargo + "','" + LoginCache.Rol + "','" + LoginCache.Name1 + "','" + LoginCache.Apellido + "')";
                    SqlCommand comando2 = new SqlCommand(query2, conexion);

                    comando2.ExecuteNonQuery();
                }
                else
                {
                    c.MessageBoxBlack("Error. Verifica la cantidad proporcionada.");
                }
            }
            if (comboBox1.Text == "Merma")
            {
                int flag = 0;
                string query = "Update Productos set Merma = Merma+(" + numericUpDown1.Value + "), Cantidad = Cantidad + (-" + numericUpDown1.Value + ")  where ID_Producto = '" + textBox1.Text + "' and Cantidad >=" + numericUpDown1.Value + "";
                SqlCommand comando = new SqlCommand(query, conexion);

                flag = comando.ExecuteNonQuery();

                if (flag == 1)
                {

                    c.MessageBoxBlack("Se agregó " + numericUpDown1.Value);
                    string query2 = "insert into Movimientos values('" + textBox1.Text + "','" + numericUpDown1.Value + "', '" + textBox2.Text + "','" + textBox4.Text + "','" + LoginCache.ID + "',GETDATE(),'Merma','" + LoginCache.usuario + "','" + LoginCache.Cargo + "','" + LoginCache.Rol + "','" + LoginCache.Name1 + "','" + LoginCache.Apellido + "')";
                    SqlCommand comando2 = new SqlCommand(query2, conexion);

                    comando2.ExecuteNonQuery();

                }
                else
                {
                    c.MessageBoxBlack("Error. Verifica la cantidad proporcionada.");
                }

            }
            if (comboBox1.Text == "")
            {
                c.MessageBoxBlack("No seleccionaste una opción");
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)//Ejecuta el codigo
        {
            Buscar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void VentanaAgregar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Buscar();
            }
        }

        private void Buscar()
        {
            string query = "Select * from Productos where ID_Producto ='" + textBox1.Text + "'";
            SqlCommand comando = new SqlCommand(query, conexion);

            textBox2.Visible = true;
            textBox4.Visible = true;
            button1.Visible = true;
            label2.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            comboBox1.Visible = true;
            numericUpDown1.Visible = true;

            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                textBox2.Text = registro["Proveedor"].ToString();
                textBox4.Text = registro["Nombre_Producto"].ToString();
            }
            else
            {
                c.MessageBoxBlack("No se encontró el SKU");
                this.Close();
            }

            conexion.Close();
        }
    }
}
