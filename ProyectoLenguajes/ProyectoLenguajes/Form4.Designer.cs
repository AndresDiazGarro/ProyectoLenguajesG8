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
            this.btnDelBike = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bicisGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Tan;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(12, 20);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(126, 57);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // bicisGrid
            // 
            this.bicisGrid.BackgroundColor = System.Drawing.Color.DarkOliveGreen;
            this.bicisGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bicisGrid.Location = new System.Drawing.Point(7, 95);
            this.bicisGrid.Name = "bicisGrid";
            this.bicisGrid.RowHeadersWidth = 51;
            this.bicisGrid.Size = new System.Drawing.Size(950, 500);
            this.bicisGrid.TabIndex = 1;
            this.bicisGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bicisGrid_CellClick);
            this.bicisGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bicisGrid_CellContentClick);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Tan;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(820, 20);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(126, 57);
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
            this.btnAddBike.Location = new System.Drawing.Point(167, 20);
            this.btnAddBike.Name = "btnAddBike";
            this.btnAddBike.Size = new System.Drawing.Size(126, 58);
            this.btnAddBike.TabIndex = 3;
            this.btnAddBike.Text = "Agregar Bicicleta";
            this.btnAddBike.UseVisualStyleBackColor = false;
            this.btnAddBike.Click += new System.EventHandler(this.btnAddBike_Click);
            // 
            // btnDelBike
            // 
            this.btnDelBike.BackColor = System.Drawing.Color.Tan;
            this.btnDelBike.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelBike.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelBike.Location = new System.Drawing.Point(464, 20);
            this.btnDelBike.Name = "btnDelBike";
            this.btnDelBike.Size = new System.Drawing.Size(126, 58);
            this.btnDelBike.TabIndex = 4;
            this.btnDelBike.Text = "Eliminar Bicicleta";
            this.btnDelBike.UseVisualStyleBackColor = false;
            this.btnDelBike.Click += new System.EventHandler(this.btnDelBike_Click);
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.BackColor = System.Drawing.Color.Tan;
            this.btn_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Actualizar.Location = new System.Drawing.Point(315, 20);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(126, 58);
            this.btn_Actualizar.TabIndex = 5;
            this.btn_Actualizar.Text = "Actualizar Bicicleta";
            this.btn_Actualizar.UseVisualStyleBackColor = false;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoLenguajes.Properties.Resources.imgBanner;
            this.ClientSize = new System.Drawing.Size(929, 606);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.btnDelBike);
            this.Controls.Add(this.btnAddBike);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.bicisGrid);
            this.Controls.Add(this.btnConsultar);
            this.MaximumSize = new System.Drawing.Size(984, 739);
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
        private System.Windows.Forms.Button btnDelBike;
        private System.Windows.Forms.Button btn_Actualizar;
    }
}