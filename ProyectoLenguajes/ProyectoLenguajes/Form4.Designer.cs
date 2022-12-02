namespace ProyectoLenguajes
{
    partial class Form4
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
            this.btnConsultar = new System.Windows.Forms.Button();
            this.bicisGrid = new System.Windows.Forms.DataGridView();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnAddBike = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bicisGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Tan;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(16, 25);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(168, 70);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // bicisGrid
            // 
            this.bicisGrid.BackgroundColor = System.Drawing.Color.DarkOliveGreen;
            this.bicisGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bicisGrid.Location = new System.Drawing.Point(17, 117);
            this.bicisGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bicisGrid.Name = "bicisGrid";
            this.bicisGrid.RowHeadersWidth = 51;
            this.bicisGrid.Size = new System.Drawing.Size(1257, 614);
            this.bicisGrid.TabIndex = 1;
            this.bicisGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bicisGrid_CellContentClick);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Tan;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(1105, 25);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(168, 70);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnAddBike
            // 
            this.btnAddBike.BackColor = System.Drawing.Color.Tan;
            this.btnAddBike.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddBike.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBike.Location = new System.Drawing.Point(223, 25);
            this.btnAddBike.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddBike.Name = "btnAddBike";
            this.btnAddBike.Size = new System.Drawing.Size(168, 71);
            this.btnAddBike.TabIndex = 3;
            this.btnAddBike.Text = "Agregar Bicicleta";
            this.btnAddBike.UseVisualStyleBackColor = false;
            this.btnAddBike.Click += new System.EventHandler(this.btnAddBike_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoLenguajes.Properties.Resources.imgBanner;
            this.ClientSize = new System.Drawing.Size(1289, 746);
            this.Controls.Add(this.btnAddBike);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.bicisGrid);
            this.Controls.Add(this.btnConsultar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1307, 900);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.bicisGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView bicisGrid;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnAddBike;
    }
}