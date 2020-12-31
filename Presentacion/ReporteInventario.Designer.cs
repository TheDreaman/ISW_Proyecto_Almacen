namespace Presentacion
{
    partial class ReporteInventario
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
            this.LblRepoInv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblRepoInv
            // 
            this.LblRepoInv.AutoSize = true;
            this.LblRepoInv.Font = new System.Drawing.Font("DIN", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRepoInv.Location = new System.Drawing.Point(225, 90);
            this.LblRepoInv.Name = "LblRepoInv";
            this.LblRepoInv.Size = new System.Drawing.Size(292, 34);
            this.LblRepoInv.TabIndex = 0;
            this.LblRepoInv.Text = "Reporte de inventario";
            // 
            // ReporteInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 587);
            this.Controls.Add(this.LblRepoInv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReporteInventario";
            this.Text = "ReporteInventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblRepoInv;
    }
}