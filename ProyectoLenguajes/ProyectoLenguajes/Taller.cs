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
    public partial class Taller : Form
    {
        public Taller(String usuario_activo)
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


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("insertarTaller", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                //selecciona el index del data grid
                DataGridViewRow row = this.dataGridViewTaller.SelectedRows[0];

                //agregamos los valores ingresados en el data grid como parametro

                //convertimos string a numero
                string id = Convert.ToString(row.Cells["ID_BICICLETA"].Value);
                comando.Parameters.Add("idBici", OracleType.VarChar).Value = int.Parse(id);


                comando.Parameters.Add("nombre", OracleType.VarChar).Value = row.Cells["NOMBRE"].Value;
                comando.Parameters.Add("frenos", OracleType.VarChar).Value = row.Cells["NOMBRE_FRENOS"].Value;
                comando.Parameters.Add("transmision", OracleType.VarChar).Value = row.Cells["NOMBRE_TRANSMISION"].Value;
                comando.Parameters.Add("susp", OracleType.VarChar).Value = row.Cells["NOMBRE_SUSP"].Value;
                comando.Parameters.Add("ruedas", OracleType.VarChar).Value = row.Cells["NOMBRE_RUEDAS"].Value;
                comando.Parameters.Add("marco", OracleType.VarChar).Value = row.Cells["NOMBRE_MARCO"].Value;
                comando.Parameters.Add("marca", OracleType.VarChar).Value = row.Cells["NOMBRE_MARCA"].Value;
                comando.Parameters.Add("problemas", OracleType.VarChar).Value = row.Cells["PROBLEMAS_REPORTADOS"].Value;
                comando.Parameters.Add("observaciones", OracleType.VarChar).Value = row.Cells["OBSERVACIONES_MECANICO"].Value;
                comando.Parameters.Add("mecanico", OracleType.VarChar).Value = row.Cells["MECANICO_REVISION"].Value;

                //convertimos string a numero
                string precioC = Convert.ToString(row.Cells["PRECIO_REVISION"].Value);
                comando.Parameters.Add("precioRevision", OracleType.VarChar).Value = int.Parse(precioC);

                comando.ExecuteNonQuery();
                MessageBox.Show("Datos insertados.");
            }
            catch (Exception)
            {
                MessageBox.Show("Algo Falló durante la consulta.");
            }
            ora.Close();
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {

            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("updateTaller", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                //selecciona el index del data grid
                DataGridViewRow row = this.bicisGrid.SelectedRows[0];

                //agregamos los valores ingresados en el data grid como parametro

                //convertimos string a numero
                string id = Convert.ToString(row.Cells["ID_BICICLETA"].Value);
                comando.Parameters.Add("idBici", OracleType.VarChar).Value = int.Parse(id);


                comando.Parameters.Add("nombre", OracleType.VarChar).Value = row.Cells["NOMBRE"].Value;
                comando.Parameters.Add("frenos", OracleType.VarChar).Value = row.Cells["NOMBRE_FRENOS"].Value;
                comando.Parameters.Add("transmision", OracleType.VarChar).Value = row.Cells["NOMBRE_TRANSMISION"].Value;
                comando.Parameters.Add("susp", OracleType.VarChar).Value = row.Cells["NOMBRE_SUSP"].Value;
                comando.Parameters.Add("ruedas", OracleType.VarChar).Value = row.Cells["NOMBRE_RUEDAS"].Value;
                comando.Parameters.Add("marco", OracleType.VarChar).Value = row.Cells["NOMBRE_MARCO"].Value;
                comando.Parameters.Add("marca", OracleType.VarChar).Value = row.Cells["NOMBRE_MARCA"].Value;
                comando.Parameters.Add("problemas", OracleType.VarChar).Value = row.Cells["PROBLEMAS_REPORTADOS"].Value;
                comando.Parameters.Add("observaciones", OracleType.VarChar).Value = row.Cells["OBSERVACIONES_MECANICO"].Value;
                comando.Parameters.Add("mecanico", OracleType.VarChar).Value = row.Cells["MECANICO_REVISION"].Value;

                //convertimos string a numero
                string precioC = Convert.ToString(row.Cells["PRECIO_REVISION"].Value);
                comando.Parameters.Add("precioRevision", OracleType.VarChar).Value = int.Parse(precioC);

                comando.ExecuteNonQuery();
                MessageBox.Show("Datos actualizados.");
            }
            catch (Exception)
            {
                MessageBox.Show("Algo Falló durante la consulta.");
            }
            ora.Close();


        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {


            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("eliminarTaller", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                //selecciona el index del data grid
                DataGridViewRow row = this.bicisGrid.SelectedRows[0];

                //agregamos los valores ingresados en el data grid como parametro

                //convertimos string a numero
                string id = Convert.ToString(row.Cells["ID_Bicicleta_Taller"].Value);
                comando.Parameters.Add("idBiciTaller", OracleType.VarChar).Value = int.Parse(id);
                comando.ExecuteNonQuery();
                MessageBox.Show("Datos actualizados.");

                Taller taller = new Taller(usuario_activo);
                taller.Show();
                this.Hide();

            }
            catch (Exception)
            {
                MessageBox.Show("Algo Falló durante la consulta.");
                ora.Close();
            }

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

        private void buttonFactura_Click(object sender, EventArgs e)
        {
            FacturacionAdmin fact = new FacturacionAdmin(usuario_activo);
            fact.Show();
            this.Hide();
        }

        private void bicisGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
