namespace Presentacion
{
    partial class ReporteMovimientos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.LblRepoMov = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DataSetMovimientoFecha = new Presentacion.DataSetMovimientoFecha();
            this.Rango_fechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Rango_fechaTableAdapter = new Presentacion.DataSetMovimientoFechaTableAdapters.Rango_fechaTableAdapter();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMovimientoFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rango_fechaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LblRepoMov
            // 
            this.LblRepoMov.AutoSize = true;
            this.LblRepoMov.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRepoMov.Location = new System.Drawing.Point(97, 32);
            this.LblRepoMov.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRepoMov.Name = "LblRepoMov";
            this.LblRepoMov.Size = new System.Drawing.Size(407, 39);
            this.LblRepoMov.TabIndex = 0;
            this.LblRepoMov.Text = "Reporte de movimientos";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(79, 102);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(272, 22);
            this.dtpDesde.TabIndex = 1;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(432, 103);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(266, 22);
            this.dtpHasta.TabIndex = 2;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(722, 101);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 3;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Rango_fechaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.ReportMovimienrosFecha.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(73, 161);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1269, 486);
            this.reportViewer1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(73, 486);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 647);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1342, 75);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1342, 161);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(77, 561);
            this.panel3.TabIndex = 7;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.buttonBuscar);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.dtpDesde);
            this.panel4.Controls.Add(this.dtpHasta);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1419, 161);
            this.panel4.TabIndex = 8;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasta: ";
            // 
            // DataSetMovimientoFecha
            // 
            this.DataSetMovimientoFecha.DataSetName = "DataSetMovimientoFecha";
            this.DataSetMovimientoFecha.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Rango_fechaBindingSource
            // 
            this.Rango_fechaBindingSource.DataMember = "Rango_fecha";
            this.Rango_fechaBindingSource.DataSource = this.DataSetMovimientoFecha;
            // 
            // Rango_fechaTableAdapter
            // 
            this.Rango_fechaTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1419, 722);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.LblRepoMov);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReporteMovimientos";
            this.Text = "ReporteMovimientos";
            this.Load += new System.EventHandler(this.ReporteMovimientos_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMovimientoFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rango_fechaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblRepoMov;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button buttonBuscar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource Rango_fechaBindingSource;
        private DataSetMovimientoFecha DataSetMovimientoFecha;
        private DataSetMovimientoFechaTableAdapters.Rango_fechaTableAdapter Rango_fechaTableAdapter;
    }
}