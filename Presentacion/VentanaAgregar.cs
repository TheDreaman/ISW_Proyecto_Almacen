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
    public partial class VentanaAgregar : Form
    {
        static string conexionstring = "Server=.;DataBase= Almacen;integrated security= true";
        SqlConnection conexion = new SqlConnection(conexionstring);
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
                    MessageBox.Show("Se agregó " + numericUpDown1.Value);
                    string query2 = "insert into Movimientos values('"+textBox1.Text+"','"+numericUpDown1.Value+"', '"+textBox2.Text+"','"+textBox4.Text+"','"+LoginCache.ID+"',GETDATE(),'Alta','"+LoginCache.usuario+"','"+LoginCache.Cargo+"','"+LoginCache.Rol+"','"+LoginCache.Name1+"','"+LoginCache.Apellido+"')";
                    SqlCommand comando2 = new SqlCommand(query2, conexion);

                    comando2.ExecuteNonQuery();

                }
                else
                {
                    MessageBox.Show("No se encontró el producto");
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
                    MessageBox.Show("Se eliminó " + numericUpDown1.Value);
            
                    string query2 = "insert into Movimientos values('" + textBox1.Text + "','" + numericUpDown1.Value + "', '" + textBox2.Text + "','" + textBox4.Text + "','" + LoginCache.ID + "',GETDATE(),'Baja','" + LoginCache.usuario + "','" + LoginCache.Cargo + "','" + LoginCache.Rol + "','" + LoginCache.Name1 + "','" + LoginCache.Apellido + "')";
                    SqlCommand comando2 = new SqlCommand(query2, conexion);

                    comando2.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Error. Verifica la cantidad proporcionada.");
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
                   
                    MessageBox.Show("Se agregó " + numericUpDown1.Value);
                    string query2 = "insert into Movimientos values('" + textBox1.Text + "','" + numericUpDown1.Value + "', '" + textBox2.Text + "','" + textBox4.Text + "','" + LoginCache.ID + "',GETDATE(),'Merma','" + LoginCache.usuario + "','" + LoginCache.Cargo + "','" + LoginCache.Rol + "','" + LoginCache.Name1 + "','" + LoginCache.Apellido + "')";
                    SqlCommand comando2 = new SqlCommand(query2, conexion);

                    comando2.ExecuteNonQuery();

                }
                else
                {
                    MessageBox.Show("Error. Verifica la cantidad proporcionada.");
                }

            }
            if (comboBox1.Text == "")
            {
                MessageBox.Show("No seleccionaste una opción");
            }
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void VentanaAgregar_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            string query = "Select * from Productos where ID_Producto ='"+textBox1.Text+"'";
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
                    MessageBox.Show("No se encontró el SKU");
                this.Close();
            }

            conexion.Close();
        }
    }
}
