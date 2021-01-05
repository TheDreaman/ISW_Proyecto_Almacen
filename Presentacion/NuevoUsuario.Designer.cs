﻿namespace Presentacion
{
    partial class NuevoUsuario
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
            this.matri = new System.Windows.Forms.TextBox();
            this.nomb = new System.Windows.Forms.TextBox();
            this.corre = new System.Windows.Forms.TextBox();
            this.contrase = new System.Windows.Forms.TextBox();
            this.fot = new System.Windows.Forms.TextBox();
            this.AgregarUsuario = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Matricula = new System.Windows.Forms.Label();
            this.Rol = new System.Windows.Forms.Label();
            this.Foto = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.Correo = new System.Windows.Forms.Label();
            this.Contraseña = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Roles = new System.Windows.Forms.ComboBox();
            this.car = new System.Windows.Forms.TextBox();
            this.ape = new System.Windows.Forms.TextBox();
            this.nusu = new System.Windows.Forms.TextBox();
            this.cargo = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.Label();
            this.NUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // matri
            // 
            this.matri.Location = new System.Drawing.Point(91, 105);
            this.matri.Name = "matri";
            this.matri.Size = new System.Drawing.Size(276, 20);
            this.matri.TabIndex = 0;
            this.matri.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nomb
            // 
            this.nomb.Location = new System.Drawing.Point(91, 170);
            this.nomb.Name = "nomb";
            this.nomb.Size = new System.Drawing.Size(276, 20);
            this.nomb.TabIndex = 1;
            this.nomb.TextChanged += new System.EventHandler(this.nomb_TextChanged);
            // 
            // corre
            // 
            this.corre.Location = new System.Drawing.Point(445, 231);
            this.corre.Name = "corre";
            this.corre.Size = new System.Drawing.Size(276, 20);
            this.corre.TabIndex = 3;
            this.corre.TextChanged += new System.EventHandler(this.corre_TextChanged);
            // 
            // contrase
            // 
            this.contrase.Location = new System.Drawing.Point(445, 293);
            this.contrase.Name = "contrase";
            this.contrase.Size = new System.Drawing.Size(276, 20);
            this.contrase.TabIndex = 4;
            this.contrase.TextChanged += new System.EventHandler(this.contrase_TextChanged);
            // 
            // fot
            // 
            this.fot.Location = new System.Drawing.Point(91, 231);
            this.fot.Name = "fot";
            this.fot.Size = new System.Drawing.Size(276, 20);
            this.fot.TabIndex = 5;
            this.fot.TextChanged += new System.EventHandler(this.fot_TextChanged);
            // 
            // AgregarUsuario
            // 
            this.AgregarUsuario.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarUsuario.Location = new System.Drawing.Point(357, 357);
            this.AgregarUsuario.Name = "AgregarUsuario";
            this.AgregarUsuario.Size = new System.Drawing.Size(194, 53);
            this.AgregarUsuario.TabIndex = 6;
            this.AgregarUsuario.Text = "Agregar Usuario";
            this.AgregarUsuario.UseVisualStyleBackColor = false;
            this.AgregarUsuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.Location = new System.Drawing.Point(582, 357);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(193, 53);
            this.Cancelar.TabIndex = 7;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Matricula
            // 
            this.Matricula.AutoSize = true;
            this.Matricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Matricula.Location = new System.Drawing.Point(86, 77);
            this.Matricula.Name = "Matricula";
            this.Matricula.Size = new System.Drawing.Size(100, 25);
            this.Matricula.TabIndex = 8;
            this.Matricula.Text = "Matricula";
            this.Matricula.Click += new System.EventHandler(this.label1_Click);
            // 
            // Rol
            // 
            this.Rol.AutoSize = true;
            this.Rol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rol.Location = new System.Drawing.Point(88, 265);
            this.Rol.Name = "Rol";
            this.Rol.Size = new System.Drawing.Size(44, 25);
            this.Rol.TabIndex = 9;
            this.Rol.Text = "Rol";
            // 
            // Foto
            // 
            this.Foto.AutoSize = true;
            this.Foto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Foto.Location = new System.Drawing.Point(88, 203);
            this.Foto.Name = "Foto";
            this.Foto.Size = new System.Drawing.Size(55, 25);
            this.Foto.TabIndex = 10;
            this.Foto.Text = "Foto";
            this.Foto.Click += new System.EventHandler(this.label2_Click);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(88, 140);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(87, 25);
            this.Nombre.TabIndex = 11;
            this.Nombre.Text = "Nombre";
            // 
            // Correo
            // 
            this.Correo.AutoSize = true;
            this.Correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Correo.Location = new System.Drawing.Point(440, 203);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(77, 25);
            this.Correo.TabIndex = 12;
            this.Correo.Text = "Correo";
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSize = true;
            this.Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contraseña.Location = new System.Drawing.Point(440, 265);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(123, 25);
            this.Contraseña.TabIndex = 13;
            this.Contraseña.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 42);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nuevo Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Roles
            // 
            this.Roles.FormattingEnabled = true;
            this.Roles.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.Roles.Location = new System.Drawing.Point(91, 293);
            this.Roles.Name = "Roles";
            this.Roles.Size = new System.Drawing.Size(203, 21);
            this.Roles.TabIndex = 15;
            this.Roles.SelectedIndexChanged += new System.EventHandler(this.Roles_SelectedIndexChanged);
            // 
            // car
            // 
            this.car.Location = new System.Drawing.Point(91, 357);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(203, 20);
            this.car.TabIndex = 27;
            this.car.TextChanged += new System.EventHandler(this.car_TextChanged);
            // 
            // ape
            // 
            this.ape.Location = new System.Drawing.Point(445, 170);
            this.ape.Name = "ape";
            this.ape.Size = new System.Drawing.Size(276, 20);
            this.ape.TabIndex = 26;
            this.ape.TextChanged += new System.EventHandler(this.ape_TextChanged);
            // 
            // nusu
            // 
            this.nusu.Location = new System.Drawing.Point(445, 105);
            this.nusu.Name = "nusu";
            this.nusu.Size = new System.Drawing.Size(276, 20);
            this.nusu.TabIndex = 25;
            this.nusu.TextChanged += new System.EventHandler(this.nusu_TextChanged);
            // 
            // cargo
            // 
            this.cargo.AutoSize = true;
            this.cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargo.Location = new System.Drawing.Point(88, 329);
            this.cargo.Name = "cargo";
            this.cargo.Size = new System.Drawing.Size(70, 25);
            this.cargo.TabIndex = 24;
            this.cargo.Text = "Cargo";
            this.cargo.Click += new System.EventHandler(this.cargo_Click);
            // 
            // apellido
            // 
            this.apellido.AutoSize = true;
            this.apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido.Location = new System.Drawing.Point(440, 140);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(89, 25);
            this.apellido.TabIndex = 23;
            this.apellido.Text = "Apellido";
            this.apellido.Click += new System.EventHandler(this.apellido_Click);
            // 
            // NUsuario
            // 
            this.NUsuario.AutoSize = true;
            this.NUsuario.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUsuario.Location = new System.Drawing.Point(440, 77);
            this.NUsuario.Name = "NUsuario";
            this.NUsuario.Size = new System.Drawing.Size(113, 25);
            this.NUsuario.TabIndex = 22;
            this.NUsuario.Text = "UserName";
            this.NUsuario.Click += new System.EventHandler(this.NUsuario_Click);
            // 
            // NuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.car);
            this.Controls.Add(this.ape);
            this.Controls.Add(this.nusu);
            this.Controls.Add(this.cargo);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.NUsuario);
            this.Controls.Add(this.Roles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Foto);
            this.Controls.Add(this.Rol);
            this.Controls.Add(this.Matricula);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.AgregarUsuario);
            this.Controls.Add(this.fot);
            this.Controls.Add(this.contrase);
            this.Controls.Add(this.corre);
            this.Controls.Add(this.nomb);
            this.Controls.Add(this.matri);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoUsuario";
            this.Load += new System.EventHandler(this.NuevoUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AgregarUsuario;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Label Matricula;
        private System.Windows.Forms.Label Rol;
        private System.Windows.Forms.Label Foto;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Correo;
        private System.Windows.Forms.Label Contraseña;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox matri;
        public System.Windows.Forms.TextBox nomb;
        public System.Windows.Forms.TextBox corre;
        public System.Windows.Forms.TextBox contrase;
        public System.Windows.Forms.TextBox fot;
        public System.Windows.Forms.ComboBox Roles;
        public System.Windows.Forms.TextBox car;
        public System.Windows.Forms.TextBox ape;
        public System.Windows.Forms.TextBox nusu;
        private System.Windows.Forms.Label cargo;
        private System.Windows.Forms.Label apellido;
        private System.Windows.Forms.Label NUsuario;
    }
}