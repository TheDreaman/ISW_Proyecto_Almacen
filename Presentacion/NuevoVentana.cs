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
using System.IO;
using System.Runtime.InteropServices;

namespace Presentacion
{
    public partial class NuevoVentana : Form
    {
        static string conexionstring = "Server=.;DataBase= Almacen;integrated security= true";//server
        SqlConnection conexion = new SqlConnection(conexionstring);/// <summary>

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int left, int top, int right, int bottom, int width, int height);
        public NuevoVentana()
        {
            InitializeComponent();
            conexion.Open();
            
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == ""))
            {
                MessageBox.Show("Debes llenar todos los campos de texto. ");
                string query = "Insert into Productos ([Cantidad],[ID_Producto],[Nombre_Producto],[Proveedor],[Merma]) values ('" + numericUpDown1.Value + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','0')";
                SqlCommand comando = new SqlCommand(query, conexion);

                comando.ExecuteNonQuery();
                this.Close();
            }

            else
            {
                //  Insert into Productos ([Cantidad],[ID_Producto],[Nombre_Producto],[Proveedor]) values ('','','','')
                string query = "Insert into Productos ([Cantidad],[ID_Producto],[Nombre_Producto],[Proveedor],[Merma]) values ('" + numericUpDown1.Value + "','" + textBox1.Text + "','" + textBox3.Text + "','" + textBox2.Text + "','0')";
                SqlCommand comando = new SqlCommand(query, conexion);

                comando.ExecuteNonQuery();
                this.Close();


            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NuevoVentana_Load(object sender, EventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void NuevoVentana_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
