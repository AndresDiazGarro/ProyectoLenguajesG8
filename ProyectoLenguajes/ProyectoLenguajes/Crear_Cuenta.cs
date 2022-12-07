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
                OracleCommand comando1 = new OracleCommand("CREACION_CUENTA.VERIFICAR_REPETIDO", conexion);
                comando1.CommandType = System.Data.CommandType.StoredProcedure;
                comando1.Parameters.Add("usua", OracleType.VarChar).Value = txtUsuario.Text;
                comando1.ExecuteNonQuery();

                MessageBox.Show("El nombre de usuario ya existe");

            }
            catch (Exception)
            {


                try
                {
                    OracleCommand comando2 = new OracleCommand("CREACION_CUENTA.CREAR_USUARIO", conexion);
                    comando2.CommandType = System.Data.CommandType.StoredProcedure;
                    comando2.Parameters.Add("nom", OracleType.VarChar).Value = txtNombre.Text;
                    comando2.Parameters.Add("apell", OracleType.VarChar).Value = txtApellido.Text;
                    comando2.Parameters.Add("usua", OracleType.VarChar).Value = txtUsuario.Text;
                    comando2.Parameters.Add("cont", OracleType.VarChar).Value = txtContrasena.Text;
                    if (rbCliente.Checked == true)
                    {
                        comando2.Parameters.Add("rol", OracleType.VarChar).Value = "Cliente";
                    }
                    else if (rbAdministrador.Checked == true && txtClave.Text.Equals("admin"))
                    {
                        comando2.Parameters.Add("rol", OracleType.VarChar).Value = "Administrador";
                    }

                    comando2.ExecuteNonQuery();




                    MessageBox.Show("Cuenta creada con éxito");

                    Login formulario1 = new Login();
                    formulario1.Show();
                    this.Hide();


                }
                catch (Exception)
                {

                    MessageBox.Show("Error al crear la cuenta");


                }
                
            }
            conexion.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
