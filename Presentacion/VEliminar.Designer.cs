namespace Presentacion
{
    partial class VEliminar
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
            this.EliminarM = new System.Windows.Forms.TextBox();
            this.NVentana = new System.Windows.Forms.Label();
            this.EliminarMatricula = new System.Windows.Forms.Label();
            this.cancelarE = new System.Windows.Forms.Button();
            this.MEliminar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // EliminarM
            // 
            this.EliminarM.Location = new System.Drawing.Point(118, 130);
            this.EliminarM.Name = "EliminarM";
            this.EliminarM.Size = new System.Drawing.Size(255, 20);
            this.EliminarM.TabIndex = 9;
            this.EliminarM.TextChanged += new System.EventHandler(this.EliminarM_TextChanged);
            // 
            // NVentana
            // 
            this.NVentana.AutoSize = true;
            this.NVentana.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NVentana.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.NVentana.Location = new System.Drawing.Point(153, 18);
            this.NVentana.Name = "NVentana";
            this.NVentana.Size = new System.Drawing.Size(151, 42);
            this.NVentana.TabIndex = 8;
            this.NVentana.Text = "Eliminar";
            this.NVentana.Click += new System.EventHandler(this.NVentana_Click);
            this.NVentana.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NVentana_MouseMove);
            // 
            // EliminarMatricula
            // 
            this.EliminarMatricula.AutoSize = true;
            this.EliminarMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarMatricula.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.EliminarMatricula.Location = new System.Drawing.Point(113, 84);
            this.EliminarMatricula.Name = "EliminarMatricula";
            this.EliminarMatricula.Size = new System.Drawing.Size(100, 25);
            this.EliminarMatricula.TabIndex = 7;
            this.EliminarMatricula.Text = "Matricula";
            this.EliminarMatricula.Click += new System.EventHandler(this.EliminarMatricula_Click);
            // 
            // cancelarE
            // 
            this.cancelarE.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancelarE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarE.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cancelarE.Location = new System.Drawing.Point(272, 194);
            this.cancelarE.Name = "cancelarE";
            this.cancelarE.Size = new System.Drawing.Size(194, 53);
            this.cancelarE.TabIndex = 6;
            this.cancelarE.Text = "Cancelar";
            this.cancelarE.UseVisualStyleBackColor = false;
            this.cancelarE.Click += new System.EventHandler(this.cancelarE_Click);
            // 
            // MEliminar
            // 
            this.MEliminar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MEliminar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MEliminar.Location = new System.Drawing.Point(29, 194);
            this.MEliminar.Name = "MEliminar";
            this.MEliminar.Size = new System.Drawing.Size(194, 53);
            this.MEliminar.TabIndex = 5;
            this.MEliminar.Text = "Eliminar";
            this.MEliminar.UseVisualStyleBackColor = false;
            this.MEliminar.Click += new System.EventHandler(this.MEliminar_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 59);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // VEliminar
            // 
            this.AcceptButton = this.MEliminar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(497, 292);
            this.Controls.Add(this.NVentana);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EliminarM);
            this.Controls.Add(this.EliminarMatricula);
            this.Controls.Add(this.cancelarE);
            this.Controls.Add(this.MEliminar);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VEliminar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VEliminar";
            this.Load += new System.EventHandler(this.VEliminar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EliminarM;
        private System.Windows.Forms.Label NVentana;
        private System.Windows.Forms.Label EliminarMatricula;
        private System.Windows.Forms.Button cancelarE;
        private System.Windows.Forms.Button MEliminar;
        private System.Windows.Forms.Panel panel1;
    }
}