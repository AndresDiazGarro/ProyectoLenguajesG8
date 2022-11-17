using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoLenguajes
{
    public partial class Perfil : Form
    {
        public Perfil(String usuario_activo)
        {
            InitializeComponent();
            this.usuario_activo = usuario_activo;
        }

        String usuario_activo;
        OracleConnection conexion = new OracleConnection("DATA SOURCE = ORCL; PASSWORD = DBFide1; USER ID = system;");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Perfil_Load(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("MOSTRAR_DATOS_USUARIOS", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("usua_act", OracleType.VarChar).Value = usuario_activo;
                comando.Parameters.Add("nom", OracleType.VarChar).Direction = ParameterDirection.Output;
                comando.Parameters.Add("apell", OracleType.VarChar).Direction = ParameterDirection.Output;
                comando.Parameters.Add("usua", OracleType.VarChar).Direction = ParameterDirection.Output;
                comando.Parameters.Add("cont", OracleType.VarChar).Direction = ParameterDirection.Output;
                comando.ExecuteNonQuery();
                txtUsuario.Text = usuario_activo;
                OracleDataReader datos = comando.ExecuteReader();
                if (datos.Read())
                {
                    
                }


            } catch (Exception)
            {

            }
            conexion.Close();
        }
    }
}
