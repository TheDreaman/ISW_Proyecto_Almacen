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
        static string conexionstring = "Server=DESKTOP-D3SCCDM;DataBase= Almacen;integrated security= true";
        SqlConnection conexion = new SqlConnection(conexionstring);
        int i = 0;

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
        

        private void button1_Click(object sender, EventArgs e)
        {
            Form Agregar = new VentanaAgregar();
            if (i == 0)
            {
               

                Agregar.Show();
                i = 1;
                
            }
            else
            {

                MessageBox.Show("Ya tienes una ventana abierta");
                Agregar.Close();
                i = 0;
            }
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Agregar2 = new NuevoVentana();
         
                Agregar2.Show();
        
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (LoginCache.Rol == "Administrador"){
              
                Form Agregar1 = new EliminarVentana();
               

                    Agregar1.Show();
                   


            }
            if (LoginCache.Rol == "Usuario")
                
            {
                MessageBox.Show("No tienes accesso");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") {
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

        private void ProdAdministrar_Load(object sender, EventArgs e)
        {

        }
    }
}
