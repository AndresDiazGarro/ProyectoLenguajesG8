using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoLenguajes
{
    public partial class Interfaz_cliente : Form
    {
        public Interfaz_cliente(String usuario_activo)
        {
            InitializeComponent();
            this.usuario_activo = usuario_activo;
        }

        String usuario_activo;

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            Perfil_Cliente perfil_cliente = new Perfil_Cliente(usuario_activo);
            perfil_cliente.Show();
            this.Hide();
        }

        private void btnTaller_Click(object sender, EventArgs e)
        {
            TallerCliente taller = new TallerCliente(usuario_activo);
            taller.Show();
            this.Hide();
        }

        private void btnUbicacion_Click(object sender, EventArgs e)
        {
            UbicacionCliente ub = new UbicacionCliente(usuario_activo);
            ub.Show();
            this.Hide();
        }

        private void btnSN_Click(object sender, EventArgs e)
        {
            SobreNosotros sn = new SobreNosotros(usuario_activo);
            sn.Show();
            this.Hide();
        }

        private void btnBicicletas_Click(object sender, EventArgs e)
        {
            BiciCliente BC = new BiciCliente(usuario_activo);
            BC.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FacturacionCliente fact = new FacturacionCliente(usuario_activo);
            fact.Show();
            this.Hide();
        }
    }
}
