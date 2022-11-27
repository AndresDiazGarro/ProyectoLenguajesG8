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
    public partial class SobreNosotros : Form
    {
        public SobreNosotros(String usuario_activo)
        {
            InitializeComponent();
            this.usuario_activo = usuario_activo;
        }

        String usuario_activo;

        private void SobreNosotros_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form2 formulario2 = new Form2(usuario_activo);
            formulario2.Show();
            this.Hide();
        }
    }
}
