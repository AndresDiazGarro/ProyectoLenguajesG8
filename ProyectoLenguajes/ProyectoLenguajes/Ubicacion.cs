using GMap.NET;
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
    public partial class Ubicacion : Form

    {
        OracleConnection conexion = new OracleConnection("DATA SOURCE = ORCL; PASSWORD = DBFide1; USER ID = system;");

        public Ubicacion(String usuario_activo)
        {
            InitializeComponent();
            this.usuario_activo = usuario_activo;
        }


        String usuario_activo;

        private void button1_Click(object sender, EventArgs e)
        {
            gMap.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance; //Establece proveedor de mapas
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly; //Configura en solo datos del servidor
            //gMap.SetPositionByKeywords("San Jose, Costa Rica"); //Establecer Ciudad, Pais
            //gMap.Position = new GMap.NET.PointLatLng(9.9363147, -84.0790631); //Coordenadas de Ciclo Boutique CR
            gMap.SetPositionByKeywords("Guanacaste, Costa Rica"); //Establecer Ciudad, Pais
            double latitud = 0.0;
            double longitud = 0.0;
            try
            {

                conexion.Open();
                OracleCommand comando = new OracleCommand("seleccionarCoordenadas", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.Add("filas_coordenadas", OracleType.Cursor).Direction = ParameterDirection.Output;
                comando.ExecuteNonQuery();
                OracleDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {

                    latitud = double.Parse(registro["latitud"].ToString());
                    longitud = double.Parse(registro["longitud"].ToString());

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            conexion.Close();
            // gMap.Position = new GMap.NET.PointLatLng(latitud, longitud); //Coordenadas de Ciclo Boutique CR
            gMap.Position = new PointLatLng(latitud, longitud);
            gMap.ShowCenter = false; //Eliminar + Rojo en gMap
        }

        private void gMap_Load(object sender, EventArgs e)
        {
            gMap.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance; //Establece proveedor de mapas
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly; //Configura en solo datos del servidor
            gMap.SetPositionByKeywords("San Jose, Costa Rica"); //Establecer Ciudad, Pais
            gMap.Position = new GMap.NET.PointLatLng(9.9363147, -84.0790631); //Coordenadas de Ciclo Boutique CR
            gMap.ShowCenter = false; //Eliminar + Rojo en gMap
        }


        private void Ubicacion_Load(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            conexion.Open();

        }
    }
}
