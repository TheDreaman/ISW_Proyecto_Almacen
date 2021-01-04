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
    public partial class VEditar : Form
    {
        NVConexion c = new NVConexion();
        public VEditar()
        {
            InitializeComponent();
        }

        private void TitulodeVentana2_Click(object sender, EventArgs e)
        {

        }

        private void ape2_TextChanged(object sender, EventArgs e)
        {

        }

        private void nusu2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cargo2_Click(object sender, EventArgs e)
        {

        }

        private void apellido2_Click(object sender, EventArgs e)
        {

        }

        private void NUsuario2_Click(object sender, EventArgs e)
        {

        }

        private void Roles2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void car2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Contraseña2_Click(object sender, EventArgs e)
        {

        }

        private void Correo2_Click(object sender, EventArgs e)
        {

        }

        private void Nombre2_Click(object sender, EventArgs e)
        {

        }

        private void Foto2_Click(object sender, EventArgs e)
        {

        }

        private void Rol2_Click(object sender, EventArgs e)
        {

        }

        private void M2_Click(object sender, EventArgs e)
        {

        }

        private void Cancelar2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AgregarUsuario2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(c.actualizar(Convert.ToInt32(matri2.Text), nusu2.Text, contrase2.Text, nomb2.Text, ape2.Text, Roles2.Text, corre2.Text, car2.Text));
            nusu2.Text = "";
            nomb2.Text = "";
            ape2.Text = "";
            contrase2.Text = "";
            Roles2.Text = "";
            corre2.Text = "";
            car2.Text = "";
        }

        private void fot2_TextChanged(object sender, EventArgs e)
        {

        }

        private void contrase2_TextChanged(object sender, EventArgs e)
        {

        }

        private void corre2_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomb2_TextChanged(object sender, EventArgs e)
        {

        }

        private void matri2_TextChanged(object sender, EventArgs e)
        {
            NVConexion c = new NVConexion();

            if (c.personaRegistrada(Convert.ToInt32(matri2.Text)) > 0)
            {
                c.llenartexboxconsulta(Convert.ToInt32(matri2.Text), nusu2, contrase2, nomb2, ape2, Roles2, corre2, car2);
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
                AgregarUsuario2.Enabled = false;
            }

        }
    }
}
