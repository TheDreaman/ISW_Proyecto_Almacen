using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class NuevoUsuario : Form
    {
        NVConexion c = new NVConexion();
        private bool editar = false;
        private readonly DataGridView mostrarusu;

        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (c.personaRegistrada(Convert.ToInt32(matri.Text)) == 0)
            {

                MessageBox.Show(c.Insertar(Convert.ToInt32(matri.Text), nusu.Text, contrase.Text, nomb.Text, ape.Text, Roles.Text, corre.Text, car.Text));   //muestra un mensaje
                limpiarcajas();
            }
            else
            {
                MessageBox.Show("Ya esta Registrado");
            }

        }



        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void fot_TextChanged(object sender, EventArgs e)
        {

        }

        private void corre_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomb_TextChanged(object sender, EventArgs e)
        {

        }

        private void contrase_TextChanged(object sender, EventArgs e)
        {

        }

        private void Roles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NUsuario_Click(object sender, EventArgs e)
        {

        }

        private void nusu_TextChanged(object sender, EventArgs e)
        {

        }

        private void ape_TextChanged(object sender, EventArgs e)
        {

        }

        private void apellido_Click(object sender, EventArgs e)
        {

        }

        private void cargo_Click(object sender, EventArgs e)
        {

        }

        private void car_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void limpiarcajas()
        {
            editar = false;
            nomb.Text = "";
            corre.Text = "";
            contrase.Text = "";
            matri.Text = "";
            Roles.Text = "";
            nusu.Text = "";
            ape.Text = "";
            car.Text = "";
        }
    }

}
