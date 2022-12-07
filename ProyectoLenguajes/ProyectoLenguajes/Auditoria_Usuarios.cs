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
    public partial class Auditoria_Usuarios : Form
    {
        public Auditoria_Usuarios(String usuario_activo)
        {
            InitializeComponent();
            this.usuario_activo = usuario_activo;
        }

        String usuario_activo;

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            OracleConnection conexion = new OracleConnection("DATA SOURCE = ORCL; PASSWORD =DBFide1; USER ID = system;");
            conexion.Open();
            OracleCommand comando = new OracleCommand("seleccionarUsuariosAudits", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("audit_usuarios", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador2 = new OracleDataAdapter();
            adaptador2.SelectCommand = comando;
            DataTable tabladeUsuarios = new DataTable();
            adaptador2.Fill(tabladeUsuarios);
            AuditbicisGrid.DataSource = tabladeUsuarios;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Auditorias audits = new Auditorias(usuario_activo);
            audits.Show();
            this.Hide();
        }
    }
}
