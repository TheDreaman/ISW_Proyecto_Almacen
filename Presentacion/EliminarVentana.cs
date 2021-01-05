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
        static string conexionstring = "Server=.;DataBase= Almacen;integrated security= true";//Server 
        SqlConnection conexion = new SqlConnection(conexionstring);
        public EliminarVentana()
        {
            InitializeComponent();
            conexion.Open();
            textBox2.Visible = false;
            textBox4.Visible = false;
            button1.Visible = false;
           
           
            label4.Visible = false;
            label5.Visible = false;
           
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            //---------------------------------------------------------------------------------
            string query = "Delete from Productos where ID_Producto = '" + textBox1.Text + "'";
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            //----------------------------------------------------------------------------------
            
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EliminarVentana_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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
                MessageBox.Show("No se encontró el SKU");
                this.Close();
            }

            conexion.Close();
        }
    }
}
