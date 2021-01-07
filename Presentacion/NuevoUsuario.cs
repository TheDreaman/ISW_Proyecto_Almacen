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
using Auxiliar.Cache;
using Dominio;
using System.Runtime.InteropServices;

namespace Presentacion
{
    public partial class NuevoUsuario : Form
    {
        NVConexion c = new NVConexion();
        private bool editar = false;
        //private readonly DataGridView mostrarusu;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int left, int top, int right, int bottom, int width, int height);

        public NuevoUsuario()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            try
            {

                if (c.personaRegistrada(Convert.ToInt32(matri.Text)) == 0)
                {
                    LoginCache.Picture2 = null;
                    Stream mystream = openFileDialog1.OpenFile();
                    using (MemoryStream ms = new MemoryStream())
                    {
                        mystream.CopyTo(ms);
                        LoginCache.Picture2 = ms.ToArray();
                    }
                    c.Insertar(Convert.ToInt32(matri.Text), nusu.Text, contrase.Text, nomb.Text, ape.Text, Roles.Text, corre.Text, car.Text);   //muestra un mensaje
                    Close();
                }
                else
                {
                    MessageBox.Show("Ya esta Registrado.");
                    
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Ingrese un usuario valido.");
                Close();
               
            }

        }

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
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

        
        private void foto1_Click(object sender, EventArgs e)
        {
            LoginCache.URL = null;
            //openFileDialog1.ShowDialog();
            openFileDialog1.InitialDirectory="c:\\";
            openFileDialog1.Filter= "Archivos jpg (*.jpg)|*.jpg|Archivos png (*.png)|*.png";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LoginCache.URL = openFileDialog1.FileName;
                PicNewUser.Image = Image.FromFile(openFileDialog1.FileName);
            }
            
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]            //<----De aqui
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void NuevoUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }

}
