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
    public partial class Form4 : Form
    {
        public Form4(String usuario_activo)
        {
            InitializeComponent();
            this.usuario_activo = usuario_activo;
        }

        String usuario_activo;

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            OracleConnection conexion = new OracleConnection("DATA SOURCE = ORCL; PASSWORD =DBFide1; USER ID = system;");
            conexion.Open();
            OracleCommand comando = new OracleCommand("seleccionarBicicletas", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("bicis", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabladeBicis = new DataTable();
            adaptador.Fill(tabladeBicis);
            bicisGrid.DataSource= tabladeBicis;
        }

        private void bicisGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form2 formulario2 = new Form2(usuario_activo);
            formulario2.Show();
            this.Hide();
        }
    }
}
