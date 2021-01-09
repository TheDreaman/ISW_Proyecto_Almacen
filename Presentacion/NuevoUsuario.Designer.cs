namespace Presentacion
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
            this.AgregarUsuario = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Matricula = new System.Windows.Forms.Label();
            this.Rol = new System.Windows.Forms.Label();
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.foto1 = new System.Windows.Forms.Button();
            this.PicNewUser = new Presentacion.PictureBoxRounded();
            ((System.ComponentModel.ISupportInitialize)(this.PicNewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // matri
            // 
            this.matri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.matri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matri.Font = new System.Drawing.Font("DIN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matri.ForeColor = System.Drawing.Color.White;
            this.matri.Location = new System.Drawing.Point(117, 67);
            this.matri.Name = "matri";
            this.matri.Size = new System.Drawing.Size(276, 20);
            this.matri.TabIndex = 0;
            this.matri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nomb
            // 
            this.nomb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.nomb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nomb.Font = new System.Drawing.Font("DIN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomb.ForeColor = System.Drawing.Color.White;
            this.nomb.Location = new System.Drawing.Point(117, 111);
            this.nomb.Name = "nomb";
            this.nomb.Size = new System.Drawing.Size(276, 20);
            this.nomb.TabIndex = 1;
            this.nomb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // corre
            // 
            this.corre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.corre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.corre.Font = new System.Drawing.Font("DIN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.corre.ForeColor = System.Drawing.Color.White;
            this.corre.Location = new System.Drawing.Point(117, 205);
            this.corre.Name = "corre";
            this.corre.Size = new System.Drawing.Size(276, 20);
            this.corre.TabIndex = 3;
            this.corre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contrase
            // 
            this.contrase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.contrase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contrase.Font = new System.Drawing.Font("DIN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrase.ForeColor = System.Drawing.Color.White;
            this.contrase.Location = new System.Drawing.Point(117, 297);
            this.contrase.Name = "contrase";
            this.contrase.Size = new System.Drawing.Size(276, 20);
            this.contrase.TabIndex = 5;
            this.contrase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AgregarUsuario
            // 
            this.AgregarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.AgregarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.AgregarUsuario.FlatAppearance.BorderSize = 0;
            this.AgregarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.AgregarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.AgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarUsuario.Font = new System.Drawing.Font("DIN", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarUsuario.Location = new System.Drawing.Point(442, 375);
            this.AgregarUsuario.Name = "AgregarUsuario";
            this.AgregarUsuario.Size = new System.Drawing.Size(158, 39);
            this.AgregarUsuario.TabIndex = 9;
            this.AgregarUsuario.Text = "Agregar ";
            this.AgregarUsuario.UseVisualStyleBackColor = false;
            this.AgregarUsuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Cancelar.FlatAppearance.BorderSize = 0;
            this.Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelar.Font = new System.Drawing.Font("DIN", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.Location = new System.Drawing.Point(606, 375);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(158, 39);
            this.Cancelar.TabIndex = 10;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Matricula
            // 
            this.Matricula.AutoSize = true;
            this.Matricula.Font = new System.Drawing.Font("DIN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Matricula.Location = new System.Drawing.Point(32, 67);
            this.Matricula.Name = "Matricula";
            this.Matricula.Size = new System.Drawing.Size(76, 20);
            this.Matricula.TabIndex = 8;
            this.Matricula.Text = "Matricula";
            // 
            // Rol
            // 
            this.Rol.AutoSize = true;
            this.Rol.Font = new System.Drawing.Font("DIN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rol.Location = new System.Drawing.Point(75, 338);
            this.Rol.Name = "Rol";
            this.Rol.Size = new System.Drawing.Size(33, 20);
            this.Rol.TabIndex = 9;
            this.Rol.Text = "Rol";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("DIN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(32, 109);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(67, 20);
            this.Nombre.TabIndex = 11;
            this.Nombre.Text = "Nombre";
            // 
            // Correo
            // 
            this.Correo.AutoSize = true;
            this.Correo.Font = new System.Drawing.Font("DIN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Correo.Location = new System.Drawing.Point(32, 205);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(57, 20);
            this.Correo.TabIndex = 12;
            this.Correo.Text = "Correo";
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSize = true;
            this.Contraseña.Font = new System.Drawing.Font("DIN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contraseña.Location = new System.Drawing.Point(22, 297);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(89, 20);
            this.Contraseña.TabIndex = 13;
            this.Contraseña.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("DIN", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 46);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nuevo Usuario";
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // Roles
            // 
            this.Roles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Roles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Roles.Font = new System.Drawing.Font("DIN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Roles.ForeColor = System.Drawing.Color.White;
            this.Roles.FormattingEnabled = true;
            this.Roles.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.Roles.Location = new System.Drawing.Point(117, 338);
            this.Roles.Name = "Roles";
            this.Roles.Size = new System.Drawing.Size(276, 28);
            this.Roles.TabIndex = 6;
            // 
            // car
            // 
            this.car.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.car.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.car.Font = new System.Drawing.Font("DIN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.car.ForeColor = System.Drawing.Color.White;
            this.car.Location = new System.Drawing.Point(117, 385);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(276, 20);
            this.car.TabIndex = 7;
            this.car.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ape
            // 
            this.ape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ape.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ape.Font = new System.Drawing.Font("DIN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ape.ForeColor = System.Drawing.Color.White;
            this.ape.Location = new System.Drawing.Point(117, 161);
            this.ape.Name = "ape";
            this.ape.Size = new System.Drawing.Size(276, 20);
            this.ape.TabIndex = 2;
            this.ape.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nusu
            // 
            this.nusu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.nusu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nusu.Font = new System.Drawing.Font("DIN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nusu.ForeColor = System.Drawing.Color.White;
            this.nusu.Location = new System.Drawing.Point(117, 254);
            this.nusu.Name = "nusu";
            this.nusu.Size = new System.Drawing.Size(276, 20);
            this.nusu.TabIndex = 4;
            this.nusu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cargo
            // 
            this.cargo.AutoSize = true;
            this.cargo.Font = new System.Drawing.Font("DIN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargo.Location = new System.Drawing.Point(60, 385);
            this.cargo.Name = "cargo";
            this.cargo.Size = new System.Drawing.Size(51, 20);
            this.cargo.TabIndex = 24;
            this.cargo.Text = "Cargo";
            // 
            // apellido
            // 
            this.apellido.AutoSize = true;
            this.apellido.Font = new System.Drawing.Font("DIN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido.Location = new System.Drawing.Point(32, 159);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(67, 20);
            this.apellido.TabIndex = 23;
            this.apellido.Text = "Apellido";
            // 
            // NUsuario
            // 
            this.NUsuario.AutoSize = true;
            this.NUsuario.BackColor = System.Drawing.Color.Transparent;
            this.NUsuario.Font = new System.Drawing.Font("DIN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUsuario.Location = new System.Drawing.Point(28, 243);
            this.NUsuario.Name = "NUsuario";
            this.NUsuario.Size = new System.Drawing.Size(83, 40);
            this.NUsuario.TabIndex = 22;
            this.NUsuario.Text = "Nombre \r\nde usuario";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "fot";
            this.openFileDialog1.Filter = "JPG|*.jpg|PNG|*.png";
            this.openFileDialog1.Title = "fot";
            // 
            // foto1
            // 
            this.foto1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.foto1.FlatAppearance.BorderSize = 0;
            this.foto1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.foto1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.foto1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.foto1.Font = new System.Drawing.Font("DIN", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foto1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.foto1.Location = new System.Drawing.Point(493, 327);
            this.foto1.Name = "foto1";
            this.foto1.Size = new System.Drawing.Size(250, 31);
            this.foto1.TabIndex = 8;
            this.foto1.Text = "Seleccionar Foto";
            this.foto1.UseVisualStyleBackColor = false;
            this.foto1.Click += new System.EventHandler(this.foto1_Click);
            // 
            // PicNewUser
            // 
            this.PicNewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.PicNewUser.Location = new System.Drawing.Point(493, 67);
            this.PicNewUser.Name = "PicNewUser";
            this.PicNewUser.Size = new System.Drawing.Size(250, 250);
            this.PicNewUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicNewUser.TabIndex = 30;
            this.PicNewUser.TabStop = false;
            // 
            // NuevoUsuario
            // 
            this.AcceptButton = this.AgregarUsuario;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PicNewUser);
            this.Controls.Add(this.foto1);
            this.Controls.Add(this.car);
            this.Controls.Add(this.ape);
            this.Controls.Add(this.nusu);
            this.Controls.Add(this.cargo);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.NUsuario);
            this.Controls.Add(this.Roles);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Rol);
            this.Controls.Add(this.Matricula);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.AgregarUsuario);
            this.Controls.Add(this.contrase);
            this.Controls.Add(this.corre);
            this.Controls.Add(this.nomb);
            this.Controls.Add(this.matri);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoUsuario";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoUsuario";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NuevoUsuario_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.PicNewUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AgregarUsuario;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Label Matricula;
        private System.Windows.Forms.Label Rol;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Correo;
        private System.Windows.Forms.Label Contraseña;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox matri;
        public System.Windows.Forms.TextBox nomb;
        public System.Windows.Forms.TextBox corre;
        public System.Windows.Forms.TextBox contrase;
        public System.Windows.Forms.ComboBox Roles;
        public System.Windows.Forms.TextBox car;
        public System.Windows.Forms.TextBox ape;
        public System.Windows.Forms.TextBox nusu;
        private System.Windows.Forms.Label cargo;
        private System.Windows.Forms.Label apellido;
        private System.Windows.Forms.Label NUsuario;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button foto1;
        private PictureBoxRounded PicNewUser;
    }
}