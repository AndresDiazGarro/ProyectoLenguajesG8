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
    public partial class Perfil_admin : Form
    {
        OracleConnection conexion = new OracleConnection("DATA SOURCE = ORCL; PASSWORD = DBFide1; USER ID = system;");

        public Perfil_admin(String usuario_activo)
        {
            InitializeComponent();
            this.usuario_activo = usuario_activo;
        }

        String usuario_activo;

        private void Perfil_admin_Load(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("PERFIL.MOSTRAR_DATOS_USUARIO", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("usua_act", OracleType.VarChar).Value = usuario_activo;
                comando.Parameters.Add("datos_usuario", OracleType.Cursor).Direction = ParameterDirection.Output;
                comando.ExecuteNonQuery();
                OracleDataReader datos = comando.ExecuteReader();
                if (datos.Read())
                {

                    txtNombre.Text = datos["Nombre"].ToString();
                    txtApellidos.Text = datos["Apellido"].ToString();
                    txtUsuario.Text = datos["Nom_usuario"].ToString();
                    txtContrasena.Text = datos["Contrasena"].ToString();
                    if (datos["Rol"].ToString().Equals("Cliente"))
                    {
                        rbCliente.Checked = true;
                    }
                    else if (datos["Rol"].ToString().Equals("Administrador"))
                    {
                        rbAdministrador.Checked = true;
                    }

                }


            }
            catch (Exception)
            {
                MessageBox.Show("Algo salió mal");

            }
            conexion.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("PERFIL.ACTUALIZAR_USUARIO", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("usua_act", OracleType.VarChar).Value = usuario_activo;
                comando.Parameters.Add("nom", OracleType.VarChar).Value = txtNombre.Text;
                comando.Parameters.Add("apell", OracleType.VarChar).Value = txtApellidos.Text;
                comando.Parameters.Add("usua", OracleType.VarChar).Value = txtUsuario.Text;
                comando.Parameters.Add("cont", OracleType.VarChar).Value = txtContrasena.Text;
                if (rbCliente.Checked == true)
                {
                    comando.Parameters.Add("rol_nuevo", OracleType.VarChar).Value = "Cliente";
                }
                else if (rbAdministrador.Checked == true && txtClave.Text.Equals("admin"))
                {
                    comando.Parameters.Add("rol_nuevo", OracleType.VarChar).Value = "Administrador";
                }
                comando.ExecuteNonQuery();
                usuario_activo = txtUsuario.Text;

                OracleCommand comando2 = new OracleCommand("INICIO_SESION.VERIFICAR_ROL", conexion);
                comando2.CommandType = System.Data.CommandType.StoredProcedure;
                comando2.Parameters.Add("usua", OracleType.VarChar).Value = usuario_activo;
                comando2.Parameters.Add("rol_cursor", OracleType.Cursor).Direction = ParameterDirection.Output;
                comando2.ExecuteNonQuery();
                OracleDataReader registro = comando2.ExecuteReader();
                if (registro.Read())
                {
                    if (registro["Rol"].ToString().Equals("Cliente"))
                    {
                        MessageBox.Show("Actualización exitosa");
                        Interfaz_cliente int_cliente = new Interfaz_cliente(usuario_activo);
                        int_cliente.Show();
                        this.Hide();
                    }
                    else if (registro["Rol"].ToString().Equals("Administrador"))
                    {
                        MessageBox.Show("Actualización exitosa");
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Actualización inválida");

            }
            conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("PERFIL.ELIMINAR_USUARIO", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("usua_act", OracleType.VarChar).Value = usuario_activo;
                comando.ExecuteNonQuery();
                MessageBox.Show("Cuenta eliminada con éxito");
                Login formulario1 = new Login();
                formulario1.Show();
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la eliminación");

            }
            conexion.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login formulario1 = new Login();
            formulario1.Show();
            this.Hide();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Interfaz_admin int_admin = new Interfaz_admin(usuario_activo);
            int_admin.Show();
            this.Hide();
        }
    }
}
