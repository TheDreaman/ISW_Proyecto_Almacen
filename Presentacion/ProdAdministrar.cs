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
        static string conexionstring = "Server=.;DataBase= Almacen;integrated security= true";
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
            if (LoginCache.Rol == "Usuario")

            {
                EliminarButton.Visible = false;
            }

        }

        private void ProdAdministrar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.dataSet1.Productos);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form NewForm = new VentanaAgregar();
            NewForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form NewForm = new NuevoVentana();
            NewForm.ShowDialog();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            Form NewForm = new EliminarVentana();
            NewForm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = "Select * from Productos";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tablaP = new DataTable();
            data.Fill(tablaP);
            dataGridView1.DataSource = tablaP;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string query = "Select * from Productos";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tablaP = new DataTable();
            data.Fill(tablaP);
            dataGridView1.DataSource = tablaP;
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
    }
}
