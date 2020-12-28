namespace Presentacion
{
    partial class FLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BtMin = new System.Windows.Forms.PictureBox();
            this.BtClose = new System.Windows.Forms.PictureBox();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LblError = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.BtMin);
            this.panel1.Controls.Add(this.BtClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 255);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(94, 44);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 150);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // BtMin
            // 
            this.BtMin.Image = ((System.Drawing.Image)(resources.GetObject("BtMin.Image")));
            this.BtMin.Location = new System.Drawing.Point(271, 3);
            this.BtMin.Name = "BtMin";
            this.BtMin.Size = new System.Drawing.Size(25, 25);
            this.BtMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtMin.TabIndex = 8;
            this.BtMin.TabStop = false;
            this.BtMin.Click += new System.EventHandler(this.BtMin_Click);
            // 
            // BtClose
            // 
            this.BtClose.Image = ((System.Drawing.Image)(resources.GetObject("BtClose.Image")));
            this.BtClose.Location = new System.Drawing.Point(302, 3);
            this.BtClose.Name = "BtClose";
            this.BtClose.Size = new System.Drawing.Size(25, 25);
            this.BtClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtClose.TabIndex = 7;
            this.BtClose.TabStop = false;
            this.BtClose.Click += new System.EventHandler(this.BtClose_Click);
            // 
            // TxtUser
            // 
            this.TxtUser.BackColor = System.Drawing.SystemColors.MenuText;
            this.TxtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUser.Font = new System.Drawing.Font("DIN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUser.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtUser.Location = new System.Drawing.Point(12, 398);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(306, 20);
            this.TxtUser.TabIndex = 1;
            this.TxtUser.Text = "Usuario";
            this.TxtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtUser.Enter += new System.EventHandler(this.TxtUser_Enter);
            this.TxtUser.Leave += new System.EventHandler(this.TxtUser_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(12, 424);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 1);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Location = new System.Drawing.Point(12, 504);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(306, 1);
            this.panel3.TabIndex = 4;
            // 
            // TxtPass
            // 
            this.TxtPass.BackColor = System.Drawing.SystemColors.MenuText;
            this.TxtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPass.Font = new System.Drawing.Font("DIN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPass.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtPass.Location = new System.Drawing.Point(12, 478);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(306, 20);
            this.TxtPass.TabIndex = 2;
            this.TxtPass.Text = "Contraseña";
            this.TxtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPass.Enter += new System.EventHandler(this.TxtPass_Enter);
            this.TxtPass.Leave += new System.EventHandler(this.TxtPass_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DIN", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(128, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "LOGIN";
            // 
            // BtLogin
            // 
            this.BtLogin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtLogin.FlatAppearance.BorderSize = 0;
            this.BtLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.BtLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.BtLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtLogin.Font = new System.Drawing.Font("DIN", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtLogin.Location = new System.Drawing.Point(12, 553);
            this.BtLogin.Name = "BtLogin";
            this.BtLogin.Size = new System.Drawing.Size(306, 30);
            this.BtLogin.TabIndex = 0;
            this.BtLogin.Text = "ACCEDER";
            this.BtLogin.UseVisualStyleBackColor = false;
            this.BtLogin.Click += new System.EventHandler(this.BtLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 629);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.Font = new System.Drawing.Font("DIN", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblError.ForeColor = System.Drawing.Color.Brown;
            this.LblError.Location = new System.Drawing.Point(28, 521);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(35, 14);
            this.LblError.TabIndex = 7;
            this.LblError.Text = "Error";
            this.LblError.Visible = false;
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(330, 680);
            this.Controls.Add(this.LblError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtLogin;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox BtMin;
        private System.Windows.Forms.PictureBox BtClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblError;
    }
}

