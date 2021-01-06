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
    public partial class VEliminar : Form
    {
        NVConexion c = new NVConexion();
        public VEliminar()
        {
            InitializeComponent();
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
                    MessageBox.Show("El usuario no existe.");
                    Close();
                }
                else
                {
                     c.eliminar(Convert.ToInt32(EliminarM.Text));
                    MessageBox.Show("Usuario Eliminado.");
                    Close();
                }
                    
            }
            catch(Exception ex)
            {
                MessageBox.Show("Verifique si están bien los datos ingresados.");
            }
        }

        private void cancelarE_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
