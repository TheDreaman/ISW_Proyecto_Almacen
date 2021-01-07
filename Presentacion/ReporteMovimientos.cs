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
    public partial class ReporteMovimientos : Form
    {
        public ReporteMovimientos()
        {
            InitializeComponent();
        }
        //Declaracion de parametros
        public DateTime Fecha1 { get; set; }
        public DateTime Fecha2 { get; set; }

        private void ReporteMovimientos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetMovimientoFecha.Rango_fecha' Puede moverla o quitarla según sea necesario.
            this.Rango_fechaTableAdapter.Fill(this.DataSetMovimientoFecha.Rango_fecha, Fecha1, Fecha2);

            this.reportViewer1.RefreshReport();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            //se declaran los paraametros

            DateTime Fecha1 = dtpDesde.Value;
            DateTime Fecha2 = dtpHasta.Value;
            this.Rango_fechaTableAdapter.Fill(this.DataSetMovimientoFecha.Rango_fecha, Fecha1, Fecha2);
            this.reportViewer1.RefreshReport();
        }
    }
}
