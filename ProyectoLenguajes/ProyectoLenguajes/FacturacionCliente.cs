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
    public partial class FacturacionCliente : Form
    {
        public FacturacionCliente(String usuario_activo)
        {
            InitializeComponent();
            this.usuario_activo = usuario_activo;
        }

        String usuario_activo;
        OracleConnection ora = new OracleConnection("DATA SOURCE = ORCL; PASSWORD =DBFide1; USER ID = system;");

    }
}
