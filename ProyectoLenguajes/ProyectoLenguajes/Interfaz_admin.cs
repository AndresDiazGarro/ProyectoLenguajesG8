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
    public partial class Interfaz_admin : Form
    {
        public Interfaz_admin(String usuario_activo)
        {
            InitializeComponent();
            this.usuario_activo = usuario_activo;
        }
        String usuario_activo;

        private void btnBicicletas_Click(object sender, EventArgs e)
        {
            Form4 formulario4 = new Form4(usuario_activo);
            formulario4.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Perfil_admin perfil_admin = new Perfil_admin(usuario_activo);
            perfil_admin.Show();
            this.Hide();
        }

        private void btnUbicacion_Click(object sender, EventArgs e)
        {
            Ubicacion ubicacion = new Ubicacion();
            ubicacion.Show();
            this.Hide();
        }

        private void btnTaller_Click(object sender, EventArgs e)
        {
            Taller taller = new Taller(usuario_activo);
            taller.Show();
            this.Hide();
        }

        private void btnSN_Click(object sender, EventArgs e)
        {
            SobreNosotros SN = new SobreNosotros(usuario_activo);
            SN.Show();
            this.Hide();
        }

        private void btn_Audits_Click(object sender, EventArgs e)
        {
            Auditorias aud = new Auditorias(usuario_activo);
            aud.Show();
            this.Hide();
        }

        private void imgLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
