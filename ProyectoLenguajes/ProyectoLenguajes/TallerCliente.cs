using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Oracle conexion
using System.Data.OracleClient;

namespace ProyectoLenguajes
{
    public partial class TallerCliente : Form
    {
        public TallerCliente(String usuario_activo)
        {
            InitializeComponent();
            this.usuario_activo = usuario_activo;
        }

     String usuario_activo;
     OracleConnection ora = new OracleConnection("DATA SOURCE = ORCL; PASSWORD =DBFide1; USER ID = system;");

        private void btnConsultarEnInventario_Click(object sender, EventArgs e)
        {
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("consultaTaller", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("bicis", OracleType.Cursor).Direction = ParameterDirection.Output;
                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabladeBicis = new DataTable();
                adaptador.Fill(tabladeBicis);
                bicisGrid.DataSource = tabladeBicis;
                ora.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Algo Falló durante la consulta.");
            }

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Interfaz_admin formulario2 = new Interfaz_admin(usuario_activo);
            formulario2.Show();
            this.Hide();
        }
    }


}
