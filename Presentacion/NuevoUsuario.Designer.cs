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
            this.panel1 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.foto1 = new System.Windows.Forms.Button();
            this.PicNewUser = new Presentacion.PictureBoxRounded();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicNewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // matri
            // 
            this.matri.Location = new System.Drawing.Point(113, 82);
            this.matri.Name = "matri";
            this.matri.Size = new System.Drawing.Size(276, 20);
            this.matri.TabIndex = 0;
            // 
            // nomb
            // 
            this.nomb.Location = new System.Drawing.Point(113, 130);
            this.nomb.Name = "nomb";
            this.nomb.Size = new System.Drawing.Size(276, 20);
            this.nomb.TabIndex = 1;
            // 
            // corre
            // 
            this.corre.Location = new System.Drawing.Point(113, 224);
            this.corre.Name = "corre";
            this.corre.Size = new System.Drawing.Size(276, 20);
            this.corre.TabIndex = 3;
            // 
            // contrase
            // 
            this.contrase.Location = new System.Drawing.Point(113, 316);
            this.contrase.Name = "contrase";
            this.contrase.Size = new System.Drawing.Size(276, 20);
            this.contrase.TabIndex = 4;
            // 
            // AgregarUsuario
            // 
            this.AgregarUsuario.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarUsuario.Location = new System.Drawing.Point(420, 385);
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
            this.Cancelar.Location = new System.Drawing.Point(630, 385);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(158, 53);
            this.Cancelar.TabIndex = 7;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Matricula
            // 
            this.Matricula.AutoSize = true;
            this.Matricula.Font = new System.Drawing.Font("DIN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Matricula.Location = new System.Drawing.Point(28, 82);
            this.Matricula.Name = "Matricula";
            this.Matricula.Size = new System.Drawing.Size(76, 20);
            this.Matricula.TabIndex = 8;
            this.Matricula.Text = "Matricula";
            // 
            // Rol
            // 
            this.Rol.AutoSize = true;
            this.Rol.Font = new System.Drawing.Font("DIN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rol.Location = new System.Drawing.Point(71, 357);
            this.Rol.Name = "Rol";
            this.Rol.Size = new System.Drawing.Size(33, 20);
            this.Rol.TabIndex = 9;
            this.Rol.Text = "Rol";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("DIN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(28, 128);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(67, 20);
            this.Nombre.TabIndex = 11;
            this.Nombre.Text = "Nombre";
            // 
            // Correo
            // 
            this.Correo.AutoSize = true;
            this.Correo.Font = new System.Drawing.Font("DIN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Correo.Location = new System.Drawing.Point(28, 224);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(57, 20);
            this.Correo.TabIndex = 12;
            this.Correo.Text = "Correo";
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSize = true;
            this.Contraseña.Font = new System.Drawing.Font("DIN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contraseña.Location = new System.Drawing.Point(18, 316);
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
            this.label1.Location = new System.Drawing.Point(274, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 46);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nuevo Usuario";
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // Roles
            // 
            this.Roles.FormattingEnabled = true;
            this.Roles.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.Roles.Location = new System.Drawing.Point(113, 357);
            this.Roles.Name = "Roles";
            this.Roles.Size = new System.Drawing.Size(203, 21);
            this.Roles.TabIndex = 15;
            // 
            // car
            // 
            this.car.Location = new System.Drawing.Point(113, 404);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(203, 20);
            this.car.TabIndex = 27;
            // 
            // ape
            // 
            this.ape.Location = new System.Drawing.Point(113, 180);
            this.ape.Name = "ape";
            this.ape.Size = new System.Drawing.Size(276, 20);
            this.ape.TabIndex = 26;
            // 
            // nusu
            // 
            this.nusu.Location = new System.Drawing.Point(113, 273);
            this.nusu.Name = "nusu";
            this.nusu.Size = new System.Drawing.Size(276, 20);
            this.nusu.TabIndex = 25;
            // 
            // cargo
            // 
            this.cargo.AutoSize = true;
            this.cargo.Font = new System.Drawing.Font("DIN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargo.Location = new System.Drawing.Point(56, 404);
            this.cargo.Name = "cargo";
            this.cargo.Size = new System.Drawing.Size(51, 20);
            this.cargo.TabIndex = 24;
            this.cargo.Text = "Cargo";
            // 
            // apellido
            // 
            this.apellido.AutoSize = true;
            this.apellido.Font = new System.Drawing.Font("DIN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido.Location = new System.Drawing.Point(28, 178);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(67, 20);
            this.apellido.TabIndex = 23;
            this.apellido.Text = "Apellido";
            // 
            // NUsuario
            // 
            this.NUsuario.AutoSize = true;
            this.NUsuario.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NUsuario.Font = new System.Drawing.Font("DIN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUsuario.Location = new System.Drawing.Point(24, 262);
            this.NUsuario.Name = "NUsuario";
            this.NUsuario.Size = new System.Drawing.Size(83, 40);
            this.NUsuario.TabIndex = 22;
            this.NUsuario.Text = "Nombre \r\nde usuario";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 47);
            this.panel1.TabIndex = 28;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "fot";
            this.openFileDialog1.Filter = "JPG|*.jpg|PNG|*.png";
            this.openFileDialog1.Title = "fot";
            // 
            // foto1
            // 
            this.foto1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.foto1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.foto1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.foto1.Location = new System.Drawing.Point(493, 338);
            this.foto1.Name = "foto1";
            this.foto1.Size = new System.Drawing.Size(250, 31);
            this.foto1.TabIndex = 29;
            this.foto1.Text = "Seleccionar Foto";
            this.foto1.UseVisualStyleBackColor = false;
            this.foto1.Click += new System.EventHandler(this.foto1_Click);
            // 
            // PicNewUser
            // 
            this.PicNewUser.Location = new System.Drawing.Point(493, 82);
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
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PicNewUser);
            this.Controls.Add(this.foto1);
            this.Controls.Add(this.panel1);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoUsuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button foto1;
        private PictureBoxRounded PicNewUser;
    }
}