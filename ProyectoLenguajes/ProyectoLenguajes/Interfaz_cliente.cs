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
            Perfil perfil = new Perfil(usuario_activo);
            perfil.Show();
            this.Hide();
        }

        private void btnTaller_Click(object sender, EventArgs e)
        {
            TallerCliente taller = new TallerCliente(usuario_activo);
            taller.Show();
            this.Hide();
        }
    }
}
