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
    public partial class Form2 : Form
    {
        public Form2(String usuario_activo)
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
            Perfil perfil = new Perfil(usuario_activo);
            perfil.Show();
            this.Hide();
        }

        private void btnUbicacion_Click(object sender, EventArgs e)
        {
            Ubicacion ubicacion = new Ubicacion();
            ubicacion.Show();
            this.Hide();
        }
    }
}
