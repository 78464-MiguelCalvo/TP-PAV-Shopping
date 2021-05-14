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
    public partial class FormBarrios : Form
    {
        public FormBarrios()
        {
            InitializeComponent();
        }

        // metodos para limpiar campos del form
        private void LimpiarCamposPnlBuscarTarjeta()
        {
            txtBuscarNombreBarrio.Text = "";
            txtBuscarIDBarrio.Text = "";
        }

        private void LimpiarCamposPnlModificarEliminarTarjeta()
        {
            txtNombreBarrio.Text = "";
            txtIDBarrio.Text = "";
        }

        private void LimpiarCamposPnlAgregarTarjeta()
        {
            txtNombreNuevoBarrio.Text = "";
        }

        private void FormTarjetas_Load(object sender, EventArgs e)
        {

        }

        private void FormBarrios_Load(object sender, EventArgs e)
        {

        }
    }
}
