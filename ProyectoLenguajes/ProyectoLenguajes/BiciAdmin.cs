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
    public partial class BiciAdmin : Form
    {
        public BiciAdmin(String usuario_activo)
        {
            InitializeComponent();
            this.usuario_activo = usuario_activo;
        }
        int indexRow;
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
            Interfaz_admin formulario2 = new Interfaz_admin(usuario_activo);
            formulario2.Show();
            this.Hide();
        }

        private void btnAddBike_Click(object sender, EventArgs e)
        {
            AgregarBici AddBike = new AgregarBici(usuario_activo);
            AddBike.Show();
            this.Hide();
        }

        private void btnDelBike_Click(object sender, EventArgs e)
        {
            EliminarBici DelBike = new EliminarBici(usuario_activo);
            DelBike.Show();
            this.Hide();
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            ActualizarBici UpdBike = new ActualizarBici(usuario_activo);
            UpdBike.Show();
            this.Hide();
        }

        private void bicisGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
