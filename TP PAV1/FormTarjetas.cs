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
    public partial class FormTarjetas : Form
    {
        public FormTarjetas()
        {
            InitializeComponent();
        }

        // metodos para limpiar campos del form
        private void LimpiarCamposPnlBuscarTarjeta()
        {
            txtBuscarNombreTarjeta.Text = "";
            txtBuscarIDTarjeta.Text = "";
        }

        private void LimpiarCamposPnlModificarEliminarTarjeta()
        {
            txtNombreTarjeta.Text = "";
            txtIDTarjeta.Text = "";
        }

        private void LimpiarCamposPnlAgregarTarjeta()
        {
            txtNombreNuevaTarjeta.Text = "";
        }

        private void FormTarjetas_Load(object sender, EventArgs e)
        {

        }
    }
}
