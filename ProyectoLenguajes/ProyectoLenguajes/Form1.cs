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
        OracleConnection conexion = new OracleConnection("DATA SOURCE = ORCL; PASSWORD = DBFide1; USER ID = system;");
      
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
        {/*************/
            string usuario_activo = null;
            Interfaz_admin int_admin = new Interfaz_admin(usuario_activo);
            int_admin.Show();
            this.Hide();/*****************/
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            conexion.Open();
            try { 
                OracleCommand comando = new OracleCommand("INICIO_SESION.VERIFICAR_USUARIO", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("usua", OracleType.VarChar).Value = txtUsuario.Text;
                comando.Parameters.Add("cont", OracleType.VarChar).Value = txtContrasena.Text;
                comando.ExecuteNonQuery();
                String usuario_activo = txtUsuario.Text;


                OracleCommand comando2 = new OracleCommand("INICIO_SESION.VERIFICAR_ROL", conexion);
                comando2.CommandType = System.Data.CommandType.StoredProcedure;
                comando2.Parameters.Add("usua", OracleType.VarChar).Value = txtUsuario.Text;
                comando2.Parameters.Add("rol_cursor", OracleType.Cursor).Direction = ParameterDirection.Output;
                comando2.ExecuteNonQuery();
                OracleDataReader registro = comando2.ExecuteReader();
                if (registro.Read())
                {
                    if (registro["Rol"].ToString().Equals("Cliente"))
                    {
                        MessageBox.Show("Ingreso exitoso");
                        Interfaz_cliente int_cliente = new Interfaz_cliente(usuario_activo);
                        int_cliente.Show();
                        this.Hide();
                    }
                    else if (registro["Rol"].ToString().Equals("Administrador"))
                    {
                        MessageBox.Show("Ingreso exitoso");
                        Interfaz_admin int_admin = new Interfaz_admin(usuario_activo);
                        int_admin.Show();
                        this.Hide();
                    }
                }
                
            }catch(Exception no_data_found)
            {
                MessageBox.Show("Ingreso inválido");
            }
            conexion.Close();
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
