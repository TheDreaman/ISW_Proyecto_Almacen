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
            this.SuspendLayout();
            // 
            // EliminarM
            // 
            this.EliminarM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.EliminarM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EliminarM.Font = new System.Drawing.Font("DIN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarM.ForeColor = System.Drawing.Color.White;
            this.EliminarM.Location = new System.Drawing.Point(135, 128);
            this.EliminarM.Name = "EliminarM";
            this.EliminarM.Size = new System.Drawing.Size(255, 20);
            this.EliminarM.TabIndex = 0;
            this.EliminarM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EliminarM.TextChanged += new System.EventHandler(this.EliminarM_TextChanged);
            // 
            // NVentana
            // 
            this.NVentana.AutoSize = true;
            this.NVentana.Font = new System.Drawing.Font("DIN", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NVentana.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.NVentana.Location = new System.Drawing.Point(180, 19);
            this.NVentana.Name = "NVentana";
            this.NVentana.Size = new System.Drawing.Size(168, 46);
            this.NVentana.TabIndex = 8;
            this.NVentana.Text = "Eliminar";
            this.NVentana.Click += new System.EventHandler(this.NVentana_Click);
            this.NVentana.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NVentana_MouseMove);
            // 
            // EliminarMatricula
            // 
            this.EliminarMatricula.AutoSize = true;
            this.EliminarMatricula.Font = new System.Drawing.Font("DIN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarMatricula.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.EliminarMatricula.Location = new System.Drawing.Point(53, 128);
            this.EliminarMatricula.Name = "EliminarMatricula";
            this.EliminarMatricula.Size = new System.Drawing.Size(76, 20);
            this.EliminarMatricula.TabIndex = 7;
            this.EliminarMatricula.Text = "Matricula";
            this.EliminarMatricula.Click += new System.EventHandler(this.EliminarMatricula_Click);
            // 
            // cancelarE
            // 
            this.cancelarE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.cancelarE.FlatAppearance.BorderSize = 0;
            this.cancelarE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cancelarE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.cancelarE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarE.Font = new System.Drawing.Font("DIN", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarE.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cancelarE.Location = new System.Drawing.Point(284, 211);
            this.cancelarE.Name = "cancelarE";
            this.cancelarE.Size = new System.Drawing.Size(158, 39);
            this.cancelarE.TabIndex = 2;
            this.cancelarE.Text = "Cancelar";
            this.cancelarE.UseVisualStyleBackColor = false;
            this.cancelarE.Click += new System.EventHandler(this.cancelarE_Click);
            // 
            // MEliminar
            // 
            this.MEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.MEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.MEliminar.FlatAppearance.BorderSize = 0;
            this.MEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.MEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.MEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MEliminar.Font = new System.Drawing.Font("DIN", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MEliminar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MEliminar.Location = new System.Drawing.Point(57, 211);
            this.MEliminar.Name = "MEliminar";
            this.MEliminar.Size = new System.Drawing.Size(158, 39);
            this.MEliminar.TabIndex = 1;
            this.MEliminar.Text = "Eliminar";
            this.MEliminar.UseVisualStyleBackColor = false;
            this.MEliminar.Click += new System.EventHandler(this.MEliminar_Click);
            // 
            // VEliminar
            // 
            this.AcceptButton = this.MEliminar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(497, 292);
            this.Controls.Add(this.NVentana);
            this.Controls.Add(this.EliminarM);
            this.Controls.Add(this.EliminarMatricula);
            this.Controls.Add(this.cancelarE);
            this.Controls.Add(this.MEliminar);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VEliminar";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VEliminar";
            this.Load += new System.EventHandler(this.VEliminar_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VEliminar_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EliminarM;
        private System.Windows.Forms.Label NVentana;
        private System.Windows.Forms.Label EliminarMatricula;
        private System.Windows.Forms.Button cancelarE;
        private System.Windows.Forms.Button MEliminar;
    }
}