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

        public Ubicacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {

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
