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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblAdminUser = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.Actualizar = new System.Windows.Forms.Button();
            this.mostrarusu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarusu)).BeginInit();
            this.SuspendLayout();
            // 
            // LblAdminUser
            // 
            this.LblAdminUser.AutoSize = true;
            this.LblAdminUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAdminUser.Location = new System.Drawing.Point(151, 64);
            this.LblAdminUser.Name = "LblAdminUser";
            this.LblAdminUser.Size = new System.Drawing.Size(281, 31);
            this.LblAdminUser.TabIndex = 0;
            this.LblAdminUser.Text = "Administrar usuarios";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(871, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Nuevo usuario";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // editar
            // 
            this.editar.BackColor = System.Drawing.Color.Black;
            this.editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.editar.Location = new System.Drawing.Point(595, 97);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(127, 35);
            this.editar.TabIndex = 10;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = false;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // eliminar
            // 
            this.eliminar.BackColor = System.Drawing.Color.Black;
            this.eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.eliminar.Location = new System.Drawing.Point(738, 97);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(127, 35);
            this.eliminar.TabIndex = 9;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = false;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // Actualizar
            // 
            this.Actualizar.BackColor = System.Drawing.Color.Black;
            this.Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Actualizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Actualizar.Location = new System.Drawing.Point(452, 97);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(127, 35);
            this.Actualizar.TabIndex = 8;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.UseVisualStyleBackColor = false;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // mostrarusu
            // 
            this.mostrarusu.AllowUserToAddRows = false;
            this.mostrarusu.AllowUserToDeleteRows = false;
            this.mostrarusu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mostrarusu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mostrarusu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mostrarusu.DefaultCellStyle = dataGridViewCellStyle2;
            this.mostrarusu.Location = new System.Drawing.Point(32, 151);
            this.mostrarusu.Name = "mostrarusu";
            this.mostrarusu.ReadOnly = true;
            this.mostrarusu.RowHeadersVisible = false;
            this.mostrarusu.Size = new System.Drawing.Size(998, 353);
            this.mostrarusu.TabIndex = 7;
            this.mostrarusu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mostrarusu_CellContentClick);
            // 
            // AdministrarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 587);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.mostrarusu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblAdminUser);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdministrarUsuarios";
            this.Text = "AdministrarUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.mostrarusu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAdminUser;
        private System.Windows.Forms.Button button1;   //hola
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button Actualizar;
        private System.Windows.Forms.DataGridView mostrarusu;
    }
}
