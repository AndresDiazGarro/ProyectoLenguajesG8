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
        {
            /****************** QUITAR ESTAS 4 LINEAS DE CODIGO *************************/
            string usuario_activo = null;/**/
            Form2 f2 = new Form2(usuario_activo);/**/
            f2.Show();/**/
            this.Hide();/**/
            /****************** QUITAR ESTAS 4 LINEAS DE CODIGO *************************/
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
                MessageBox.Show("Ingreso exitoso");


                OracleCommand comando2 = new OracleCommand("INICIO_SESION.VERIFICAR_ROL", conexion);
                comando2.CommandType = System.Data.CommandType.StoredProcedure;
                comando2.Parameters.Add("usua", OracleType.VarChar).Value = txtUsuario.Text;
                comando2.Parameters.Add("result", OracleType.Number).Direction = System.Data.ParameterDirection.ReturnValue;
                comando2.ExecuteNonQuery();
                int resultado = (int)comando.Parameters["result"].Value;
                //MessageBox.Show("resultado: " + resultado);
                if (resultado == 0)
                {
                    Form2 formulario3 = new Form2(usuario_activo);
                    formulario3.Show();
                    this.Hide();
                } else if (resultado == 1)
                {
                    Interfaz_admin int_admin = new Interfaz_admin();
                    int_admin.Show();
                    this.Hide();
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
