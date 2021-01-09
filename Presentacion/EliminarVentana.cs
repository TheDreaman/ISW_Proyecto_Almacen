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
using System.Runtime.InteropServices;

namespace Presentacion
{

    public partial class EliminarVentana : Form
    {
        static string conexionstring = "Server=.;DataBase= Almacen;integrated security= true";//Server 
        SqlConnection conexion = new SqlConnection(conexionstring);
        NVConexion c = new NVConexion();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int left, int top, int right, int bottom, int width, int height);
        public EliminarVentana()
        {
            InitializeComponent();
            conexion.Open();
            textBox2.Visible = false;
            textBox4.Visible = false;
            button1.Visible = false;
 
            label4.Visible = false;
            label5.Visible = false;

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EliminarVentana_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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

        private void EliminarVentana_MouseDown(object sender, MouseEventArgs e)
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

            label4.Visible = true;
            label5.Visible = true;


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

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Eliminar();
            }
        }

        private void Eliminar()
        {
            conexion.Open();
            //---------------------------------------------------------------------------------
            string query = "Delete from Productos where ID_Producto = '" + textBox1.Text + "'";
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            //----------------------------------------------------------------------------------

            this.Close();
        }
    }
}
