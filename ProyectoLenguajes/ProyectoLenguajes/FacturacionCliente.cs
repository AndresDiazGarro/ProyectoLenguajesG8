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
    public partial class FacturacionCliente : Form
    {
        public FacturacionCliente(String usuario_activo)
        {
            InitializeComponent();
            this.usuario_activo = usuario_activo;

            /* Generar numero de factura aleatorio*/
            Random aleatorio = new Random();

            int numero = 0;
            numero = aleatorio.Next(0, 1000000);
            lblFactura.Text = numero.ToString();


            /* Cargar fecha automáticamente*/

            DateTime fecha = DateTime.Today;
            lblFecha.Text = fecha.ToShortDateString().ToString();

            OracleConnection conexion = new OracleConnection("DATA SOURCE = ORCL; PASSWORD =DBFide1; USER ID = system;");
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
                    lblNombre.Text = datos["Nombre"].ToString();
                    lblApellido.Text = datos["Apellido"].ToString();
                    lblUser.Text = datos["Nom_usuario"].ToString();
                    lblID.Text = datos["ID_Usuario"].ToString();
                    

                }


            }
            catch (Exception)
            {
                MessageBox.Show("No se cargaron los datos del usuario");

            }
            conexion.Close();
        }

        String usuario_activo;

      

        private void button1_Click_1(object sender, EventArgs e)
        {
            /* Ejecutar el trunc table de las tablas factura y factura detalle*/
            OracleConnection conexion = new OracleConnection("DATA SOURCE = ORCL; PASSWORD =DBFide1; USER ID = system;");
            conexion.Open();
            OracleCommand comando1 = new OracleCommand("LIMPIA_FACTURA", conexion);
            comando1.CommandType = System.Data.CommandType.StoredProcedure;

            comando1.ExecuteNonQuery();
            //MessageBox.Show("Tablas Limpias");
            conexion.Close();

            Interfaz_cliente formulario2 = new Interfaz_cliente(usuario_activo);
            formulario2.Show();
            this.Hide();
        }

        private void btnDetalles_Click_1(object sender, EventArgs e)
        {
            OracleConnection conexion = new OracleConnection("DATA SOURCE = ORCL; PASSWORD =DBFide1; USER ID = system;");

            /* Agregar datos a la factura*/

            try
            {
                conexion.Open();
                OracleCommand comando1 = new OracleCommand("FACTURACION", conexion);
                comando1.CommandType = System.Data.CommandType.StoredProcedure;
                comando1.Parameters.Add("ADD_ID_FACTURA", OracleType.VarChar).Value = lblFactura.Text;
                comando1.Parameters.Add("ADD_NOMBRE", OracleType.VarChar).Value = lblNombre.Text;
                comando1.Parameters.Add("ADD_APELLIDO", OracleType.VarChar).Value = lblApellido.Text;
                comando1.Parameters.Add("ADD_USUARIO", OracleType.VarChar).Value = lblUser.Text;
                comando1.Parameters.Add("ADD_IDENTIFICACION", OracleType.VarChar).Value = lblID.Text;
                comando1.Parameters.Add("ADD_TERMINOS", OracleType.VarChar).Value = textTerm.Text;
                comando1.Parameters.Add("ADD_FECHA", OracleType.VarChar).Value = lblFecha.Text;

                comando1.ExecuteNonQuery();
                // MessageBox.Show("Maestro agregado con éxito");

                try
                {
                    OracleCommand comando2 = new OracleCommand("DETALLE_FACTURA", conexion);
                    comando2.CommandType = System.Data.CommandType.StoredProcedure;
                    comando2.Parameters.Add("ADD_DESCRIPCION", OracleType.VarChar).Value = txtDesc.Text;
                    comando2.Parameters.Add("ADD_CANTIDAD", OracleType.VarChar).Value = txtCant.Text;
                    comando2.Parameters.Add("ADD_PRECIO", OracleType.VarChar).Value = txtPrec.Text;
                    comando2.Parameters.Add("ADD_MONTO", OracleType.VarChar).Value = txtMont.Text;
                    comando2.Parameters.Add("ADD_ID_FACTURA", OracleType.VarChar).Value = lblFactura.Text;

                    comando2.ExecuteNonQuery();
                   // MessageBox.Show("Detalle agregado con éxito");

                }
                catch (Exception)
                {
                    MessageBox.Show("Error al agregar el detalle");

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error al agregar encabezado");

            }

           

            /*Mostrar los datos recién agregados a la factura */

            OracleCommand comando = new OracleCommand("seleccionarDetalle", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("detalle", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable detalleFactura = new DataTable();
            adaptador.Fill(detalleFactura);
            detallesGrid.DataSource = detalleFactura;

            conexion.Close();
        }
    }
}
