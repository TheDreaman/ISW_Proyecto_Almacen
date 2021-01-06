using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Auxiliar.Cache;
using System.IO;

namespace Presentacion
{
    public partial class VEditar : Form
    {
        NVConexion c = new NVConexion();
        public VEditar()
        {
            InitializeComponent();
        }

        private void Cancelar2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AgregarUsuario2_Click(object sender, EventArgs e)
        {
            try
            {
                LoginCache.Picture2 = null;
                Stream mystream = openFileDialog1.OpenFile();
                using (MemoryStream ms = new MemoryStream())
                {
                    mystream.CopyTo(ms);
                    LoginCache.Picture2 = ms.ToArray();
                }
                c.actualizar(Convert.ToInt32(matri2.Text), nusu2.Text, contrase2.Text, nomb2.Text, ape2.Text, Roles2.Text, corre2.Text, car2.Text);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifique si están bien los datos ingresados.");
            }
        }


        private void matri2_TextChanged(object sender, EventArgs e)
        {
            NVConexion c = new NVConexion();
            try
            {
                if (c.personaRegistrada(Convert.ToInt32(matri2.Text)) > 0)
                {
                    c.llenartexboxconsulta(Convert.ToInt32(matri2.Text), nusu2, contrase2, nomb2, ape2, Roles2, corre2, car2, PicCambioUser);
                    AgregarUsuario2.Enabled = true;           //activa el boton de agregar si existe el usuario
                }
                else
                {
                    nusu2.Text = "";
                    nomb2.Text = "";
                    ape2.Text = "";
                    contrase2.Text = "";
                    Roles2.Text = "";
                    corre2.Text = "";
                    car2.Text = "";
                    PicCambioUser.Image = null;
                    AgregarUsuario2.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese una matrícula.");
            }

        }

        private void VEditar_Load(object sender, EventArgs e)
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

        private void TitulodeVentana2_MouseMove(object sender, MouseEventArgs e)
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

        private void BtnSelecIMGCambio_Click(object sender, EventArgs e)
        {
            LoginCache.URL = null;
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Archivos jpg (*.jpg)|*.jpg|Archivos png (*.png)|*.png";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LoginCache.URL = openFileDialog1.FileName;
                PicCambioUser.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
