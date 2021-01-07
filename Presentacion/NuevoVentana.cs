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

namespace Presentacion
{
    public partial class NuevoVentana : Form
    {
        static string conexionstring = "Server=.;DataBase= Almacen;integrated security= true";//server
        SqlConnection conexion = new SqlConnection(conexionstring);/// <summary>
        //pruenaaaaaaaaaaaaaaaa
        /// </summary>
        public NuevoVentana()
        {
            InitializeComponent();
            conexion.Open();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text=="") || (textBox3.Text==""))
            {
                MessageBox.Show("Debes llenar todos los campos de texto. ");
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
    }
}
