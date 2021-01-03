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
    public partial class EliminarVentana : Form
    {
        static string conexionstring = "Server=DESKTOP-D3SCCDM;DataBase= Almacen;integrated security= true";//Server 
        SqlConnection conexion = new SqlConnection(conexionstring);
        public EliminarVentana()
        {
            InitializeComponent();
            conexion.Open();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "Delete from Productos where Nombre_Producto = '" + textBox1.Text + "'";
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            this.Close();
        }
    }
}
