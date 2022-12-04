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
    public partial class FacturacionAdmin : Form
    {
        public FacturacionAdmin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            OracleConnection conexion = new OracleConnection("DATA SOURCE = ORCL; PASSWORD =DBFide1; USER ID = system;");
  
            /* Agregar datos a la factura*/
            try
            {
                conexion.Open();
                OracleCommand comando2 = new OracleCommand("DETALLE_FACTURA", conexion);
                comando2.CommandType = System.Data.CommandType.StoredProcedure;
                comando2.Parameters.Add("ADD_DESCRIPCION", OracleType.VarChar).Value = txtDesc.Text;
                comando2.Parameters.Add("ADD_CANTIDAD", OracleType.VarChar).Value = txtCant.Text;
                comando2.Parameters.Add("ADD_PRECIO", OracleType.VarChar).Value = txtPrec.Text;
                comando2.Parameters.Add("ADD_MONTO", OracleType.VarChar).Value = txtMont.Text;

                comando2.ExecuteNonQuery();
                MessageBox.Show("Detalle agregado con éxito");

            }
            catch (Exception)
            {
                MessageBox.Show("Error al agregar el detalle");

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
        }
    }
}
