namespace Presentacion
{
    partial class AdministrarUsuarios
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
            this.LblAdminUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblAdminUser
            // 
            this.LblAdminUser.AutoSize = true;
            this.LblAdminUser.Font = new System.Drawing.Font("DIN", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAdminUser.Location = new System.Drawing.Point(151, 64);
            this.LblAdminUser.Name = "LblAdminUser";
            this.LblAdminUser.Size = new System.Drawing.Size(286, 34);
            this.LblAdminUser.TabIndex = 0;
            this.LblAdminUser.Text = "Administrar usuarios";
            // 
            // AdministrarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 587);
            this.Controls.Add(this.LblAdminUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdministrarUsuarios";
            this.Text = "AdministrarUsuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAdminUser;
    }
}