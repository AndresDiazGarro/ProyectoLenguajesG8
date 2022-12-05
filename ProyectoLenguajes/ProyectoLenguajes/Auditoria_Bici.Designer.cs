namespace ProyectoLenguajes
{
    partial class Auditoria_Bici
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
            this.AuditbicisGrid = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AuditbicisGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AuditbicisGrid
            // 
            this.AuditbicisGrid.BackgroundColor = System.Drawing.Color.DarkOliveGreen;
            this.AuditbicisGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AuditbicisGrid.Location = new System.Drawing.Point(188, 160);
            this.AuditbicisGrid.Name = "AuditbicisGrid";
            this.AuditbicisGrid.RowHeadersWidth = 58;
            this.AuditbicisGrid.Size = new System.Drawing.Size(590, 422);
            this.AuditbicisGrid.TabIndex = 2;
            this.AuditbicisGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AuditbicisGrid_CellContentClick);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Tan;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(10, 36);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(126, 57);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Tan;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(834, 36);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(126, 57);
            this.btnRegresar.TabIndex = 4;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Auditoria_Bici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoLenguajes.Properties.Resources.imgBanner;
            this.ClientSize = new System.Drawing.Size(966, 609);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.AuditbicisGrid);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Auditoria_Bici";
            this.Text = "Auditoria_Bici";
            ((System.ComponentModel.ISupportInitialize)(this.AuditbicisGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AuditbicisGrid;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnRegresar;
    }
}