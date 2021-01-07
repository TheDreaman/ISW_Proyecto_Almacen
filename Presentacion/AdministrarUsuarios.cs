using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Presentacion
{
    public partial class AdministrarUsuarios : Form
    {
        public AdministrarUsuarios()
        {
            InitializeComponent();
            NVConexion c = new NVConexion();
            c.Mostrarusuario(mostrarusu);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form NewForm = new NuevoUsuario();
            NewForm.ShowDialog();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            Form NewForm = new VEliminar();
            NewForm.ShowDialog();
        }

        private void editar_Click(object sender, EventArgs e)
        {
            Form NewForm = new VEditar();
            NewForm.ShowDialog();
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            NVConexion c = new NVConexion();
            c.Mostrarusuario(mostrarusu);
        }

        private void mostrarusu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdministrarUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            NVConexion c = new NVConexion();
            c.Mostrarusuario(mostrarusu);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
