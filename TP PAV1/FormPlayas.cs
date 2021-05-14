using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_PAV1
{
    public partial class FormPlayas : Form
    {
        public FormPlayas()
        {
            InitializeComponent();
        }

        // metodos para limpiar campos del form
        private void LimpiarCamposPnlEstacionamientos()
        {
            txtNroEstacionamiento.Text = "";
            //VER COMBOBOX. selecteditem?
        }

        private void LimpiarCamposPnlPlayas()
        {
            txtPlaya.Text = "";
            txtIDPlaya.Text = "";

        }

        private void FormTarjetas_Load(object sender, EventArgs e)
        {

        }

        private void FormPlayas_Load(object sender, EventArgs e)
        {

        }
    }
}
