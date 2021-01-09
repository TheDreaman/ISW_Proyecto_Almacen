using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Presentacion
{
    public partial class VEliminar : Form
    {
        NVConexion c = new NVConexion();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int left, int top, int right, int bottom, int width, int height);
        public VEliminar()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void NVentana_Click(object sender, EventArgs e)
        {

        }

        private void EliminarMatricula_Click(object sender, EventArgs e)
        {

        }

        private void EliminarM_TextChanged(object sender, EventArgs e)
        {

        }

        private void MEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (c.personaRegistrada(Convert.ToInt32(EliminarM.Text)) == 0)
                {
                    c.MessageBoxBlack("El usuario no existe.");
                    Close();
                }
                else
                {
                     c.eliminar(Convert.ToInt32(EliminarM.Text));
                    c.MessageBoxBlack("Usuario Eliminado.");
                    Close();
                }
                    
            }
            catch(Exception)
            {
                c.MessageBoxBlack("Verifique si están bien los datos ingresados.");
            }
        }

        private void cancelarE_Click(object sender, EventArgs e)
        {
            Close();
        }

        int posY = 0;
        int posX = 0;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button != MouseButtons.Left)
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

        private void NVentana_MouseMove(object sender, MouseEventArgs e)
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

        private void VEliminar_Load(object sender, EventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void VEliminar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
