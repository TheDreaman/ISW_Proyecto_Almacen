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


namespace Presentacion
{
    public partial class ProdAdministrar : Form
    {
        static string conexionstring = "Server=LAPTOP-TVTJEVPV;DataBase= Almacen;integrated security= true";
        SqlConnection conexion = new SqlConnection(conexionstring);
       

        public ProdAdministrar()
        {
            InitializeComponent();
            conexion.Open();
            string query = "Select * from Productos";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tablaP = new DataTable();
            data.Fill(tablaP);
            dataGridView1.DataSource = tablaP;
        }

        private void ProdAdministrar_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                string query = "Select * from Productos";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tablaP = new DataTable();
                data.Fill(tablaP);
                dataGridView1.DataSource = tablaP;

            }
            else
            {
                string query = "Select * from Productos where Proveedor = '" + textBox1.Text + "'";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tablaP = new DataTable();
                data.Fill(tablaP);
                dataGridView1.DataSource = tablaP;
                textBox1.Text = "";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Agregar = new VentanaAgregar();
                Agregar.Show();
               
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Agregar2 = new NuevoVentana();

            Agregar2.Show();

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (LoginCache.Rol == "Administrador")
            {

                Form Agregar1 = new EliminarVentana();


                Agregar1.Show();



            }
            if (LoginCache.Rol == "Usuario")

            {
                MessageBox.Show("No tienes accesso");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
