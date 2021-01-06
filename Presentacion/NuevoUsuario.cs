using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            
            try
            {

                if (c.personaRegistrada(Convert.ToInt32(matri.Text)) == 0)
                {    
                    c.Insertar(Convert.ToInt32(matri.Text), nusu.Text, contrase.Text, nomb.Text, ape.Text, Roles.Text, corre.Text,car.Text);   //muestra un mensaje
                    c.insertarimagen(pic);
                    Close();
                }
                else
                {
                    MessageBox.Show("Ya esta Registrado.");
                }
            }
            catch(Exception ex)
            {
                Close();
               
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        int posY = 0;
        int posX = 0;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        string pic = "";
        private void foto1_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "Archivos jpg (*.jpg)|*.jpg|Archivo png(*.png)|*.png";
                openFileDialog1.FilterIndex = 1;
                pic = openFileDialog1.FileName;

                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    MessageBox.Show("Imagen seleccionada.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo cargar la imagen.");
            }
        }
    }

}
