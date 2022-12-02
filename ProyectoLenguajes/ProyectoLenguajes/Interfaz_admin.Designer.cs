namespace ProyectoLenguajes
{
    partial class Interfaz_admin
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
            this.panelNavbar = new System.Windows.Forms.Panel();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnUbicacion = new System.Windows.Forms.Button();
            this.btnTaller = new System.Windows.Forms.Button();
            this.btnBicicletas = new System.Windows.Forms.Button();
            this.bannerLogo = new System.Windows.Forms.Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelNavbar.SuspendLayout();
            this.bannerLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNavbar
            // 
            this.panelNavbar.BackColor = System.Drawing.Color.Wheat;
            this.panelNavbar.Controls.Add(this.btnPerfil);
            this.panelNavbar.Controls.Add(this.btnUbicacion);
            this.panelNavbar.Controls.Add(this.btnTaller);
            this.panelNavbar.Controls.Add(this.btnBicicletas);
            this.panelNavbar.Controls.Add(this.bannerLogo);
            this.panelNavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavbar.Location = new System.Drawing.Point(0, 0);
            this.panelNavbar.Name = "panelNavbar";
            this.panelNavbar.Size = new System.Drawing.Size(942, 73);
            this.panelNavbar.TabIndex = 0;
            // 
            // btnPerfil
            // 
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.Location = new System.Drawing.Point(494, 9);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(129, 57);
            this.btnPerfil.TabIndex = 6;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUbicacion
            // 
            this.btnUbicacion.FlatAppearance.BorderSize = 0;
            this.btnUbicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbicacion.Location = new System.Drawing.Point(769, 9);
            this.btnUbicacion.Name = "btnUbicacion";
            this.btnUbicacion.Size = new System.Drawing.Size(151, 57);
            this.btnUbicacion.TabIndex = 4;
            this.btnUbicacion.Text = "Ubicación";
            this.btnUbicacion.UseVisualStyleBackColor = true;
            this.btnUbicacion.Click += new System.EventHandler(this.btnUbicacion_Click);
            // 
            // btnTaller
            // 
            this.btnTaller.FlatAppearance.BorderSize = 0;
            this.btnTaller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaller.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaller.Location = new System.Drawing.Point(337, 9);
            this.btnTaller.Name = "btnTaller";
            this.btnTaller.Size = new System.Drawing.Size(151, 57);
            this.btnTaller.TabIndex = 3;
            this.btnTaller.Text = "Taller";
            this.btnTaller.UseVisualStyleBackColor = true;
            this.btnTaller.Click += new System.EventHandler(this.btnTaller_Click);
            // 
            // btnBicicletas
            // 
            this.btnBicicletas.FlatAppearance.BorderSize = 0;
            this.btnBicicletas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBicicletas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBicicletas.Location = new System.Drawing.Point(180, 9);
            this.btnBicicletas.Name = "btnBicicletas";
            this.btnBicicletas.Size = new System.Drawing.Size(151, 57);
            this.btnBicicletas.TabIndex = 2;
            this.btnBicicletas.Text = "Bicicletas";
            this.btnBicicletas.UseVisualStyleBackColor = true;
            this.btnBicicletas.Click += new System.EventHandler(this.btnBicicletas_Click);
            // 
            // bannerLogo
            // 
            this.bannerLogo.BackColor = System.Drawing.Color.Tan;
            this.bannerLogo.Controls.Add(this.imgLogo);
            this.bannerLogo.Location = new System.Drawing.Point(0, 0);
            this.bannerLogo.Name = "bannerLogo";
            this.bannerLogo.Size = new System.Drawing.Size(175, 73);
            this.bannerLogo.TabIndex = 1;
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.Tan;
            this.imgLogo.BackgroundImage = global::ProyectoLenguajes.Properties.Resources.logoBicis;
            this.imgLogo.Location = new System.Drawing.Point(40, 4);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(86, 66);
            this.imgLogo.TabIndex = 2;
            this.imgLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ProyectoLenguajes.Properties.Resources.imgBanner;
            this.pictureBox1.Location = new System.Drawing.Point(0, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(942, 500);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Interfaz_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 568);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelNavbar);
            this.Name = "Interfaz_admin";
            this.Text = "Form2";
            this.panelNavbar.ResumeLayout(false);
            this.bannerLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNavbar;
        private System.Windows.Forms.Button btnUbicacion;
        private System.Windows.Forms.Button btnTaller;
        private System.Windows.Forms.Button btnBicicletas;
        private System.Windows.Forms.Panel bannerLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Button btnPerfil;
    }
}