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
            this.LblRepoMov = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblRepoMov
            // 
            this.LblRepoMov.AutoSize = true;
            this.LblRepoMov.Font = new System.Drawing.Font("DIN", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRepoMov.Location = new System.Drawing.Point(145, 87);
            this.LblRepoMov.Name = "LblRepoMov";
            this.LblRepoMov.Size = new System.Drawing.Size(328, 34);
            this.LblRepoMov.TabIndex = 0;
            this.LblRepoMov.Text = "Reporte de movimientos";
            // 
            // ReporteMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 587);
            this.Controls.Add(this.LblRepoMov);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReporteMovimientos";
            this.Text = "ReporteMovimientos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblRepoMov;
    }
}