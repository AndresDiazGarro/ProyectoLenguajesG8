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
    public partial class AgregarBici : Form
    {
        OracleConnection conexion = new OracleConnection("DATA SOURCE = ORCL; PASSWORD = DBFide1; USER ID = system;");

        public AgregarBici(string usuario_activo)
        {
            InitializeComponent();
            this.usuario_activo = usuario_activo;
        }
        string usuario_activo;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_AgregarBici_Click(object sender, EventArgs e)
        {
                try
                {
                    conexion.Open();
                    OracleCommand comando2 = new OracleCommand("AGREGAR_BICI", conexion);
                    comando2.CommandType = System.Data.CommandType.StoredProcedure;
                    comando2.Parameters.Add("ADD_ID_BICICLETA", OracleType.VarChar).Value = txt_idBici.Text;
                    comando2.Parameters.Add("ADD_NOMBRE", OracleType.VarChar).Value = txt_NombreBici.Text;
                    comando2.Parameters.Add("ADD_PRECIO", OracleType.VarChar).Value = txt_PrecioBici.Text;
                    comando2.Parameters.Add("ADD_ID_FRENOS", OracleType.VarChar).Value = txt_Frenos.Text;
                    comando2.Parameters.Add("ADD_ID_TRANSMISION", OracleType.VarChar).Value = txt_Transm.Text;
                    comando2.Parameters.Add("ADD_ID_SUSPENSION", OracleType.VarChar).Value = txt_Susp.Text;
                    comando2.Parameters.Add("ADD_ID_RUEDAS", OracleType.VarChar).Value = txt_Ruedas.Text;
                    comando2.Parameters.Add("ADD_ID_MARCO", OracleType.VarChar).Value = txt_Marco.Text;
                    comando2.Parameters.Add("ADD_ID_MARCA", OracleType.VarChar).Value = txt_Marca.Text;
              
                    comando2.ExecuteNonQuery();
                    MessageBox.Show("Bicicleta agregada con éxito");

                    Form4 f4 = new Form4(usuario_activo);
                    f4.Show();
                    this.Hide();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al agregar la bicicleta");

                }
                conexion.Close();
        }

        private void btn_regresarform4_Click(object sender, EventArgs e)
        {
            Form4 formulario4 = new Form4(usuario_activo);
            formulario4.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
    }

