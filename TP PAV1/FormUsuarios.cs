using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV1.AD;

namespace TP_PAV1
{
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }
        private void cargarGrilla()
        {
            grillaUsuarios.DataSource = AD_usuario.obtenerUsuarios();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AgregarUsuario ventanaAgregarUsuario = new AgregarUsuario();
            ventanaAgregarUsuario.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            cargarGrilla();
        }
    }
    
}
