namespace ProyectoLenguajes
{
    partial class EliminarBici
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_EliminarBici = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_idBicidel = new System.Windows.Forms.TextBox();
            this.btn2_regresarform4 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(132)))), ((int)(((byte)(35)))));
            this.panel2.Controls.Add(this.btn_EliminarBici);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_idBicidel);
            this.panel2.Location = new System.Drawing.Point(268, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(501, 301);
            this.panel2.TabIndex = 1;
            // 
            // btn_EliminarBici
            // 
            this.btn_EliminarBici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_EliminarBici.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EliminarBici.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_EliminarBici.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EliminarBici.Location = new System.Drawing.Point(201, 221);
            this.btn_EliminarBici.Name = "btn_EliminarBici";
            this.btn_EliminarBici.Size = new System.Drawing.Size(90, 37);
            this.btn_EliminarBici.TabIndex = 19;
            this.btn_EliminarBici.Text = "ELIMINAR";
            this.btn_EliminarBici.UseVisualStyleBackColor = false;
            this.btn_EliminarBici.Click += new System.EventHandler(this.btn_AgregarBici_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Bisque;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(162, 29);
            this.label10.MinimumSize = new System.Drawing.Size(90, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 35);
            this.label10.TabIndex = 18;
            this.label10.Text = "Eliminar Bicicleta";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 105);
            this.label1.MinimumSize = new System.Drawing.Size(90, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "Digite el ID de la bicicleta a eliminar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txt_idBicidel
            // 
            this.txt_idBicidel.Location = new System.Drawing.Point(202, 154);
            this.txt_idBicidel.MinimumSize = new System.Drawing.Size(90, 35);
            this.txt_idBicidel.Name = "txt_idBicidel";
            this.txt_idBicidel.Size = new System.Drawing.Size(90, 20);
            this.txt_idBicidel.TabIndex = 0;
            // 
            // btn2_regresarform4
            // 
            this.btn2_regresarform4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn2_regresarform4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2_regresarform4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2_regresarform4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2_regresarform4.Location = new System.Drawing.Point(857, 558);
            this.btn2_regresarform4.Name = "btn2_regresarform4";
            this.btn2_regresarform4.Size = new System.Drawing.Size(100, 37);
            this.btn2_regresarform4.TabIndex = 21;
            this.btn2_regresarform4.Text = "REGRESAR";
            this.btn2_regresarform4.UseVisualStyleBackColor = false;
            this.btn2_regresarform4.Click += new System.EventHandler(this.btn2_regresarform4_Click);
            // 
            // EliminarBici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoLenguajes.Properties.Resources.imgBanner;
            this.ClientSize = new System.Drawing.Size(967, 606);
            this.Controls.Add(this.btn2_regresarform4);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EliminarBici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EliminarBici";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_EliminarBici;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_idBicidel;
        private System.Windows.Forms.Button btn2_regresarform4;
    }
}