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
    public partial class Crear_Cuenta : Form
    {

        OracleConnection conexion = new OracleConnection("DATA SOURCE = ORCL; PASSWORD = DBFide1; USER ID = system;");

        public Crear_Cuenta()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("CREAR_USUARIO", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("nom", OracleType.VarChar).Value = txtNombre.Text;
                comando.Parameters.Add("apell", OracleType.VarChar).Value = txtApellido.Text;
                comando.Parameters.Add("usua", OracleType.VarChar).Value = txtUsuario.Text;
                comando.Parameters.Add("cont", OracleType.VarChar).Value = txtContrasena.Text;
                comando.ExecuteNonQuery();

                
             

                MessageBox.Show("Cuenta creada con éxito");

                Form1 formulario1 = new Form1();
                formulario1.Show();
                this.Hide();


            } catch (Exception) {

                MessageBox.Show("Error al crear la cuenta");


            }
            conexion.Close();
            

        }
    }
}
