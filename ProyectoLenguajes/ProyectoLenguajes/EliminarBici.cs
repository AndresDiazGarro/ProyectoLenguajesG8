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
    public partial class EliminarBici : Form
    {
        OracleConnection conexion = new OracleConnection("DATA SOURCE = ORCL; PASSWORD = DBFide1; USER ID = system;");
        public EliminarBici(string usuario_activo)
        {
            InitializeComponent();
            this.usuario_activo = usuario_activo;
        }
        string usuario_activo;
        private void btn_AgregarBici_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand comando2 = new OracleCommand("ELIMINAR_BICI", conexion);
                comando2.CommandType = System.Data.CommandType.StoredProcedure;
                comando2.Parameters.Add("DEL_BICICLETA", OracleType.VarChar).Value = txt_idBicidel.Text;

                comando2.ExecuteNonQuery();
                MessageBox.Show("Bicicleta eliminada con éxito");

                Form4 f4 = new Form4(usuario_activo);
                f4.Show();
                this.Hide();

            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar la bicicleta");
                    
            }
            conexion.Close();
        }

        private void btn2_regresarform4_Click(object sender, EventArgs e)
        {
            string usuario_activo = null;
            Form4 f4 = new Form4(usuario_activo);
            f4.Show();
            this.Hide();
        }
    }
}
