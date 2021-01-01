namespace Presentacion
{
    partial class ProdAdministrar
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
            this.LblProAdmin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblProAdmin
            // 
            this.LblProAdmin.AutoSize = true;
            this.LblProAdmin.Font = new System.Drawing.Font("DIN", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProAdmin.Location = new System.Drawing.Point(153, 84);
            this.LblProAdmin.Name = "LblProAdmin";
            this.LblProAdmin.Size = new System.Drawing.Size(274, 30);
            this.LblProAdmin.TabIndex = 0;
            this.LblProAdmin.Text = "Administrar productos";
            // 
            // ProdAdministrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 626);
            this.Controls.Add(this.LblProAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProdAdministrar";
            this.Text = "ProdAdministrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblProAdmin;
    }
}