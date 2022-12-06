namespace ProyectoLenguajes
{
    partial class Taller
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonInsertar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewTaller = new System.Windows.Forms.DataGridView();
            this.ID_BICICLETA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE_FRENOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE_TRANSMISION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE_SUSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE_RUEDAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE_MARCO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE_MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROBLEMAS_REPORTADOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBSERVACIONES_MECANICO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MECANICO_REVISION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_REVISION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bicisGrid = new System.Windows.Forms.DataGridView();
            this.btnConsultarEnInventario = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTaller)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bicisGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.buttonInsertar);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.dataGridViewTaller);
            this.panel4.Location = new System.Drawing.Point(15, 380);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(917, 245);
            this.panel4.TabIndex = 11;
            // 
            // buttonInsertar
            // 
            this.buttonInsertar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonInsertar.BackColor = System.Drawing.Color.Snow;
            this.buttonInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertar.Location = new System.Drawing.Point(79, 44);
            this.buttonInsertar.Name = "buttonInsertar";
            this.buttonInsertar.Size = new System.Drawing.Size(94, 28);
            this.buttonInsertar.TabIndex = 7;
            this.buttonInsertar.Text = "Insertar";
            this.buttonInsertar.UseVisualStyleBackColor = false;
            this.buttonInsertar.Click += new System.EventHandler(this.buttonInsertar_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Snow;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(911, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingresar Bicicletas al Talller";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewTaller
            // 
            this.dataGridViewTaller.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTaller.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridViewTaller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTaller.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_BICICLETA,
            this.NOMBRE,
            this.NOMBRE_FRENOS,
            this.NOMBRE_TRANSMISION,
            this.NOMBRE_SUSP,
            this.NOMBRE_RUEDAS,
            this.NOMBRE_MARCO,
            this.NOMBRE_MARCA,
            this.PROBLEMAS_REPORTADOS,
            this.OBSERVACIONES_MECANICO,
            this.MECANICO_REVISION,
            this.PRECIO_REVISION});
            this.dataGridViewTaller.Location = new System.Drawing.Point(-3, 91);
            this.dataGridViewTaller.Name = "dataGridViewTaller";
            this.dataGridViewTaller.RowHeadersWidth = 51;
            this.dataGridViewTaller.Size = new System.Drawing.Size(917, 154);
            this.dataGridViewTaller.TabIndex = 4;
            // 
            // ID_BICICLETA
            // 
            this.ID_BICICLETA.HeaderText = "ID Bicicleta";
            this.ID_BICICLETA.MinimumWidth = 6;
            this.ID_BICICLETA.Name = "ID_BICICLETA";
            this.ID_BICICLETA.Width = 125;
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "Nombre";
            this.NOMBRE.MinimumWidth = 6;
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.Width = 125;
            // 
            // NOMBRE_FRENOS
            // 
            this.NOMBRE_FRENOS.HeaderText = "Frenos";
            this.NOMBRE_FRENOS.MinimumWidth = 6;
            this.NOMBRE_FRENOS.Name = "NOMBRE_FRENOS";
            this.NOMBRE_FRENOS.Width = 125;
            // 
            // NOMBRE_TRANSMISION
            // 
            this.NOMBRE_TRANSMISION.HeaderText = "Transmision";
            this.NOMBRE_TRANSMISION.MinimumWidth = 6;
            this.NOMBRE_TRANSMISION.Name = "NOMBRE_TRANSMISION";
            this.NOMBRE_TRANSMISION.Width = 125;
            // 
            // NOMBRE_SUSP
            // 
            this.NOMBRE_SUSP.HeaderText = "Suspencion";
            this.NOMBRE_SUSP.MinimumWidth = 6;
            this.NOMBRE_SUSP.Name = "NOMBRE_SUSP";
            this.NOMBRE_SUSP.Width = 125;
            // 
            // NOMBRE_RUEDAS
            // 
            this.NOMBRE_RUEDAS.HeaderText = "Ruedas";
            this.NOMBRE_RUEDAS.MinimumWidth = 6;
            this.NOMBRE_RUEDAS.Name = "NOMBRE_RUEDAS";
            this.NOMBRE_RUEDAS.Width = 125;
            // 
            // NOMBRE_MARCO
            // 
            this.NOMBRE_MARCO.HeaderText = "Marco";
            this.NOMBRE_MARCO.MinimumWidth = 6;
            this.NOMBRE_MARCO.Name = "NOMBRE_MARCO";
            this.NOMBRE_MARCO.Width = 125;
            // 
            // NOMBRE_MARCA
            // 
            this.NOMBRE_MARCA.HeaderText = "Marca";
            this.NOMBRE_MARCA.MinimumWidth = 6;
            this.NOMBRE_MARCA.Name = "NOMBRE_MARCA";
            this.NOMBRE_MARCA.Width = 125;
            // 
            // PROBLEMAS_REPORTADOS
            // 
            this.PROBLEMAS_REPORTADOS.HeaderText = "Problemas Reportados Cliente";
            this.PROBLEMAS_REPORTADOS.MinimumWidth = 6;
            this.PROBLEMAS_REPORTADOS.Name = "PROBLEMAS_REPORTADOS";
            this.PROBLEMAS_REPORTADOS.Width = 125;
            // 
            // OBSERVACIONES_MECANICO
            // 
            this.OBSERVACIONES_MECANICO.HeaderText = "Observaciones del Mecanico";
            this.OBSERVACIONES_MECANICO.MinimumWidth = 6;
            this.OBSERVACIONES_MECANICO.Name = "OBSERVACIONES_MECANICO";
            this.OBSERVACIONES_MECANICO.Width = 125;
            // 
            // MECANICO_REVISION
            // 
            this.MECANICO_REVISION.HeaderText = "Nombre Mecanico";
            this.MECANICO_REVISION.MinimumWidth = 6;
            this.MECANICO_REVISION.Name = "MECANICO_REVISION";
            this.MECANICO_REVISION.Width = 125;
            // 
            // PRECIO_REVISION
            // 
            this.PRECIO_REVISION.HeaderText = "Precio de la Revision";
            this.PRECIO_REVISION.MinimumWidth = 6;
            this.PRECIO_REVISION.Name = "PRECIO_REVISION";
            this.PRECIO_REVISION.Width = 125;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.buttonEliminar);
            this.panel3.Controls.Add(this.buttonActualizar);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.bicisGrid);
            this.panel3.Controls.Add(this.btnConsultarEnInventario);
            this.panel3.Location = new System.Drawing.Point(12, 115);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(917, 259);
            this.panel3.TabIndex = 10;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonEliminar.BackColor = System.Drawing.Color.Snow;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(279, 46);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(94, 28);
            this.buttonEliminar.TabIndex = 9;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonActualizar.BackColor = System.Drawing.Color.Snow;
            this.buttonActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizar.Location = new System.Drawing.Point(179, 46);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(94, 28);
            this.buttonActualizar.TabIndex = 8;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = false;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Snow;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(910, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bicicletas en Inventario";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bicisGrid
            // 
            this.bicisGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bicisGrid.BackgroundColor = System.Drawing.Color.Honeydew;
            this.bicisGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bicisGrid.Location = new System.Drawing.Point(0, 89);
            this.bicisGrid.Name = "bicisGrid";
            this.bicisGrid.RowHeadersWidth = 51;
            this.bicisGrid.Size = new System.Drawing.Size(917, 154);
            this.bicisGrid.TabIndex = 4;
            // 
            // btnConsultarEnInventario
            // 
            this.btnConsultarEnInventario.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConsultarEnInventario.BackColor = System.Drawing.Color.Snow;
            this.btnConsultarEnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultarEnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarEnInventario.Location = new System.Drawing.Point(79, 46);
            this.btnConsultarEnInventario.Name = "btnConsultarEnInventario";
            this.btnConsultarEnInventario.Size = new System.Drawing.Size(94, 28);
            this.btnConsultarEnInventario.TabIndex = 3;
            this.btnConsultarEnInventario.Text = "Consultar";
            this.btnConsultarEnInventario.UseVisualStyleBackColor = false;
            this.btnConsultarEnInventario.Click += new System.EventHandler(this.btnConsultarEnInventario_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnRegresar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(917, 90);
            this.panel2.TabIndex = 9;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Tan;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(787, 3);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(126, 57);
            this.btnRegresar.TabIndex = 9;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Taller";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Taller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoLenguajes.Properties.Resources.imgBanner;
            this.ClientSize = new System.Drawing.Size(945, 645);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Taller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taller";
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTaller)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bicisGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonInsertar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewTaller;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_BICICLETA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_FRENOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_TRANSMISION;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_SUSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_RUEDAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_MARCO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROBLEMAS_REPORTADOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVACIONES_MECANICO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MECANICO_REVISION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_REVISION;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView bicisGrid;
        private System.Windows.Forms.Button btnConsultarEnInventario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label1;
    }
}