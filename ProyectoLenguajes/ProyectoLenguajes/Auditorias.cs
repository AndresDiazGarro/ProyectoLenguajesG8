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
    public partial class Auditorias : Form
    {
        public Auditorias(string usuario_activo)
        {
            InitializeComponent();
            this.usuario_activo = usuario_activo;
        }
        string usuario_activo;
        private void btn2_regresarform4_Click(object sender, EventArgs e)
        {
            Interfaz_admin interf_admin = new Interfaz_admin(usuario_activo);
            interf_admin.Show();
            this.Hide();
        }

        private void btn_AuditBike_Click(object sender, EventArgs e)
        {
            Auditoria_Bici auditsBici = new Auditoria_Bici(usuario_activo);
            auditsBici.Show();
            this.Hide();
        }
    }
}
