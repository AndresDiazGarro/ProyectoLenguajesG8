using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace ProyectoLenguajes
{
    public partial class Form1 : Form

    {
        OracleConnection conexion = new OracleConnection("DATA SOURCE = ORCL; PASSWORD = Kath170521; USER ID = system;");
      
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            conexion.Open();
            try { 
                OracleCommand comando = new OracleCommand("VERIFICAR_USUARIO", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("usua", OracleType.VarChar).Value = txtUsuario.Text;
                comando.Parameters.Add("cont", OracleType.VarChar).Value = txtContrasena.Text;
                comando.ExecuteNonQuery();
                String usuario_activo = txtUsuario.Text;
                MessageBox.Show("Ingreso exitoso");
                Form2 formulario3 = new Form2(usuario_activo);
                formulario3.Show();
                this.Hide();
            }catch(Exception no_data_found)
            {
                MessageBox.Show("Ingreso inválido");
            }
            conexion.Close();

            /*OracleCommand comando = new OracleCommand("SELECT * FROM USUARIOS WHERE NOM_USUARIO = :nom_usuario AND CONTRASENA = :contrasena", conexion);

            comando.Parameters.AddWithValue(":nom_usuario", txtusuario.Text);
            comando.Parameters.AddWithValue(":contrasena", txtcontrasena.Text);

            OracleDataReader lector = comando.ExecuteReader();
            {
                if (lector.Read())
                {
                    Form1 formulario1 = new Form1();
                    conexion.Close();
                    formulario1.Show();

                    MessageBox.Show("Correcto bb");
                }
                else
                {

                    MessageBox.Show("Incorrecto bb");
                }
            }*/
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Crear_Cuenta formulario3 = new Crear_Cuenta();
            formulario3.Show();

            this.Hide();
        }
    }
}
