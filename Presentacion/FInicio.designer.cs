namespace Presentacion
{
    partial class FInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FInicio));
            this.TopBarra = new System.Windows.Forms.Panel();
            this.BtRes = new System.Windows.Forms.PictureBox();
            this.BtMin = new System.Windows.Forms.PictureBox();
            this.BtMax = new System.Windows.Forms.PictureBox();
            this.BtCerrar = new System.Windows.Forms.PictureBox();
            this.LeftMenu = new System.Windows.Forms.Panel();
            this.TxtRol = new System.Windows.Forms.Label();
            this.BtLogout = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.PSubreportes = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtReporteMov = new System.Windows.Forms.Button();
            this.BtRepoInv = new System.Windows.Forms.Button();
            this.PSubProductos1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtAdministrarPro = new System.Windows.Forms.Button();
            this.BtReportes = new System.Windows.Forms.Button();
            this.BtProductos = new System.Windows.Forms.Button();
            this.Contenido = new System.Windows.Forms.Panel();
            this.ImgUser = new Presentacion.PictureBoxRounded();
            this.TopBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtCerrar)).BeginInit();
            this.LeftMenu.SuspendLayout();
            this.PSubreportes.SuspendLayout();
            this.PSubProductos1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgUser)).BeginInit();
            this.SuspendLayout();
            // 
            // TopBarra
            // 
            this.TopBarra.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TopBarra.Controls.Add(this.BtRes);
            this.TopBarra.Controls.Add(this.BtMin);
            this.TopBarra.Controls.Add(this.BtMax);
            this.TopBarra.Controls.Add(this.BtCerrar);
            this.TopBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBarra.Location = new System.Drawing.Point(0, 0);
            this.TopBarra.Name = "TopBarra";
            this.TopBarra.Size = new System.Drawing.Size(1300, 24);
            this.TopBarra.TabIndex = 0;
            this.TopBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBarra_MouseDown);
            // 
            // BtRes
            // 
            this.BtRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtRes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtRes.Image = ((System.Drawing.Image)(resources.GetObject("BtRes.Image")));
            this.BtRes.Location = new System.Drawing.Point(1251, 3);
            this.BtRes.Name = "BtRes";
            this.BtRes.Size = new System.Drawing.Size(20, 20);
            this.BtRes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtRes.TabIndex = 3;
            this.BtRes.TabStop = false;
            this.BtRes.Visible = false;
            this.BtRes.Click += new System.EventHandler(this.BtRes_Click);
            // 
            // BtMin
            // 
            this.BtMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtMin.Image = ((System.Drawing.Image)(resources.GetObject("BtMin.Image")));
            this.BtMin.Location = new System.Drawing.Point(1225, 3);
            this.BtMin.Name = "BtMin";
            this.BtMin.Size = new System.Drawing.Size(20, 20);
            this.BtMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtMin.TabIndex = 2;
            this.BtMin.TabStop = false;
            this.BtMin.Click += new System.EventHandler(this.BtMin_Click);
            // 
            // BtMax
            // 
            this.BtMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtMax.Image = ((System.Drawing.Image)(resources.GetObject("BtMax.Image")));
            this.BtMax.Location = new System.Drawing.Point(1251, 3);
            this.BtMax.Name = "BtMax";
            this.BtMax.Size = new System.Drawing.Size(20, 20);
            this.BtMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtMax.TabIndex = 1;
            this.BtMax.TabStop = false;
            this.BtMax.Click += new System.EventHandler(this.BtMax_Click);
            // 
            // BtCerrar
            // 
            this.BtCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtCerrar.Image")));
            this.BtCerrar.Location = new System.Drawing.Point(1277, 3);
            this.BtCerrar.Name = "BtCerrar";
            this.BtCerrar.Size = new System.Drawing.Size(20, 20);
            this.BtCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtCerrar.TabIndex = 0;
            this.BtCerrar.TabStop = false;
            this.BtCerrar.Click += new System.EventHandler(this.BtCerrar_Click);
            // 
            // LeftMenu
            // 
            this.LeftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.LeftMenu.Controls.Add(this.ImgUser);
            this.LeftMenu.Controls.Add(this.TxtRol);
            this.LeftMenu.Controls.Add(this.BtLogout);
            this.LeftMenu.Controls.Add(this.button3);
            this.LeftMenu.Controls.Add(this.PSubreportes);
            this.LeftMenu.Controls.Add(this.PSubProductos1);
            this.LeftMenu.Controls.Add(this.BtReportes);
            this.LeftMenu.Controls.Add(this.BtProductos);
            this.LeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftMenu.Location = new System.Drawing.Point(0, 24);
            this.LeftMenu.Name = "LeftMenu";
            this.LeftMenu.Size = new System.Drawing.Size(220, 626);
            this.LeftMenu.TabIndex = 1;
            // 
            // TxtRol
            // 
            this.TxtRol.AutoSize = true;
            this.TxtRol.Font = new System.Drawing.Font("DIN", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRol.ForeColor = System.Drawing.Color.White;
            this.TxtRol.Location = new System.Drawing.Point(76, 192);
            this.TxtRol.Name = "TxtRol";
            this.TxtRol.Size = new System.Drawing.Size(25, 15);
            this.TxtRol.TabIndex = 5;
            this.TxtRol.Text = "Rol";
            // 
            // BtLogout
            // 
            this.BtLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtLogout.BackColor = System.Drawing.Color.Black;
            this.BtLogout.FlatAppearance.BorderSize = 0;
            this.BtLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtLogout.Font = new System.Drawing.Font("DIN", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtLogout.Location = new System.Drawing.Point(0, 560);
            this.BtLogout.Name = "BtLogout";
            this.BtLogout.Size = new System.Drawing.Size(220, 30);
            this.BtLogout.TabIndex = 4;
            this.BtLogout.Text = "Cerrar sesión";
            this.BtLogout.UseVisualStyleBackColor = false;
            this.BtLogout.Click += new System.EventHandler(this.BtLogout_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("DIN", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(0, 596);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(255, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "          Administrar Usuarios";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PSubreportes
            // 
            this.PSubreportes.Controls.Add(this.panel3);
            this.PSubreportes.Controls.Add(this.panel2);
            this.PSubreportes.Controls.Add(this.BtReporteMov);
            this.PSubreportes.Controls.Add(this.BtRepoInv);
            this.PSubreportes.Location = new System.Drawing.Point(0, 374);
            this.PSubreportes.Name = "PSubreportes";
            this.PSubreportes.Size = new System.Drawing.Size(220, 166);
            this.PSubreportes.TabIndex = 2;
            this.PSubreportes.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 30);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 30);
            this.panel2.TabIndex = 1;
            // 
            // BtReporteMov
            // 
            this.BtReporteMov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.BtReporteMov.FlatAppearance.BorderSize = 0;
            this.BtReporteMov.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtReporteMov.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtReporteMov.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtReporteMov.Font = new System.Drawing.Font("DIN", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtReporteMov.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtReporteMov.Image = ((System.Drawing.Image)(resources.GetObject("BtReporteMov.Image")));
            this.BtReporteMov.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtReporteMov.Location = new System.Drawing.Point(12, 39);
            this.BtReporteMov.Name = "BtReporteMov";
            this.BtReporteMov.Size = new System.Drawing.Size(250, 30);
            this.BtReporteMov.TabIndex = 4;
            this.BtReporteMov.Text = "Reporte de movimientos";
            this.BtReporteMov.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtReporteMov.UseVisualStyleBackColor = false;
            this.BtReporteMov.Click += new System.EventHandler(this.BtReporteMov_Click);
            // 
            // BtRepoInv
            // 
            this.BtRepoInv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.BtRepoInv.FlatAppearance.BorderSize = 0;
            this.BtRepoInv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtRepoInv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtRepoInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtRepoInv.Font = new System.Drawing.Font("DIN", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtRepoInv.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtRepoInv.Image = ((System.Drawing.Image)(resources.GetObject("BtRepoInv.Image")));
            this.BtRepoInv.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtRepoInv.Location = new System.Drawing.Point(12, 3);
            this.BtRepoInv.Name = "BtRepoInv";
            this.BtRepoInv.Size = new System.Drawing.Size(250, 30);
            this.BtRepoInv.TabIndex = 3;
            this.BtRepoInv.Text = "Reporte de inventario";
            this.BtRepoInv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtRepoInv.UseVisualStyleBackColor = false;
            this.BtRepoInv.Click += new System.EventHandler(this.BtRepoInv_Click);
            // 
            // PSubProductos1
            // 
            this.PSubProductos1.Controls.Add(this.panel1);
            this.PSubProductos1.Controls.Add(this.BtAdministrarPro);
            this.PSubProductos1.Location = new System.Drawing.Point(0, 257);
            this.PSubProductos1.Name = "PSubProductos1";
            this.PSubProductos1.Size = new System.Drawing.Size(220, 75);
            this.PSubProductos1.TabIndex = 0;
            this.PSubProductos1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 30);
            this.panel1.TabIndex = 0;
            // 
            // BtAdministrarPro
            // 
            this.BtAdministrarPro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.BtAdministrarPro.FlatAppearance.BorderSize = 0;
            this.BtAdministrarPro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtAdministrarPro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtAdministrarPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAdministrarPro.Font = new System.Drawing.Font("DIN", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAdministrarPro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtAdministrarPro.Image = ((System.Drawing.Image)(resources.GetObject("BtAdministrarPro.Image")));
            this.BtAdministrarPro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtAdministrarPro.Location = new System.Drawing.Point(12, 3);
            this.BtAdministrarPro.Name = "BtAdministrarPro";
            this.BtAdministrarPro.Size = new System.Drawing.Size(250, 30);
            this.BtAdministrarPro.TabIndex = 2;
            this.BtAdministrarPro.Text = "Administrar";
            this.BtAdministrarPro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtAdministrarPro.UseVisualStyleBackColor = false;
            this.BtAdministrarPro.Click += new System.EventHandler(this.BtAdministrarPro_Click);
            // 
            // BtReportes
            // 
            this.BtReportes.BackColor = System.Drawing.Color.Black;
            this.BtReportes.FlatAppearance.BorderSize = 0;
            this.BtReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtReportes.Font = new System.Drawing.Font("DIN", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtReportes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtReportes.Location = new System.Drawing.Point(0, 338);
            this.BtReportes.Name = "BtReportes";
            this.BtReportes.Size = new System.Drawing.Size(220, 30);
            this.BtReportes.TabIndex = 1;
            this.BtReportes.Text = "Reportes";
            this.BtReportes.UseVisualStyleBackColor = false;
            this.BtReportes.Click += new System.EventHandler(this.BtReportes_Click);
            // 
            // BtProductos
            // 
            this.BtProductos.BackColor = System.Drawing.Color.Black;
            this.BtProductos.FlatAppearance.BorderSize = 0;
            this.BtProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtProductos.Font = new System.Drawing.Font("DIN", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtProductos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtProductos.Location = new System.Drawing.Point(0, 221);
            this.BtProductos.Name = "BtProductos";
            this.BtProductos.Size = new System.Drawing.Size(220, 30);
            this.BtProductos.TabIndex = 0;
            this.BtProductos.Text = "Productos";
            this.BtProductos.UseVisualStyleBackColor = false;
            this.BtProductos.Click += new System.EventHandler(this.BtProductos_Click);
            // 
            // Contenido
            // 
            this.Contenido.BackColor = System.Drawing.Color.White;
            this.Contenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenido.Location = new System.Drawing.Point(220, 24);
            this.Contenido.Name = "Contenido";
            this.Contenido.Size = new System.Drawing.Size(1080, 626);
            this.Contenido.TabIndex = 2;
            // 
            // ImgUser
            // 
            this.ImgUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImgUser.Location = new System.Drawing.Point(23, 9);
            this.ImgUser.Name = "ImgUser";
            this.ImgUser.Size = new System.Drawing.Size(180, 180);
            this.ImgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgUser.TabIndex = 0;
            this.ImgUser.TabStop = false;
            this.ImgUser.Click += new System.EventHandler(this.ImgUser_Click_1);
            // 
            // FInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.Contenido);
            this.Controls.Add(this.LeftMenu);
            this.Controls.Add(this.TopBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FInicio_Load);
            this.TopBarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtCerrar)).EndInit();
            this.LeftMenu.ResumeLayout(false);
            this.LeftMenu.PerformLayout();
            this.PSubreportes.ResumeLayout(false);
            this.PSubProductos1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBarra;
        private System.Windows.Forms.PictureBox BtCerrar;
        private System.Windows.Forms.Panel LeftMenu;
        private System.Windows.Forms.Panel Contenido;
        private System.Windows.Forms.PictureBox BtRes;
        private System.Windows.Forms.PictureBox BtMin;
        private System.Windows.Forms.PictureBox BtMax;
        private System.Windows.Forms.Button BtProductos;
        private System.Windows.Forms.Button BtReportes;
        private System.Windows.Forms.Panel PSubProductos1;
        private System.Windows.Forms.Button BtAdministrarPro;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel PSubreportes;
        private System.Windows.Forms.Button BtReporteMov;
        private System.Windows.Forms.Button BtRepoInv;
        private System.Windows.Forms.Button BtLogout;
        private System.Windows.Forms.Label TxtRol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private PictureBoxRounded ImgUser;
    }
}

