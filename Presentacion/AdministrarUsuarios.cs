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
using System.Windows.Forms;

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
            NuevoUsuario ventananv = new NuevoUsuario();
            ventananv.Show();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            VEliminar ventananE = new VEliminar();
            ventananE.Show();
        }

        private void editar_Click(object sender, EventArgs e)
        {
            VEditar ventanaE = new VEditar();
            ventanaE.Show();
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            NVConexion c = new NVConexion();
            c.Mostrarusuario(mostrarusu);
        }

        private void mostrarusu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
