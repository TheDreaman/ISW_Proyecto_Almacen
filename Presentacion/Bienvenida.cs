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

namespace Presentacion
{
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
        }


        private void msgBienvenida(string msg)                       //Metodo vacio que sirve para mostrar un mensaje
        {
            LblBienvenido.Text = msg;
            LblBienvenido.Visible = true;
            
        }

        private void Bienvenida_Load(object sender, EventArgs e)
        {
            LblBienvenido.Text = "Bienvenido: " + LoginCache.Name1 + " " + LoginCache.Apellido;

        }
    }
}
